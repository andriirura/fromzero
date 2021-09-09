using System;

class GFG
{
    static String FirstAndLast(String str)
    {

        // Split the String based on the space
        String[] arrOfStr = str.Split(' ');

        // String to store the resultant String
        String res = "";

        // Traverse the words and
        // remove the first and last letter
        foreach (String a in arrOfStr)
        {
            res += a.Substring(1, a.Length - 2) + " ";
        }

        return res;
    }

    // Driver code
    public static void Main(String[] args)
    {
        String str = "Geeks for Geeks";
        Console.WriteLine(str);
        Console.WriteLine(FirstAndLast(str));
    }
}