using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    class WarriorCombatHandler : CombatHandler
    {
        public WarriorCombatHandler(IUnit unit)
            : base(unit)
        {

        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var targets = candidateTargets.OrderBy(c => c.HealthPoints).ThenBy(c => c.Name).Take(1);
            return targets;
        }

        public override ISpell GenerateAttack()
        {
            var spell = new Cleave(this.Unit.AttackPoints);
            if (this.Unit.HealthPoints <= 80)
            {
                spell.Damage += 2 * this.Unit.HealthPoints;
            }

            if (this.Unit.HealthPoints > 50)
            {
                this.Unit.EnergyPoints -= spell.EnergyCost;
            }
            return spell;
        }
    }
}
