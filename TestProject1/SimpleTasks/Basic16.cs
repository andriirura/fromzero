using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace TestProject1.SimpleTasks
{
    //https://www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-16.php
    [TestFixture]
    class Basic16test
    {
        public static string ChangeIndex(string text)
        {


            // split string into words
            var words = new List<string>();
            string change = "";
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
            foreach (string item in words)
            {
                if (item.Length > change.Length)
                {
                    change = item;
                }
            }

            return change;
        }
    }
}