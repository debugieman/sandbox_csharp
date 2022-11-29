using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Kata
    {
        // this is test  -> test is this
        // tablica ??

        public static string ReverseWords(string str)
        {
            return "";

        }
        public static List<string> Splitter(string input, char separator)
        { 
        var result = new List<string>();
            var  current_index = 0;
            for (int i; i < input.Length; i++)
            {
                if (input[i] == separator)
                {
                    var word = input.Substring(current_index, i - current_index);
                    result.Add(word);
                    current_index = i + 1;

                }
                else if (i == input.Lenght - 1)
                {
                    var word = input.Substring(current_index, input.Lenght - current_index);
                    result.Add(word);

                }
            
            
            
            
            }


            return result; 
        }
    
    
    
    
    }
}
