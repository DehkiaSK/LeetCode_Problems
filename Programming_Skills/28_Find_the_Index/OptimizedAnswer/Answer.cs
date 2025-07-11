public class Answer
{
    public int StrStr(string haystack, string needle) 
    {
        if(needle.Length == 0)
        {
            return 0;
        }

        for(int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            string window = haystack.Substring(i, needle.Length);

            if(window == needle)
            {
                return i;
            }
        }

        return -1;
    }
}
