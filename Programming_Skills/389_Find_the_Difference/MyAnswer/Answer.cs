namespace MyAnswer;
public class Answer
{
    public char FindTheDifference(string s, string t)
    {
        int asciiSumS = 0;
        int asciiSumT = 0;

        int i = 0;

        while(i < s.Length)
        {
            asciiSumS += s[i];
    
            i++;
        }

        i = 0;

        while(i < t.Length)
        {
            asciiSumT += t[i];  

            i++;            
        }

        return (char)(asciiSumT - asciiSumS);
    }
}
