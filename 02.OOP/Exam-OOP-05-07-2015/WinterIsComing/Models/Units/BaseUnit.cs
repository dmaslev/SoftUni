using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.Units
{

    public abstract class BaseUnit : IUnit
    {
        private UnitType type;
        private string name;
        private int x;
        private int y;
        private int range;
        private int atackPoints;
        private int healthPoints;
        private int defensePoints;

        public BaseUnit(UnitType type, string name, int x, int y, int atackPoints, int healthPoints, int defense, int energy, int range)
        {
            this.Range = range;
            this.Name = name;
            this.AttackPoints = atackPoints;
            this.HealthPoints = healthPoints;
            this.DefensePoints = defense;
            this.EnergyPoints = energy;
            this.X = x;
            this.Y = y;
            this.Type = type;
        }
        public UnitType Type { get; set; }

        public int X { get; set;}

        public int Y { get; set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public int Range
        {
            get { return this.range; }
            set
            {
                if (value <0)
                {
                    throw new ArgumentException("Range cannot be negative!");
                }
                this.range = value;
            }
        }

        public int AttackPoints
        {
            get { return this.atackPoints; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Atack cannot be negative!");
                }
                this.atackPoints = value;
            }
        }

        public int HealthPoints { get; set; }

        public int DefensePoints
        {
            get { return this.defensePoints; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Health points cannot be negative!");
                }
                this.defensePoints = value;
            }
        }

        public int EnergyPoints { get;  set; }

        public ICombatHandler CombatHandler { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
           
            if (this.HealthPoints > 0)
            {
                sb.AppendLine(string.Format("-Health points = {0}", this.HealthPoints));
                sb.AppendLine(string.Format("-Attack points = {0}", this.AttackPoints));
                sb.AppendLine(string.Format("-Defense points = {0}", this.DefensePoints));
                sb.AppendLine(string.Format("-Energy points = {0}", this.EnergyPoints));
                sb.Append(string.Format("-Range = {0}", this.Range));

                return sb.ToString();
            }

            sb.Append("(Dead)");
            return sb.ToString();
        }
    }
}
