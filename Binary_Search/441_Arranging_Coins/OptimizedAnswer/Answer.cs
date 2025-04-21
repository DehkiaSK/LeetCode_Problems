namespace OptimizedAnswer;
public class Answer
{
    public int ArrangeCoins(int n)
    {
        if(n <= 0)
        {
            return 0;
        }

        long left = 1;
        long right = n;
        long completeRows = 0;

        while(left <= right)
        {
            long mid = left + ((right - left) / 2);
            long coinsNeeded = (mid * (mid + 1)) / 2; //The summation of the first "mid"-natural numbers

            if(coinsNeeded <= n)
            {
                completeRows = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return (int)completeRows;
    }
}
