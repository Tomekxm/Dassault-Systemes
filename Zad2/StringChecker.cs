using System;

namespace Zad2
{
    public class StringChecker
    {
        private string _stringToCheck;

        public StringChecker(string stringToCheck)
        {
            StringToCheck = stringToCheck;
        }

        public StringChecker()
        {
            StringToCheck = "(((((()())))))";
        }

        public string StringToCheck { get => _stringToCheck; set => _stringToCheck = value; }
   
        public bool IsStringValid()
        {
            if (string.IsNullOrEmpty(StringToCheck)) return false;
            if (StringToCheck.StartsWith(")") || StringToCheck.EndsWith("(")) return false;
            else
            {
                if (StringToCheck.Length % 2 != 0) return false;
                else
                {
                    while (true)
                    {
                        if (StringToCheck == StringToCheck.Replace("()", "")) break;
                        StringToCheck = StringToCheck.Replace("()", "");
                    }
                    return (StringToCheck == string.Empty);
                }
            }
        }
    }
}
