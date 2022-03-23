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
            if (StringToCheck.StartsWith(')') || StringToCheck.EndsWith('(')) return false;
            else
                {
                    char[] stringArray = StringToCheck.ToCharArray();
                    int leftParentheseCounter = 0;
                    int rightParentheseCounter = 0;
                    if (stringArray.Length%2 != 0 ) return false;
                    else
                        {
                            foreach (var item in stringArray)
                            {
                                if (item == '(') leftParentheseCounter++;
                                else if (item == ')') rightParentheseCounter++;
                                else return false;
                            }
                            if (leftParentheseCounter == rightParentheseCounter) return true;
                        }
                }
            return false;
        }
    }
}
