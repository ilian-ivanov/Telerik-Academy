using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ExtensionIEnumerable
{
    public static class ExtensionsIEnumerable
    {
        public static T MinValue<T>(this IEnumerable<T> enumeration)
            where T : IComparable, IComparable<T>
        {
            T min = enumeration.First();
            foreach (var item in enumeration.Skip(1))
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T MaxValue<T>(this IEnumerable<T> enumeration)
            where T : IComparable, IComparable<T>
        {
            T max = enumeration.First();
            foreach (var item in enumeration.Skip(1))
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T SumValue<T>(this IEnumerable<T> enumeration)
        {
            dynamic sum = enumeration.First();
            foreach (var item in enumeration.Skip(1))
            {
                sum += item;
            }
            return (T)sum;
        }

        public static decimal ProductValue<T>(this IEnumerable<T> enumeration)
            where T : struct, IFormattable, IComparable, IConvertible
        {
            dynamic product = enumeration.First();
            foreach (var item in enumeration.Skip(1))
            {
                product *= item;
            }
            return (decimal)product;
        }

        public static decimal AverageValue<T>(this IEnumerable<T> enumeration)
            where T : struct, IFormattable, IComparable, IConvertible
        {
            dynamic sum = enumeration.First();
            long count = 1;
            foreach (var item in enumeration.Skip(1))
            {
                count++;
                sum += item;
            }
            return (decimal)(sum / count);
        }
    }
}
