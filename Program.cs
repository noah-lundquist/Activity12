using System;
public class HelloWorld
{
    public static void Main()
    {
        
        int i, word, l;


        
        string words = System.IO.File.ReadAllText(@"C:\Users\noahl\OneDrive\Desktop\testfile.txt");

        l = 1;
        word = 1;

        
        while (l <= words.Length - 1)
        {
            
            if ((words[l] == '.' || words[l] == ' ' || words[l] == '\t' || words[l] == '!' || words[l] == ',' || words[l] == '?' || words[l] == '\n') && (words[l - 1] == 't' || words[l - 1] == 'e'))
            {
                word++;
            }


            l++;
        }

        Console.Write("There are {0} words ending in t or e", word);
    }
}