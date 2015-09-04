using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;

namespace WinterIsComing
{
    class UnitEffector : IUnitEffector
    {
        private const int defaultToggleEffectValue = 50;

        public void ApplyEffect(IEnumerable<IUnit> units)
        {
            foreach (var unit in units)
            {
                unit.HealthPoints += defaultToggleEffectValue;
            }
        }
    }
}
