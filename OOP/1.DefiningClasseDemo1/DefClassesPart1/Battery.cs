using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefClassesPart1
{
    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batType = new BatteryType();

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public Battery()
        {

        }

        public Battery(string model, BatteryType type)
        {
            this.model = model;
            this.batType = type;
        }

        public Battery(string model, BatteryType type, int idle, int talk)
        {
            this.model = model;
            this.batType = type;
            this.hoursIdle = idle;
            this.hoursTalk = talk;
        }

        public override string ToString()
        {
            string result = string.Format("Battery model is {0} of type {1}", this.model, this.batType);

            return result;
        }
    }
}
