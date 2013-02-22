using System;
using System.Collections.Generic;

namespace MobileDeviceAndTalks
{
    public class GSMTestAndCallTest
    {
        static void Main()
        {
            GSM[] mobilePhone = new GSM[3]; 
            Battery mobileBattery = new Battery("motorola", 72, 6, BatteryType.Lilon);
            Display mobileDisplay = new Display(8.7, "16M");

            for (int i = 0; i < mobilePhone.Length; i++)
            {
                mobilePhone[i] = new GSM("nokia", "apple", 890, "Pesho", mobileBattery, mobileDisplay); 
            }

            // throw exception
            // mobilePhone[0].Owner = "";

            mobilePhone[0].Owner = "Ivan";
            mobilePhone[0].Battery.BatteryType = BatteryType.NiCd;
            mobilePhone[0].Display.NumberColors = "32M";

            mobilePhone[1].Price = 690.9;
            mobilePhone[1].Display.Size = 7;
            mobilePhone[1].Battery.HoursTalk = 12.5;

            // don't change mobilePhone[2]

            Console.WriteLine(new string('-', 20) + " GSM Test " + new string('-', 20));

            // print all mobile phones
            for (int i = 0; i < mobilePhone.Length; i++)
            {
                Console.WriteLine("Mobile Phohe number: {0}\r\n" + mobilePhone[i] + "\r\n" +
                    mobilePhone[i].Battery + "\r\n" + mobilePhone[i].Display, i);
                Console.WriteLine();
                // change color to be easy to see differences
                Console.ForegroundColor = ConsoleColor.Green + i;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(GSM.IPhone4S);


 //---------------------------GSM Test Calls--------------------------------------------------------------------
            Console.WriteLine(new string ('-', 20) + " Test GSM Calls " + new string('-',20));
                    
            GSM myMobile = new GSM("Nokia", "China") ;
            double priceForMinute = 0.37;

            // added calls
            myMobile.AddNewCall("0888 789 789", 219);
            for (uint i = 1; i < 200; i += 71)
            {
                myMobile.AddNewCall("0888 789 123", i);
            }

            // takes history of calls
            List<Call> history = myMobile.CallHistory;

            
            // prints all calls
            for (int i = 0; i < history.Count ; i++)
            {
                Console.WriteLine(history[i]);
            }

            Console.WriteLine("The price is: {0}", myMobile.CalculatesPrice(priceForMinute));

            // remove the longest talk
            int max = 0;
            uint duration = 0;
            for (int i = 0; i < history.Count; i++)
            {
                if (history[i].Duration > duration)
                {
                    duration = history[i].Duration;
                    max = i;
                }
            }

            myMobile.DeleteCall(max);

            Console.WriteLine("The price is: {0}", myMobile.CalculatesPrice(priceForMinute));

            myMobile.ClearHistory();
            
            // prints all calls to show that history is empty
            for (int i = 0; i < history.Count; i++)
            {
                Console.WriteLine(history[i]);
            }
        }
    }
}
