using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Spells
{
    class Stomp : BaseSpell
    {
        private const int defaultFireBreathEnergyCost = 10;

        public Stomp(int damage)
            : base(damage, defaultFireBreathEnergyCost)
        {

        }
    }
}
