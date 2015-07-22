using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Spells
{
    class Cleave: BaseSpell
    {
        private const int defaultCleaveEnergyCost = 15;

        public Cleave(int damage)
            : base(damage, defaultCleaveEnergyCost)
        {

        }
    }
}
