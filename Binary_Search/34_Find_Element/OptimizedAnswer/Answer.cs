namespace OptimizedAnswer;
public class Answer
{
    public int GetF(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length - 1;
        int ans = -1;

        while(start <= end)
        {
            int mid = start + (end - start) / 2;

            if(nums[mid] == target)
            {
                ans = mid;
                end = mid - 1;
            }
            else if(nums[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return ans;
    }
    public int GetL(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length - 1;
        int ans = -1;

        while(start <= end)
        {
            int mid = start + (end - start) / 2;

            if(nums[mid] == target)
            {
                ans = mid;
                end = mid + 1;
            }
            else if(nums[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return ans;
    }
    public int[] SearchRange(int[] nums, int target)
    {
        int[] result = { -1, -1 };

        int first = GetF(nums, target);

        if(first == -1)
        {
            return result;
        }

        int last = GetL(nums, target);

        result[0] = first;
        result[1] = last;

        return result;
    }
}
