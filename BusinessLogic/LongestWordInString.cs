using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LongestWordInString
    {
        public static string GetLongestWord(string text)
        {
            

            // split string into words
            var words = new List<string>();
            string max = "";
            while (text.Length > 0)
            {
                int indexOfSpace = text.IndexOf(' ');

                if (indexOfSpace == -1)
                {
                    words.Add(text);
                    text = "";
                }
                else
                {
                    string word = text.Substring(0, indexOfSpace);
                    words.Add(word);
                    text = text.Substring(indexOfSpace + 1);
                }
            }

            // find longest word
            foreach ( string item in words)
            {
                if (item.Length > max.Length)
                {
                    max = item;
                }
            }

            return max;
        }
    }
}
