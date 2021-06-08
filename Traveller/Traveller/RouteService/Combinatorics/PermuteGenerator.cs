using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.RouteService
{
    public class PermuteGenerator : IGenerator

    {/// <summary>
     /// https://stackoverrun.com/es/q/9184187
     /// </summary>
     /// <param name="set"></param>
     /// <returns></returns>
        public static List<char[]> Generate(List<char> set)
        {
            List<char[]> result = new List<char[]>();

            Action<int> permute = null;
            permute = start =>
            {
                if (start == set.Count)
                {
                    
                    result.Add(set.ToArray());
                }
                else
                {
                    List<int> swaps = new List<int>();
                    for (int i = start; i < set.Count; i++)
                    {
                        if (swaps.Contains(set[i])) continue; // skip if we already done swap with this item
                        swaps.Add(set[i]);

                        Swap(set, start, i);
                        permute(start + 1);
                        Swap(set, start, i);
                    }
                }
            };

            permute(0);

            return result;
        }

        private static void Swap(List<char> set, int index1, int index2)
        {
            char temp = set[index1];
            set[index1] = set[index2];
            set[index2] = temp;
        }

    }
}
