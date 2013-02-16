
//* Write a program that shows the internal binary representation of given 32-bit signed 
//floating-point number in IEEE 754 format (the C# type float). Example: -27,25  sign = 1, 
//exponent = 10000011, mantissa = 10110100000000000000000.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IEEE754Format9
{
    static void Main()
    {
        float number = float.Parse(Console.ReadLine());
        long convertBitsOfNumber = BitConverter.DoubleToInt64Bits(number);
        long mask = 1;
        long sign = 0;
        string binaryRepresentation = "";
        string exponent;
        string mantisa;

        // check for the sign
        sign = ((convertBitsOfNumber >> 63) & mask);

        // just in case make the bit which show the sign to be 0 in that way the number will be positive with sure 
        convertBitsOfNumber = (convertBitsOfNumber & (~(mask << 63)));

        // take every bit from the number
        while (convertBitsOfNumber != 0)
        {
            binaryRepresentation = (convertBitsOfNumber % 2) + binaryRepresentation;
            convertBitsOfNumber /= 2;
        }

        if (number > -2.0f && number < 2.0f)
        {
            exponent = "0";

            exponent += binaryRepresentation.Substring(3, 7);

            mantisa = binaryRepresentation.Substring(10, 23);
        }
        else
        {
            exponent = binaryRepresentation.Substring(0, 1);

            // here we take from this position because we used 64 bits number and this 3 digits are no necessary for 32 bits number
            exponent += binaryRepresentation.Substring(4, 7);

            mantisa = binaryRepresentation.Substring(11, 23);
        }

        Console.Write(sign + " ");
        Console.Write(exponent + " ");
        Console.WriteLine(mantisa);
    }
}
