namespace MyAnswer;

public class Answer
{
    public void MoveZeroes(int[] nums)
    {
        int insertPos = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                nums[insertPos] = nums[i];

                insertPos++;
            }

            //Console.WriteLine
            //foreach(int x in nums)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine();
        }

        while(insertPos < nums.Length)
        {
            nums[insertPos] = 0;

            insertPos++;
        }

        foreach(int x in nums)
        {
            Console.WriteLine(x);
        }
    }
}
