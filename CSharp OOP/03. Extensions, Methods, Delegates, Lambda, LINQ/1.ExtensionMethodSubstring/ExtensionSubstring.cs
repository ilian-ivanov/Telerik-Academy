using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ExtensionMethodSubstring
{
    public static class ExtensionSubstring
    {
        public static string Substring(this StringBuilder strBuild, int index, int length)
        {
            string str = strBuild.ToString();
            return str.Substring(index, length);
        }
    }

    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(123456789);
            Console.WriteLine(sb);
            Console.WriteLine(sb.Substring(2, 3));
        }
    }
}
