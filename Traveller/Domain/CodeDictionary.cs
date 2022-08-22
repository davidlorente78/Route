namespace Traveller.Domain
{
    //TODO 
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
                        return "Chiang Mai";
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
    }

}

