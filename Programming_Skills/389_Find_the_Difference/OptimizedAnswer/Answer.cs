namespace OptimizedAnswer;
public class Answer
{
    public char FindTheDifference(string s, string t)
    {
        int asciiSumS = 0;
        int asciiSumT = 0;

        foreach(char c in s)
        {
            asciiSumS += c;
        }

        foreach(char c in t)
        {
            asciiSumT += c;
        }

        return (char)(asciiSumT - asciiSumS);
    }
}
