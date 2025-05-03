using System.Text;

namespace OptimizedAnswer;

public class Answer
{
    public string MergeAlternately(string word1, string word2)
    {
        int word1Length = word1.Length;
        int word2Length = word2.Length;
        StringBuilder result = new(word1Length + word2Length);

        int i = 0, j = 0;
        while(i < word1Length || j < word2Length)
        {
            if(i < word1Length)
            {
                result.Append(word1[i++]);
            }
            if(j < word2Length)
            {
                result.Append(word2[j++]);
            }
        }

        return result.ToString();
    }
}
