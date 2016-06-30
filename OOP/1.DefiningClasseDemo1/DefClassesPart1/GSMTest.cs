using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefClassesPart1
{
    public class GSMTest
    {
        public static void Test()
        {
            var phones = new GSM[]
            {
                new GSM("HTC One M8", "HTC", 900, "Stefy", new Battery("HTC", BatteryType.LiIon), new Display(7.2, 16000)),
                GSM.Iphone
            };

            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
            }
        }
    }
}
