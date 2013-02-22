using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDeviceAndTalks
{
    public class Call
    {
        // FIELDS ----------------------------------------------------------------
        private readonly DateTime date;
        private readonly string time;
        private readonly string dialedNumber;
        private readonly uint duration;

        // CONSTRUCTORS
        public Call(string dialedNumber, uint duration)
        {
            DateTime date = DateTime.Now;
            string time = date.Hour + ":" + date.Minute + ":" + date.Second;
            
            this.date = date;
            this.time = time;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

        // PROPERTIES
        public uint Duration
        {
            get
            {
                return this.duration;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
        }
        
        // METHODS
        public override string ToString()
        {
            return string.Format("--- Call ---\r\nDate: {0:dd.MM.yyyy}\r\nTime: {1}\r\n" +
                                "Dialed Number: {2}\r\nDuration: {3} sec\r\n", this.date,
                                this.time, this.dialedNumber, this.duration);
        }
    }
}
