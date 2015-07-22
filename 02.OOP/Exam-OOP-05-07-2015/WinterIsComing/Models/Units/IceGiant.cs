using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    class IceGiant : BaseUnit
    {
        private const int defaultAtackPoints = 150;
        private const int defaultHealthPoints = 300;
        private const int defaultDefencePoints = 60;
        private const int defaultEnergyPoints = 50;
        private const int defaultRange = 1;


        public IceGiant(UnitType type, string name, int x, int y)
            : base (type, name, x, y, defaultAtackPoints, defaultHealthPoints, defaultDefencePoints, defaultEnergyPoints , defaultRange)
        {
            this.CombatHandler = new IceGiantCombatHandler(this);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine( string.Format(">{0} - {1} at ({2},{3})", this.Name, this.Type, this.X, this.Y));
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
}
