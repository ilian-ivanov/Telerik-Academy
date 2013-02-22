using System;

namespace MobileDeviceAndTalks
{
    public class Display
    {
        // FIELDS ---------------------------------------------------
        private double? size;
        private string numberColors;

        // CONSTRUCTORS ----------------------------------------------
        public Display() : this(null, null)
        {
        }

        public Display(double? size)
            : this(size, null)
        {
        }

        public Display(double? size, string numberColors)
        {
            this.Size = size;
            this.NumberColors = numberColors;
        }

        // PROPERTIES -----------------------------------------------
        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value >= 2)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException("The size must be bigger or equal to 2!");
                }
            }
        }

        public string NumberColors
        {
            get
            {
                return this.numberColors;
            }
            set
            {
                if (value != string.Empty && value.Length >= 2)
                {
                    this.numberColors = value; 
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        // METHODS -----------------------------------------------------------------------
        public override string ToString()
        {
            return string.Format("---Display---\r\nSize: {0}\r\nNumber of colors: {1}\r\n", this.size, this.numberColors);
        }
    }
}
