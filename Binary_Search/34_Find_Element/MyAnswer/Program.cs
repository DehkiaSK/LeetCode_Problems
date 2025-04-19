using MyAnswer;

Answer answer = new();

int [] nums = {-1, 2, 3, 4, 5, 5, 5, 10};
int[] result = [];

result = answer.SearchRange(nums, 5);

Console.WriteLine(string.Join(", ", result));