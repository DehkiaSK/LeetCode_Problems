using MyAnswer;

Answer answer = new Answer();

int[][] myMatrix = [[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]];

bool result = answer.SearchMatrix(myMatrix, 35);

Console.WriteLine(result);