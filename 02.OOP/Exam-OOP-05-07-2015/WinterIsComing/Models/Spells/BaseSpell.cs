using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.Spells
{
    public abstract class BaseSpell : ISpell
    {
        private int damage;
        private int energyCost;

        public BaseSpell(int damage, int energyCost)
        {
            this.Damage = damage;
            this.EnergyCost = energyCost;
        }

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value <0)
                {
                    throw new ArgumentException("Damage can not be negative!");
                }
                this.damage = value;
            }
        }

        public int EnergyCost 
        {
            get { return this.energyCost; }
            set
            {
                if (value <0)
                {
                    throw new ArgumentException("Energy cost can not be negative!");
                }
                this.energyCost = value;
            }
        }
    }
}
