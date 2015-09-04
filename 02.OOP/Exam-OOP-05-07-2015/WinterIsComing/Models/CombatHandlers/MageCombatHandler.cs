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
    class MageCombatHandler : CombatHandler
    {
        private bool useFireBreathSkill = true;
        public MageCombatHandler(IUnit unit)
            : base(unit)
        {

        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var targets = candidateTargets.OrderByDescending(c => c.HealthPoints).ThenBy(c => c.Name).Take(3);
            return targets;
        }

        public override ISpell GenerateAttack()
        {
            BaseSpell spell;
            if (useFireBreathSkill)
            {                
                spell = new FireBreath(this.Unit.AttackPoints);
            }
            else
            {
                spell = new Blizzard(this.Unit.AttackPoints * 2);
            }
            if (this.Unit.EnergyPoints - spell.EnergyCost < 0)
            {
                throw new NotEnoughEnergyException(string.Format(GlobalMessages.NotEnoughEnergy, this.Unit.Name, spell.GetType().Name));
            }

            useFireBreathSkill = !useFireBreathSkill;
            this.Unit.EnergyPoints -= spell.EnergyCost;
            return spell;
        }
    }
}
