namespace Traveller.Domain
{
    public static class CodeDictionary
    {
        public static string GetCountryByCode(char input)
        {
            switch (input)
            {
                case 'A':
                    {
                        return "Angkor";
                    }

                case 'B':
                    {
                        return "Myanmar";
                    }
                case 'T':
                    {
                        return "Thailand";
                    }
                case 'L':
                    {
                        return "Laos";
                    }
                case 'C':

                    {
                        return "Cambodia";
                    }
                case 'V':

                    {
                        return "Vietnam";
                    }
                case 'H':

                    {
                        return "Hainan";
                    }
                case 'K':

                    {
                        return "Kochi";
                    }
                case 'S':

                    {
                        return "Sri Lanka";
                    }

                case 'M':
                    {
                        return "Malaysia";
                    }
                case 'G':

                    {
                        return "Singapur";
                    }
                case 'I':

                    {
                        return "Indonesia";
                    }

                case 'W':

                    {
                        return "Penang";
                    }

                case 'E':
                    {
                        return "Perhentian";
                    }

                case 'N':
                    {
                        return "Nepal";
                    }

                case 'O':
                    {
                        return "Bali";
                    }

                default:
                    {
                        return "Unknown";
                    }
            }
        }

        public static string GetMonthByInt(int i)
        {

            switch (i)
            {
                case 1: { return "January"; }
                case 2: { return "February"; }
                case 3: { return "March"; }
                case 4: { return "April"; }
                case 5: { return "May"; }
                case 6: { return "June"; }
                case 7: { return "July"; }
                case 8: { return "August"; }
                case 9: { return "September"; }
                case 10: { return "October"; }
                case 11: { return "November"; }
                case 12: { return "December"; }

            }
            return string.Empty;
        }
    }
}

