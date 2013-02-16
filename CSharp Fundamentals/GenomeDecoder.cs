using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GenomeDecoder
{
    static void Main()
    {
        string[] nAndM = Console.ReadLine().Split(' ');
        int n = int.Parse(nAndM[0]);
        int m = int.Parse(nAndM[1]);

        string genomeSequence = Console.ReadLine();
        List<string> lines = new List<string>();
        List<string> digitsForLetters = new List<string>();
        List<int> digits = new List<int>();
        List<char> letters = new List<char>();
        StringBuilder temp = new StringBuilder();
        string temporary = "";
        int counterForSpace = 0;
        int counterForRow = 0;
        int row = 1;
        bool isGetPadding = true;
        
//-------------------------------------------------------------------------------------------------
        // splits string to two lists
        foreach (var symbol in genomeSequence)
        {
            if (char.IsDigit(symbol))
            {
                temp.Append(symbol);
            }
            else
            {
                if (Convert.ToString(temp) == "")
                {
                    temp.Append("1");
                }
                letters.Add(symbol);
                digitsForLetters.Add(Convert.ToString(temp));
                temp.Clear();
            }
        }
        temp.Clear();

//------------------------------------------------------------------------------------------------
        // calculates sum and fills list
        int sum = 0;
        for (int i = 0; i < digitsForLetters.Count; i++)
        {
            digits.Add(int.Parse(digitsForLetters[i]));
            sum += int.Parse(digitsForLetters[i]);
        }
        
//---------------------------------------------------------------------------------------------
        // calculates padding
        decimal decSum = sum;
        decSum = (decimal)sum / n;
        sum = (sum / n);
        if (decSum > sum)
        {
            sum++;
        }

        string rows = sum + "";

        int padding = 0;
//-------------------------------------------------------------------------------------------------

        // prints the result in wanted way
        for (int i = 0; i < letters.Count; i++)
        {           
            for (int p = 0; p < digits[i]; p++)
            {                  
                if (counterForRow % n == 0)
                {
                    if (counterForRow != 0)
                    {
                        if (isGetPadding)
                        {
                            padding = temporary.Length + rows.Length - 1;
                            isGetPadding = false;
                        }
                        Console.WriteLine(temporary.PadLeft(padding, ' '));
                    }

                    temporary = row + "";
                    row++;
                    counterForRow = 0;
                    counterForSpace = 0;
                }
                if (counterForSpace % m == 0)
                {
                    temporary += " ";
                }
                temporary += letters[i];
                counterForRow++;
                counterForSpace++;
            }
        }
        Console.WriteLine(temporary);
    }
}
