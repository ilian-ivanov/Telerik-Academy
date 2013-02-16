using System;

class FallDown
{
    static void Main()
    {
        byte n0 = byte.Parse(Console.ReadLine());
        byte n1 = byte.Parse(Console.ReadLine());
        byte n2 = byte.Parse(Console.ReadLine());
        byte n3 = byte.Parse(Console.ReadLine());
        byte n4 = byte.Parse(Console.ReadLine());
        byte n5 = byte.Parse(Console.ReadLine());
        byte n6 = byte.Parse(Console.ReadLine());
        byte n7 = byte.Parse(Console.ReadLine());
        byte mask = 0;

        for (int i = 1; i <= 7; i++)
        {
            mask = n7;
            n7 |= n6;
            n6 &= mask;

            mask = n6;
            n6 |= n5;
            n5 &= mask;

            mask = n5;
            n5 |= n4;
            n4 &= mask;

            mask = n4;
            n4 |= n3;
            n3 &= mask;

            mask = n3;
            n3 |= n2;
            n2 &= mask;

            mask = n2;
            n2 |= n1;
            n1 &= mask;

            mask = n1;
            n1 |= n0;
            n0 &= mask;
        }

        Console.WriteLine(n0);
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(n5);
        Console.WriteLine(n6);
        Console.WriteLine(n7);
    }
}
