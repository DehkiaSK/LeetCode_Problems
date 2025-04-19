using OptimizedAnswer;

int[] nums = {-2, -2, -1, 0, 0 , 4, 5};

Answer answer = new Answer();

answer.SearchRange(nums, 0);

Console.WriteLine(string.Join(", ", nums));