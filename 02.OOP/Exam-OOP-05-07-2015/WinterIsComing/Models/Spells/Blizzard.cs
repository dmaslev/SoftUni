using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Spells
{
    class Blizzard : BaseSpell
    {
        private const int defaultBlizzardEnergyCost = 40;

        public Blizzard(int damage)
            : base(damage, defaultBlizzardEnergyCost)
        {

        }
    }
}
