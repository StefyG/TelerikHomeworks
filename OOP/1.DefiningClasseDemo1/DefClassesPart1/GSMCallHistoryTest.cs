using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefClassesPart1
{
    public class GSMCallHistoryTest
    {
        static GSM gsm = new GSM("Samsung S7", "Samsung", new Battery("Samsung", BatteryType.LiIon), new Display(7.2, 16000));
        private const decimal pricePerMinute = 0.37m;

        public static void Func()
        {
            Call call1 = new Call(new DateTime(2016, 02, 15, 15, 43, 20), "0888 55 99 66", 143);
            Call call2 = new Call(new DateTime(2016, 05, 07, 11, 20, 43), "0888 48 21 74", 57);
            Call call3 = new Call(new DateTime(2016, 02, 15, 12, 43, 20), "0888 55 99 66", 230);
            Call call4 = new Call(new DateTime(2016, 03, 01, 09, 02, 57), "0888 87 20 61", 430);
            Call call5 = new Call(new DateTime(2016, 01, 15, 18, 30, 15), "0888 54 00 01", 389);
                        
            gsm.AddCall(call1);
            gsm.AddCall(call2);
            gsm.AddCall(call3);
            gsm.AddCall(call4);
            gsm.AddCall(call5);

            Console.WriteLine(gsm);
            gsm.DisplayCallHitory();
            gsm.CallPrice(pricePerMinute);

            var longestCall = gsm.CallHistory.OrderByDescending(x => x.Duration).ToList<Call>();
            gsm.DeleteCall(longestCall[0]);

            gsm.CallPrice(pricePerMinute);
            gsm.ClearCallHistory();
            gsm.DisplayCallHitory();
        }
    }
}
