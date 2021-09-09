using System;
using System.Runtime.InteropServices;

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


        /// <summary>
        /// Encode text using Ceasar cipher
        /// </summary>
        /// <param name="text">Text to encode</param>
        /// <param name="key">Key for encoding. Acceptable values must be > 0</param>
        /// <returns></returns>
        public static string EncodeCeasar2(string text, int key)
        {
            if (text == null)
                throw new ArgumentNullException(text, "You can't convert null values");


            //init data
            string code = string.Empty;

            char[] abcLower = new char[26];
            for (int i = 0; i < 26; i++)
            {
                abcLower[i] = (char)('a' + i);
            }

            char[] abcUpper = new char[26];
            for (int i = 0; i < 26; i++)
            {
                abcUpper[i] = (char)('A' + i);
            }

            //business logic
            foreach (var currentChar in text)
            {


                if (char.IsLetter(currentChar))
                {
                    var alphabet = char.IsUpper(currentChar) 
                        ? abcUpper 
                        : abcLower;
                    
                    var indexInAbc = Array.IndexOf(alphabet, currentChar);
                    var number = indexInAbc + key;

                    if (number > 25)
                    {
                        number -= alphabet.Length;
                    }

                    code = code + alphabet[number];
                }
                else
                {
                    //do nothing
                    code += currentChar;
                }
            }

            return code;
        }



        /// <summary>
        /// Encode text using Ceasar cipher. Third variant
        /// </summary>
        /// <param name="text">Text to encode</param>
        /// <param name="key">Key for encoding. Acceptable values must be > 0</param>
        /// <returns></returns>
        public static string EncodeCeasar3(string text, int key)
        {
            if (text == null)
                throw new ArgumentNullException(text, "You can't convert null values");


            //init data
            string code = string.Empty;

            //business logic
            foreach (var currentChar in text)
            {
                if (char.IsLetter(currentChar))
                {
                    char codedCharacter = (char)(currentChar + key);

                    codedCharacter = (char)(char.IsUpper(currentChar)
                        ? RangeLogic.NormalizeRange('A', 'Z'+1, codedCharacter)
                        : RangeLogic.NormalizeRange('a', 'z'+1, codedCharacter));

                    code += codedCharacter;
                }
                else
                {
                    //do nothing
                    code += currentChar;
                }
            }

            return code;
        }
    }
}