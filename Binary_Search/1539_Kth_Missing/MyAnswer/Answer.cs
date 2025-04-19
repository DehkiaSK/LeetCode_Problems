namespace MyAnswer;
public class Answer
{
    public int FindKthPositive(int[] arr, int k)
    {
        int[] resultArray = new int[10000];

        #region InitializingResultArrayUntil(arr[0])
        int value = 1;
        int resultArrayIndex;

        for(resultArrayIndex = 0; resultArrayIndex < arr[0] - 1; resultArrayIndex++)
        {
            resultArray[resultArrayIndex] = value;

            value++;
        }
        #endregion

        #region FillingInBetweenResultArray

        int firstElement = arr.First();
        int lastElement = arr.Last();
        int u = firstElement + 1;

        while(u <= lastElement)
        {
            if(arr.Contains(u))
            {
                u++;

                continue;
            }
            else
            {
                resultArray[resultArrayIndex] = u;

                u++;
                resultArrayIndex++;
            }
        }
        #endregion

        #region FillingResultArrayFromMiddleToEnd
        for(int i = resultArray.Max(); i < resultArray.Length; i++)
        {
            if(arr.Contains(i + 1))
            {
                continue;
            }

            resultArray[resultArrayIndex] = i + 1;

            resultArrayIndex++;
        }
        #endregion

        return resultArray[k - 1];
    }
}
