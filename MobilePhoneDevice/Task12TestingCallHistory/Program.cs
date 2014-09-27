using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneDevice;

namespace Task12TestingCallHistory
{
    public class GSMCallHistoryTest
    {
        public static void Main()
        {
            GSM testGSM = new GSM("3310", "Nokia");
            

            DateTime firstDate = new DateTime(2014, 02, 02, 9, 33, 00);
            DateTime secondDate = new DateTime(2014, 2, 2, 9, 40, 0);
            DateTime thirdDate = new DateTime(2014, 2, 2, 10, 33, 0);
            DateTime fourthDate = new DateTime(2014, 2, 2, 12, 33, 0);

            Call firstCall = new Call(firstDate, "0888-320-100", 59u);
            Call secondCall = new Call(secondDate, "0888-310-100", 320u);
            Call thirdCall = new Call(thirdDate, "0888-320-100", 1000u);
            Call fourthCall = new Call(fourthDate, "0888-320-100", 509u);

            Console.WriteLine(firstCall.ToString());

            testGSM.AddCallInHistory(firstCall);
            testGSM.AddCallInHistory(secondCall);
            testGSM.AddCallInHistory(thirdCall);
            testGSM.AddCallInHistory(fourthCall);

            decimal price = testGSM.CallPrice(testGSM.CallHistory);

            Console.WriteLine("The price of the calls is: {0}", price);

            Call longestCall = new Call(firstDate, null, 0u);
            foreach (var call in testGSM.CallHistory)
            {
                if (longestCall.CallDuration < call.CallDuration)
                {
                    longestCall = call;
                }
            }

            testGSM.DeleteCallInHistory(longestCall);

            decimal finalPrice = testGSM.CallPrice(testGSM.CallHistory);

            Console.WriteLine("The price of the calls with removed longest call is: {0}", finalPrice);
        }



    }
}
