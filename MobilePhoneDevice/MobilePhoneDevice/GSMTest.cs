namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MobilePhoneDevice;

    public class GSMTest
    {
        static void Main()
        {
            Battery nokia = new Battery("Nokia", 0, 0, BatteryType.Not_Set);
            Battery samsung = new Battery("Samsung", 19.5, 12.3, BatteryType.NiMH);
            Battery shanoBat = new Battery();

            Display firstDisplay = new Display(7.5, "244k");
            Display secondDisplay = new Display(8.1, null);
            Display shanoDis = new Display();

            
            GSM firstGSM = new GSM("3310", "Nokia", 20m, "Ivancho", nokia, null);
            firstGSM.Owner = "Facka";

            GSM secondGSM = new GSM("Galaxy", "Samsung", 1200m, "Dimitrii Ruskov", samsung, firstDisplay);
            GSM thirdGSM = new GSM(null, null, 0m, "Kichka Glupavata", shanoBat, shanoDis);


            Console.WriteLine("FIRST GSM");
            Console.WriteLine(firstGSM.ToString());
            Console.WriteLine();
            Console.WriteLine("SECOND GSM");
            Console.WriteLine(secondGSM.ToString());
            Console.WriteLine();
            Console.WriteLine("THIRD GSM");
            Console.WriteLine(thirdGSM.ToString());
            Console.WriteLine();
            Console.WriteLine("IPHONE");
            Console.WriteLine(GSM.IPhone.ToString());

            
            
        }
    }

    
}
