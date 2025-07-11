using OptimizedAnswer;


Answer answer = new();

string s = "arstdhnei";
string t = "ienhdttsra";
char result;

result = answer.FindTheDifference(s, t);

Console.WriteLine(result);