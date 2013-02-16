
//Extend the program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubtractionMultiplication12
{
    static List<int> firstPolynom = new List<int> { 2, 3, 4, 8 };    // this is (8x^3 + 4x^2 + 3x + 2)
    static List<int> secondPolynom = new List<int> { 1, 0, -5 };  // (-5x^2 + 0x + 1)
    static List<int> newPolynom = new List<int>();

    private static List<int> AddsTwoPolynomials(List<int> firstPolynom, List<int> secondPolynom)
    {
        int maxLength = Math.Max(firstPolynom.Count, secondPolynom.Count);
        int minLength = Math.Min(firstPolynom.Count, secondPolynom.Count);

        // sum numbers of polynoms until the shorter ended
        for (int i = 0; i < minLength; i++)
        {
            newPolynom.Add(firstPolynom[i] + secondPolynom[i]);
        }

        // here check which of polynoms is bigger and copy the numbers that are stay from bigger one
        if (firstPolynom.Count > secondPolynom.Count)
        {
            for (int i = minLength; i < maxLength; i++)
            {
                newPolynom.Add(firstPolynom[i]);
            }
        }

        if (firstPolynom.Count < secondPolynom.Count)
        {
            for (int i = minLength; i < maxLength; i++)
            {
                newPolynom.Add(secondPolynom[i]);
            }
        }

        return newPolynom;
    }


    private static void SubtractionTwoPolynoms()
    {
        int maxLength = Math.Max(firstPolynom.Count, secondPolynom.Count);
        int minLength = Math.Min(firstPolynom.Count, secondPolynom.Count);

        // suntracts numbers of polynoms until the shorter ended
        for (int i = 0; i < minLength; i++)
        {
            newPolynom.Add(firstPolynom[i] - secondPolynom[i]);
        }

        // here check which of polynoms is bigger and copy the numbers that are stay from bigger one
        if (firstPolynom.Count > secondPolynom.Count)
        {
            for (int i = minLength; i < maxLength; i++)
            {
                newPolynom.Add(firstPolynom[i]);
            }
        }

        if (firstPolynom.Count < secondPolynom.Count)
        {
            for (int i = minLength; i < maxLength; i++)
            {
                newPolynom.Add(secondPolynom[i]);
            }
        }
    }


    private static void MultiplicationTwoPolynoms()
    {
        List<List<int>> polynomSums = new List<List<int>>();
        int count = 0;

        // here we multiply polynoms. Example (x + 2) * (x + 3) = (3x + 6) + (x^2 + 2x + 0)
        // we add 0 to be easy after that to sum each other
        for (int i = 0; i < secondPolynom.Count; i++)
        {
            count++;
            polynomSums.Add(new List<int>());
            for (int k = 0; k < firstPolynom.Count; k++)                                                                                                                                                 
            {
                polynomSums[i].Add(firstPolynom[k] * secondPolynom[i]);
                if (k == firstPolynom.Count - 1)
                {
                    for (int p = 1; p < count; p++)
                    {
                        polynomSums[i].Insert(0, 0);
                    }
                }
            }
            // prints all steps for easier to understand -> uncomment next row (all comment console.writeline rows are for help to understand)
            //Console.WriteLine(string.Join(",  ", polynomSums[i]).PadRight(60));  
        }
        //Console.WriteLine("".PadLeft(60, '-'));

        // here added zeros, in that way we'll easy make sums after that
        int lastIndex = polynomSums.Count - 1;
        for (int k = 0; k < polynomSums.Count - 1; k++)
        {
            for (int i = polynomSums[k].Count - 1; i < (polynomSums[lastIndex].Count - 1); i++)
            {
                polynomSums[k].Add(0);
            }
        }

        // makes sums in order every member that is for example x^2 is sum with all other x^2
        for (int i = 0; i < polynomSums[0].Count; i++)
        {
            newPolynom.Add(0);

            for (int k = 0; k < polynomSums.Count; k++)
            {
                newPolynom[i] += (polynomSums[k][i]);
            }
        }

        // prints sum of rows for help in addition to previous help row
        //Console.WriteLine(string.Join(",  ", newPolynom).PadRight(60));
    }

    static void Main()
    {
        Console.WriteLine("Choose action you want to do.");
        Console.WriteLine("1 for adds");
        Console.WriteLine("2 for substraction");
        Console.WriteLine("3 for multiplication");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: newPolynom = AddsTwoPolynomials(firstPolynom, secondPolynom); break;
            case 2: SubtractionTwoPolynoms(); break;
            case 3: MultiplicationTwoPolynoms(); break;
        }

        firstPolynom.Reverse();
        secondPolynom.Reverse();
        newPolynom.Reverse();
        Console.WriteLine();
        Console.WriteLine("here prints the two polynoms which type is (x^n + ... + x^2 + x + 1)");
        Console.WriteLine(string.Join("   ", firstPolynom).PadLeft(60));
        Console.WriteLine(string.Join("   ", secondPolynom).PadLeft(60));
        Console.WriteLine("".PadLeft(60, '-'));
        Console.WriteLine(string.Join("   ", newPolynom).PadLeft(60));
    }
}
