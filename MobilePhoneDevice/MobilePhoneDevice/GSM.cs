using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    public class GSM
    {
        private string model; 
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iPhone = new GSM("IPhone4S", "Apple");
        private List<Call> callHistory = new List<Call>();

        public GSM(string modelName, string manufacturerName)
        {
            this.model = modelName;
            this.manufacturer = manufacturerName;
            
        }
        public GSM(string modelName, string manufacturerName, decimal priceValue, string ownerName,
            Battery newBattery, Display newDisplay) : this(modelName,manufacturerName)
        {
            
            this.price = priceValue;
            this.owner = ownerName;
            this.battery = newBattery;
            this.display = newDisplay;
            
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            info.Append(new string('-', 10) + "\n");
            info.Append("GSM" + "\n");
            info.Append(new string('-', 10) + "\n");
            info.Append("Model: " + this.model + "\n");
            info.Append("Manufactorer: " + this.manufacturer + "\n");
            info.Append("Price: " + this.price + "\n");
            info.Append("Owner: " + this.owner + "\n");
            info.Append("\n");
            info.Append(new string('-', 10) + "\n");
            info.Append("Battery\n");
            info.Append(new string('-', 10) + "\n");
            if (battery == null)
            {
                info.Append("Info is missing\n");
            }
            else
            {
                info.Append(battery.ToString());
            }

            info.Append("\n");
            info.Append(new string('-', 10) + "\n");
            info.Append("Display\n");
            info.Append(new string('-', 10) + "\n");
            if (display == null)
            {
                info.Append("Info is missing\n");
            }
            else
            {
                info.Append(display.ToString());
            }
            

            return info.ToString();
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
                    throw new ArgumentException("The model can't have value = null!");
                }
                this.model = value;
            }
        }
        public string Manufactorer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The manufacturer can't have value = null!");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price can't be negative number!");
                }
                this.price = value;
            }
        }

        public string Owner 
        { 
            get
            {
                return this.owner;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The owener name can't be = null");
                }
                owner = value;
            }
        }

        

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
        }
        public Display Display 
        { 
            get
            {
                return this.display;
            }
        }
       
        public static GSM IPhone
        {
            get
            {
                return iPhone;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        public void AddCallInHistory(Call newCall)
        {
            this.callHistory.Add(newCall);
        }
        public void DeleteCallInHistory(Call callName)
        {
            this.callHistory.Remove(callName);
        }
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CallPrice(List<Call> history)
        {
            decimal price = 0m;
            foreach (var call in history)
            {
                price += (decimal)(call.CallDuration / 60 + 1);
            }

            price *= 0.37m;
            return price;
        }
    }
}
