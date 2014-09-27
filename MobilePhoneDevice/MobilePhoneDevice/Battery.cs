using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    public class Battery
    {
        string model;
        double hoursIdle;
        double hoursTalk;
        BatteryType batteryType;

        public Battery()
        {

        }
        public Battery(string batteryModel, double idle, double talk, BatteryType type)
        {
            this.model = batteryModel;
            this.hoursIdle = idle;
            this.hoursTalk = talk;
            this.batteryType = type;
            
        }

        public override string ToString()
        {
            var batteryToString = new StringBuilder();

            if (this.model == null)
            {
                batteryToString.Append("Model: " + "\n");
            }
            else
            {
                batteryToString.Append("Model: " + this.model + "\n");
            }
                        
            batteryToString.Append("Hours Idle: " + this.hoursIdle + "\n");
            batteryToString.Append("Hours Talk: " + this.hoursTalk + "\n");

            if (this.batteryType == 0)
            {
                batteryToString.Append("Battery Type: " + "\n");
            }
            else
            {
                batteryToString.Append("Battery Type: " + this.batteryType + "\n");
            }
            

            return batteryToString.ToString();

        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The battery model can't be = null");
                }
                this.model = value;
            }
        }
        public double Idle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The battery idle can't be negative number!");
                }
                this.hoursIdle = value;
            }
        }
        public double Talk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The battery talk hours can't be negative number!");
                }
                this.hoursTalk = value;
            }
        }
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                batteryType = value;
            }
        }
        
    }
}
