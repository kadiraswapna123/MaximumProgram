using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblem
{
    internal class IntegersMax
    {
        var side = new double[] { 5, 3, 4 };

        T[] GetMax<T>(int number, List<T> source, T minVal)
        {
            T[] results = new T[number];

            for (int i = 0; i < number; i++)
            {
                results[i] = minVal;
            }

            var curMin = minVal;

            foreach (var e in source)
            {
                int resComp = Comparer.DefaultInvariant.Compare(curMin, e);

                if (resComp < 0)
                {
                    int minIndex = Array.IndexOf(results, curMin);
                    results[minIndex] = e;
                    curMin = results.Min();
                }
            }

            return results;
        }

        var source = new int[] { 5, 5, 1, 2, 4, 3 }.ToList();
        var result = GetMax(3, source, int.MinValue);

    }
}
