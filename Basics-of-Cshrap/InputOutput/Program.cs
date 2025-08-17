//Console.WriteLine("Hello my name is samir"); // print and create a new line
//Console.WriteLine("i am currently learning c#");

//Console.Write("Dev"); //print side by side
//Console.Write("Skill");

//string line = Console.ReadLine(); //string input from the user
//char c = (char)Console.Read(); // charracter input from the user
//ConsoleKeyInfo key = Console.ReadKey(); // key input from the user


//int x;
//string line = Console.ReadLine(); 
//x = int.Parse(line); // int input from the user
//Console.WriteLine(x);

var nums = new int[5];
//for (int i = 0; i < 5; i++)
//{
//    nums[i] = int.Parse(Console.ReadLine());
//}

string line = Console.ReadLine();
string[] words = line.Split(' ',','); // split the input by space
int m = 0;
foreach (string word in words)
{
    nums[m++] = int.Parse(word.Trim());
}
