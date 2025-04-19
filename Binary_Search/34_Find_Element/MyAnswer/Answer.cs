namespace MyAnswer;
public class Answer
{
    public int[] SearchRange(int[] nums, int target)
    {
        List<int> tempList = [];

        for(int i = 0; i <= nums.Length - 1; i++)
        {
            if(nums[i] == target)
            {
                tempList.Add(i);
            }
        }

        if(tempList.Count == 0)
        {
            return [-1, -1];
        }
        else
        {
            int[] result = tempList.ToArray();

            return [result[0], result[result.Length - 1]];
        }
    }
}
