using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDeviceAndTalks
{
    public class GSM
    {
        // FIELDS -------------------------------------------------------------------------
        private readonly string model;
        private readonly string manufacturer;
        private double? price;
        private string owner;
        
        public Battery Battery; 
        public Display Display;

        private List<Call> callHistory = new List<Call>();

        // STATIC FIELD -------------------------------------------------------------------
        private static readonly GSM iPhone4S = new GSM("Iphone", "Apple", 1099, "[No owner]"); 

        // CONSTRUCTORS ---------------------------------------------------------------------
        public GSM(string model, string manufacturer) : this(model, manufacturer, null)
        {
        }

        public GSM(string model, string manufacturer, double? price)
            : this(model, manufacturer, price, null)
        {
        }

        public GSM(string model, string manufacturer, double? price, string owner) : this(model, manufacturer,price, owner, null)
        {
        }

        public GSM(string model, string manufacturer, double? price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, null)
        {
        }

        public GSM(string model, string manufacturer, double? price, string owner, Battery battery, Display display)
        {
            if (model != string.Empty)
            {
                this.model = model;
            }
            else
            {
                throw new ArgumentException("The model can't be empty");
            }

            if (manufacturer != string.Empty)
            {
                this.manufacturer = manufacturer;
            }
            else
            {
                throw new ArgumentException("The manufactorer can't be empty");
            }

            this.price = price;
            this.owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        // PROPERTIES -------------------------------------------------------------------
        public string Model
        {
            get
            { 
                return this.model; 
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
        }

        public double? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("The price can't be negative!");
                }
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
                if (value != string.Empty && value.Length >= 2)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentNullException("The owner can't be empty!");
                }
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }


        // METHODS -----------------------------------------------------------------------
        public override string ToString()
        {
            return string.Format("---GSM---\r\nModel: {0}\r\nManufacturer: {1}\r\n" +
                                "Price: {2}\r\nOwner: {3}\r\n" , this.model,
                                this.manufacturer, this.price, this.owner );
        }

        public void AddNewCall(string dialedNumber, uint duration)
        {
            Call addNewCall = new Call(dialedNumber, duration);
            this.callHistory.Add(addNewCall);
        }

        public void DeleteCall(int index)
        {
            if (index < this.callHistory.Count && index > -1)
            {
                this.callHistory.RemoveAt(index);
            }
            else
            {
                throw new ArgumentException("The talk can't be negative or out of bounds!");
            }
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public double CalculatesPrice(double price)
        {
            uint minutes = 0;
            uint reminder = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                minutes += callHistory[i].Duration / 60;
                reminder = callHistory[i].Duration % 60;
                
                if (reminder != 0)
                {
                    minutes++;
                }
            }

            return minutes * price;
        }
    }
}
