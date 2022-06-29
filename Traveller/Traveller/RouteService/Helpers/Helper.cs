using System;
using System.Collections.Generic;
using System.Linq;
using Traveller.Domain;

namespace Traveller.RouteService.Helpers
{
    public static class Helper
    {

        public static string ConvertCodesToCountries(List<char> route)
        {

            string readable = "";
            foreach (char countryCode in route)
            {
                readable = readable + (CodeDictionary.GetCountryByCode(countryCode) + "-");
            }

            return readable;

        }

        // C# program to find Minimum Distance 
        // Between Words of a String


        // Function to calculate the minimum 
        // distance between w1 and w2 in s 
        public static int distance(string s, char w1, char w2)
        {

            if (w1.Equals(w2))
                return 0;

            // get individual words in a list 
            char[] words = s.ToCharArray();

            // assume total length of the string 
            // as minimum distance 
            int min_dist = (words.Length) + 1;

            // traverse through the entire string 
            for (int index = 0;
                index < words.Length; index++)
            {

                if (words[index].Equals(w1))
                {
                    for (int search = 0;
                        search < words.Length; search++)
                    {
                        if (words[search].Equals(w2))
                        {
                            // the distance between the words is 
                            // the index of the first word - the 
                            // current word index 
                            int curr = Math.Abs(index - search) - 1;

                            // comparing current distance with 
                            // the previously assumed distance 
                            if (curr < min_dist)
                            {
                                min_dist = curr;
                            }
                        }
                    }
                }
            }

            // w1 and w2 are same and adjacent 
            return min_dist;
        }

        public static List<List<char>> DeleteDuplicates(List<List<char>> routes)
        {
            try
            {
                List<string> JustChars = new List<string>();

                foreach (var route in routes)
                {

                    string s = string.Join("", route);
                    JustChars.Add(s);
                }


                List<string> noDupes = new List<string>(new HashSet<string>(JustChars));
                JustChars.Clear();
                JustChars.AddRange(noDupes);



                List<List<char>> toListAgain = new List<List<char>>();

                foreach (string route in JustChars)
                {
                    toListAgain.Add(route.ToCharArray().ToList());
                }

                //248
                int count = toListAgain.Count;

                return toListAgain;
            }

            catch
            {

                return routes;
            }
        }

        //public static bool HasConsecutiveChars(string source, int sequenceLength)
        //{
        //    if (string.IsNullOrEmpty(source))
        //    {
        //        return false;
        //    }

        //    if (source.Length == 1)
        //    {
        //        return false;
        //    }

        //    if ((sequenceLength == 2) && ((source[0] == source[source.Length - 1]))) return true; //TXXXXXXT

        //    int charCount = 1;

        //    for (int i = 0; i < source.Length - 1; i++)
        //    {
        //        char c = source[i];
        //        if (c == source[i + 1])
        //        {
        //            charCount++;

        //            if (charCount >= sequenceLength)
        //            {
        //                return true;
        //            }
        //        }
        //        else
        //        {
        //            charCount = 1;
        //        }
        //    }

        //    return false;
        //}


        public static List<Tuple<char, int>> DetectRepeatedChars(List<char> route)
        {
            int count = 1;
            var decomposed = new List<Tuple<char, int>>();

            char old = route[0];
            for (int x = 0; x < route.Count; x++)
            {


                if (x == route.Count - 1)
                {
                    if (route[x] == route[0])
                    {
                        if (count == route.Count)
                        {
                            //Todos son igual XXXXXXXXXX
                            //No se habra incluido ningun par en la lista de valores
                            decomposed.Insert(0, new Tuple<char, int>(old, count));

                        }
                        else
                        {
                            decomposed.Insert(0, new Tuple<char, int>(decomposed[0].Item1, decomposed[0].Item2 + count));
                            decomposed.RemoveAt(1);
                        }
                        return decomposed;

                    }

                    else
                    {
                        decomposed.Add(new Tuple<char, int>(old, count));
                        return decomposed;
                    }
                }


                if (route[x] == route[x + 1])
                {
                    count++;
                }
                else
                {

                    decomposed.Add(new Tuple<char, int>(old, count));
                    count = 1;
                    old = route[x + 1];

                }


            }
            return decomposed;

        }

        public static List<Tuple<char, int>> CountNumberofEntries(List<char> route)
        {
            var decomposed = new List<Tuple<char, int>>();
            var entries = new List<Tuple<char, int>>();
            decomposed = DetectRepeatedChars(route);


            List<char> distinct = route.Distinct().ToList();

            foreach (char ch in distinct)
            {
                var find = decomposed.FindAll(x => x.Item1 == ch);
                var entriescount = find.Count();
                entries.Add(new Tuple<char, int>(ch, entriescount));
            }

            return entries;
        }
    }
}
