using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    public class Display
    {
        double size;
        string colors;

        public Display()
        {

        }
        public Display(double inchSize, string colorsType)
        {
            this.size = inchSize;
            this.colors = colorsType;
        }

        public override string ToString()
        {
            
            var displayToString = new StringBuilder();

            if (this.size == 0)
            {
                displayToString.Append("Size: " + "\n");
            }
            else
            {
                displayToString.Append("Size: " + this.size + "\n");
            }

            if (this.colors == null)
            {
                displayToString.Append("Colors: " + "\n");
            }
            else
            {
                displayToString.Append("Colors: " + this.colors + "\n");
            }
            

            return displayToString.ToString();
        }
    }
}
