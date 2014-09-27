using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    public class Call
    {
        private DateTime currentCall;
        private string dialedPhoneNumber;
        private ulong duration;

        public Call(DateTime call, string dialedPhone, ulong callDuration)
        {
            this.currentCall = call;
            this.dialedPhoneNumber = dialedPhone;
            this.duration = callDuration;
        }

        public DateTime CurrentCall
        {
            get
            {
                return this.currentCall;
            }
            set
            {
                this.currentCall = value;
            }
        }
        public string DialedNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            set
            {
                this.dialedPhoneNumber = value;
            }
        }
        public ulong CallDuration
        {
            get
            {
                return this.duration;
            }
            set
            {
                
                this.duration = value;
            }
        }

        public override string ToString()
        {
            var callText = new StringBuilder();

            callText.Append("Time of the call: " + this.currentCall + "\n");
            callText.Append("Dialed Number: " + this.dialedPhoneNumber + "\n");
            callText.Append("Call duration: " + this.duration + "\n");

            return callText.ToString();
        }
    }
}
