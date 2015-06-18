namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;
    using System;
    using System.Linq;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string atackerName = commandArgs[1];
            string targetName = commandArgs[2];
            IStarship atackingShip = null, targetShip = null;
            atackingShip = GameEngine.Starships.FirstOrDefault(a => a.Name == atackerName);
            targetShip = GameEngine.Starships.FirstOrDefault(a => a.Name == targetName);
            ProcessStarshipBattle(atackingShip, targetShip);
            
        }


        private void ProcessStarshipBattle(IStarship atackingShip, IStarship targetShip)
        {
            base.ValidateAlive(atackingShip);
            base.ValidateAlive(targetShip);
            if (atackingShip.Location != targetShip.Location)
            {
                Console.WriteLine(Messages.NoSuchShipInStarSystem);
                return;
            }

            IProjectile atack =   atackingShip.ProduceAttack();
            //atack.Hit(targetShip);
            targetShip.RespondToAttack(atack);
            Console.WriteLine(Messages.ShipAttacked, atackingShip.Name, targetShip.Name);
            targetShip.Shields = (targetShip.Shields < 0) ? 0 : targetShip.Shields;
            if (targetShip.Health <=0)
            {
                targetShip.Health = 0;
                Console.WriteLine(Messages.ShipDestroyed, targetShip.Name);
            }
               

        }
    }
}
