namespace MyAnswer;

public class Answer
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> sDictionary = new();
        Dictionary<char, int> tDictionary = new();

        foreach(char c in s)
        {
            if(sDictionary.ContainsKey(c))
            {
                sDictionary[c]++;
            }
            else
            {
                sDictionary[c] = 1;
            }
        }

        foreach(char c in t)
        {
            if(tDictionary.ContainsKey(c))
            {
                tDictionary[c]++;
            }
            else
            {
                tDictionary[c] = 1;
            }
        }

        foreach(var item in sDictionary)
        {
            if(!tDictionary.ContainsKey(item.Key) || tDictionary[item.Key] != item.Value)
            {
                return false;
            }

        }

        return true;
    }
}
