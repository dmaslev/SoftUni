using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Locations;
using MassEffect.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace MassEffect.GameObjects.Ships
{
    public abstract class Starship : IStarship
    {
        private IList<Enhancement> enhancements;


        protected Starship(string name, int health, int shields, int damage, double fuel, StarSystem location)
        {
            this.Name = name;
            this.Health = health;
            this.Shields = shields;
            this.Damage = damage;
            this.Fuel = fuel;
            this.Location = location;
            this.enhancements = new List<Enhancement>();

        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Shields { get; set; }
        public int Damage { get; set; }
        public double Fuel { get; set; }
        public StarSystem Location { get; set; }
        public IEnumerable<Enhancement> Enhancements
        {
            get
            {
                return this.enhancements;
            }
        }


        public abstract IProjectile ProduceAttack();
       
        public void AddEnhancement(Enhancement enhacement)
        {
            if (enhacement == null)
            {
                throw new ArgumentNullException("Enhancement cannot be null");
            }
            this.enhancements.Add(enhacement);
            if (enhacement.Name == "ThanixCannon")
            {
                this.Damage += 50;
            }
            else if (enhacement.Name == "KineticBarrier")
            {
                this.Shields += 100;
            }
            else if(enhacement.Name == "ExtendedFuelCells")
            {
                this.Fuel += 200;
            }


        }
        public virtual void RespondToAttack(IProjectile projectile)
        {
            projectile.Hit(this);
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("--{0} - {1}", this.Name, this.GetType().Name));
            if (this.Health <=0)
            {
                output.Append("(Destroyed)");
            }
            else
            {
                output.AppendLine(string.Format("-Location: {0}", this.Location.Name));
                output.AppendLine(string.Format("-Health: {0}", this.Health));
                output.AppendLine(string.Format("-Shields: {0}", this.Shields));
                output.AppendLine(string.Format("-Damage: {0}", this.Damage));
                output.AppendLine(string.Format("-Fuel: {0:f1}", this.Fuel));
                if (this.enhancements.Count ==0)
                {
                    output.Append(string.Format("-Enhancements: {0}", "N/A"));
                }
                else
                {
                    output.Append(string.Format("-Enhancements: {0}", string.Join(", ", this.enhancements.Select(enhancements => enhancements.Name))));

                }
            }
            
            return output.ToString();

        }



    }
}
