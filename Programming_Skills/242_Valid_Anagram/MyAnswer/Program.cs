using MyAnswer;

Answer answer = new();

string s = "shoo";
string t = "something";
bool result = false;

result = answer.IsAnagram(s, t);

Console.WriteLine(result);