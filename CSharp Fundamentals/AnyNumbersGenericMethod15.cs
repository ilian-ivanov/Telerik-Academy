
//* Modify your last program and try to make it work for any number type, not just integer 
//(e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AnyNumbersGenericMethod15
{
    static T Minimum<T>(T[] array)
    {
        dynamic min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        return (T)min;
    }

    static T Maximum<T>(T[] array)
    {
        dynamic max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return (T)max;
    }

    // make it with int because I think that is right way (not to add some double or float number)
    static T Average<T>(params T[] array)
    {
        dynamic sum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum /= array.Length;
        return (T)sum;
    }

    static T Sum<T>(T[] array)
    {
        dynamic sum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        return (T)sum;
    }

    static T Product<T>(T[] array)
    {
        dynamic prod = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            prod *= array[i];
        }
        return (T)prod;
    }

    static void Main()
    {
        //sbyte[] array = { 1, 2, 3, 4, 1, 23, 7, -4, 0, 4 };
        //short[] array = { 1, 2, 3, 4, 1, 23, 7, -4, 0, 4 };
        int[] array = { 1, 2, 3, 4, 1, 23, 7, -4, 0, 4 };
        //long[] array = { 1, 2, 3, 4, 1, 23, 7, -4, 0, 4 };
        //double[] array = { 1, 2, 3, 4, 1, 23, 7, -4, 0, 4 };
        //float[] array = { 1, 2, 3, 4, 1, 23, 7, -4, 0, 4 };
        //decimal[] array = { 1, 2, 3, 4, 1, 23, 7, -4, 0, 4 };

        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine("Minimum: " + Minimum(array));
        Console.WriteLine("Maximum: " + Maximum(array));
        Console.WriteLine("Average: " + Average(array));
        Console.WriteLine("Sum: " + Sum(array));
        Console.WriteLine("Product: " + Product(array));
    }
}

