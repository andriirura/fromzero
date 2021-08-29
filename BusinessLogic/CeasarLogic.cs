using System;

namespace BusinessLogic
{
    public class CeasarLogic
    {
        public static string EncodeCeasar(string text, int key)
        {
            //init data
            string code = string.Empty;
            char[] abc =
                {
                        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                        'v', 'w', 'x', 'y', 'z'
                    };
            //business logic
            foreach (var currentChar in text)
            {
                var indexInAbc = Array.IndexOf(abc, currentChar);
                var number = indexInAbc + key;

                if (number > 25)
                {
                    number -= abc.Length;
                }

                code = code + abc[number];
            }

            return code;
        }
    }
}