namespace OptimizedAnswer;
public class Answer
{
    public static bool IsPerfectSquare(int num)
    {
        if(num < 0)
        {
            return false;
        }

        if(num == 1 || num == 0)
        {
            return true;
        }

        long left = 1; //Using long to prevent overflow
        long right = num / 2; //Perfect squares cannot be greater than num/2

        while(left <= right) //Remember to put "<=" instead of just "<"
        {
            long mid = left + ((right - left) / 2);
            long square = mid * mid;

            if(square == num)
            {
                return true;
            }
            else if(square < num)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}
