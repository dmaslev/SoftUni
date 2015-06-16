using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GalacticGPS
{
    struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;


        public Location(double latitude, double longtitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longtitude = longtitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentException("Valid value for latitute: [-90, 90]");
                }
                this.latitude = value;
            }
        }

        public double Longtitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentException("Valid value for longtitude: [-180, 180]");
                }
                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            string location = string.Format("{0}, {1} - {2}", this.Latitude, this.Longtitude, this.Planet);
            return location;
        }

    }
}
