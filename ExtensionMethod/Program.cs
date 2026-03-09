using ExtensionMethod;

DateTime date = DateTime.Now;
string s = date.dateTimeToString();
//Console.WriteLine(s);

string str = "hello i am samir sadaf and i am currently learning extension method";
Console.WriteLine(str.getShortString(30));
