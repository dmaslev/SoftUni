using MassEffect.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Projectiles
{
    class ShieldReaver : Projectile
    {
        public ShieldReaver(int damage)
            : base (damage)
        {

        }

        public override void Hit(IStarship target)
        {
            target.Health -= this.Damage;
            target.Shields -= 2 * this.Damage;
        }
    }
}
