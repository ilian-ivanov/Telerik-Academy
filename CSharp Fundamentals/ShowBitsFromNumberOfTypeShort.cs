
//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ShowBitsFromNumberOfTypeShort
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        short mask = 1;
        short sign = 0;
        string binaryRepresentation = "";

        // check for the sign
        sign = (short)((number >> 15) & mask);

        // just in case make the bit which show the sign to be 0 in that way the number will be positive with sure 
        number = (short)(number & (~(mask << 15)));

        // take every bit from the number
        while (number != 0)
        {
            binaryRepresentation = (number % 2) + binaryRepresentation;
            number /= 2;
        }

        while (binaryRepresentation.Length < 15)
        {
            binaryRepresentation = "0" + binaryRepresentation;
        }

        // here we add the sign if it is "-" it will be added 1, in other case will be added 0
        binaryRepresentation = sign + binaryRepresentation;
        Console.WriteLine(binaryRepresentation);
    }
}
