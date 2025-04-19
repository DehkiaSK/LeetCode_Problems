namespace MyAnswer;
public class Answer
{
    public int MySqrt(int x)
    {
        if(x == 0)
        {
            return 0;
        }
        if(x < 0)
        {
            return -1;
        }
        if(x == 1)
        {
            return 1;
        }

        long left = 1;
        long right = x / 2;
        long result = 0;

        while(left <= right)
        {
            long mid = left + ((right - left) / 2);
            long square = mid * mid;

            if(square == x)
            {
                return (int)mid;
            }
            else if(square < x)
            {
                result = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return (int)result;
    }
}
