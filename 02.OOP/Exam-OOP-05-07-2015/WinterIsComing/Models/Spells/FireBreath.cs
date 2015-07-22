﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Spells
{
    class FireBreath : BaseSpell
    {
        private const int defaultFireBreathEnergyCost = 30;

        public FireBreath(int damage)
            : base(damage, defaultFireBreathEnergyCost)
        {

        }
    }
}
