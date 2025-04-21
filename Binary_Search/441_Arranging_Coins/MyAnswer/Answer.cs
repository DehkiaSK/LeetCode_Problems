namespace MyAnswer;
public class Answer
{
    public int ArrangeCoins(int n)
    {
        int completeRows = 0;
        int stepCost = 1;

        while(n > 0)
        {
            n -= stepCost;

            if(n >= 0)
            {
                completeRows++;
                stepCost++;
            }
        }

        return completeRows;
    }
}
