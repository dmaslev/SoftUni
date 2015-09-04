using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
using WinterIsComing.Core;
using WinterIsComing.Core.Exceptions;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    class IceGiantCombatHandler : CombatHandler
    {
        private const int iceGiantDemageIncreas = 5;
        public IceGiantCombatHandler(IUnit unit)
            : base(unit)
        {

        }
        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            if (Unit.HealthPoints > 150)
            {
                return candidateTargets;
            }
            return candidateTargets.Take(1);
        }

        public override ISpell GenerateAttack()
        {
            var spell = new Stomp(this.Unit.AttackPoints);
            if (this.Unit.EnergyPoints - spell.EnergyCost < 0)
            {
                throw new NotEnoughEnergyException(string.Format(GlobalMessages.NotEnoughEnergy, this.Unit.Name, spell.GetType().Name));
            }
            this.Unit.EnergyPoints -= spell.EnergyCost;
            this.Unit.AttackPoints += iceGiantDemageIncreas;
            return spell;
        }
    }
}
