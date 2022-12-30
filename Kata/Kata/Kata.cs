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
        // index --> ostatnia litera, tworzy separator, konczy jako slowo, wrzuca do listy
        // leci next 
        // jak skonczy odwraca liste 
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
                else if (i == input.Length - 1)
                {
                    var word = input.Substring(current_index, input.Length - current_index);
                    result.Add(word);

                }
            
            
            
            
            }


            return result; 
        }
    
    
    
    
    }
}
