namespace MyAnswer;
public class Answer
{
    public bool IsPerfectSquare(int num)
    {
        if(num == 1)
        {
            return true;
        }

        int squareRoot = 1;

        while(squareRoot <= (num / 2))
        {
            int square = squareRoot * squareRoot;

            if(square == num)
            {
                return true;
            }
            else
            {
                squareRoot++;
            }
        }

        return false;
    }
}
