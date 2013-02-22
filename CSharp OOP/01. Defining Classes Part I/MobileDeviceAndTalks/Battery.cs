using System;

namespace MobileDeviceAndTalks
{
    public class Battery
    {
        // FIELDS --------------------------------------------------------
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType batteryType;

        // CONSTRUCTORS ------------------------------------------------
        public Battery() : this(null)
        {
        }

        public Battery(string model) : this(model, null)
        {
        }

        public Battery(string model, double? hoursIdle)
            : this(model, hoursIdle, null)
        {
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk) : this (model, hoursIdle, hoursTalk, BatteryType.Lilon)
        {
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        // PROPERTIES ----------------------------------------------
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value != string.Empty && value.Length >= 2)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentNullException("The model can't be empty");
                }
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value > 1)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException("The number must be bigger than 1!");
                }
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value > 1)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException("The number must be bigger than 1!");
                }
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
                this.batteryType = value;
            }
        }

        // METHODS -----------------------------------------------------------------------
        public override string ToString()
        {
            return string.Format("---Battery---\r\nModel: {0}\r\nHoursIdle: {1}" +
                                "\r\nHoursTalk: {2}\r\n", this.model,
                                this.hoursIdle, this.hoursTalk);
        }
    }
}
