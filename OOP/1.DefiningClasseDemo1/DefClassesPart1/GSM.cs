using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefClassesPart1
{
    public class GSM
    {
        //fields
        private static GSM iPhone4S = new GSM("iPhone 4S", "Apple", 1200, "Slavea", new Battery("Apple", BatteryType.NiMH), new Display(5.2, 16000));
        
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery = new Battery();
        private Display display = new Display();

        //properties
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public decimal Pice
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        //call property
        public List<Call> CallHistory { get; set; }
        
        //static property
        public static GSM Iphone
        {
            get { return iPhone4S; }            
        }

        //constructors
        public GSM(string model, string manufacturer, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.battery = battery;
            this.display = display;  
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public override string ToString()
        {
            string fullInfo = string.Format(
                "Model: {0} \nManufacturer: {1} \nPrice: {2} BGN \nOwner: {3} \nBattery Information: {4} \nDisplay Information: {5}\n",
                this.model,
                this.manufacturer,
                this.price,
                this.owner,
                this.battery,
                this.display);

            return fullInfo;
        }

        //Display CallHistory
        public void DisplayCallHitory()
        {
            if (CallHistory.Count == 0)
            {
                Console.WriteLine("Call History is empty!");
            }
            else
            {
                for (int i = 0; i < CallHistory.Count; i++)
                {
                    var call = CallHistory[i];
                    Console.WriteLine($"Date: {call.DateTime.Year}/{call.DateTime.Month}/{call.DateTime.Day} Time: {call.DateTime.Hour}:{call.DateTime.Minute}:{call.DateTime.Second} Number: {call.DialedNumber} Duration: {call.Duration}");
                }
            }
        }

        //CallHistory Methods
        public void AddCall(Call call)
        {
            if (this.CallHistory == null)
            {
                this.CallHistory = new List<Call>();
            }
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call callToDelete)
        {
            if (!this.CallHistory.Contains(callToDelete))
            {
                return;
            }
            else
            {
                this.CallHistory.Remove(callToDelete);
            }
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public void CallPrice(decimal pricePerMinute)
        {
            var sumInSeconds = this.CallHistory.Sum(x => x.Duration);
            var sumInMinutes = sumInSeconds / 60.0;
            var result = (decimal)sumInMinutes * pricePerMinute;
            Console.WriteLine("{0:F2} BGN", result);
        }
    }
}
