using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Ships
{
    class Frigate : Starship
    {
        private int projectilesFired;

        public Frigate(string name, StarSystem location) :
            base ( name, 60, 50, 30, 220, location)
        {

        }

        

        public override string ToString()
        {
            string result =  base.ToString();
            if (this.Health > 0)
            {
                result += string.Format("\n-Projectiles fired: {0}", this.projectilesFired);
            }
            return result;
        }
        public  override IProjectile ProduceAttack()
        {
            this.projectilesFired++;
            return new ShieldReaver(this.Damage);
        }
    }
}
