using System.Collections.Generic;

namespace MyAnswer;

public class Answer
{
    public string MergeAlternately(string word1, string word2)
    {
        List<char> appendList = [];
        int word1Length = word1.Length;
        int word2Length = word2.Length;

        char[] word1CharArray = word1.ToCharArray();
        char[] word2CharArray = word2.ToCharArray();

        if(word1Length == word2Length)
        {
            for(int i = 0; i < word1Length; i++)
            {
                appendList.Add(word1CharArray[i]);

                appendList.Add(word2CharArray[i]);
            }
        }
        else if(word1Length > word2Length)
        {
            int i = 0;

            while(i < word1Length && i < word2Length)
            {
                appendList.Add(word1CharArray[i]);

                appendList.Add(word2CharArray[i]);

                i++;
            }

            while(i < word1Length)
            {
                appendList.Add(word1CharArray[i]);

                i++;
            }
        }
        else
        {
            int i = 0;

            while(i < word1Length && i < word2Length)
            {
                appendList.Add(word1CharArray[i]);

                appendList.Add(word2CharArray[i]);

                i++;
            }

            while(i < word2Length)
            {
                appendList.Add(word2CharArray[i]);

                i++;
            }
        }

        //foreach(char c in appendList)
        //{
        //    Console.WriteLine(c);
        //}

        string finalAnswer = string.Join("", appendList);

        return finalAnswer;
    }
}
