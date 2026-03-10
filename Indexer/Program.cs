using Indexer;

SimpleCollection myColl = new SimpleCollection();
myColl[0] = "Hello";
myColl[1] = "bello";
Console.WriteLine(myColl[1]);
HighScores high = new HighScores();
high["Alice"] = 500;
high["samir"] = 600;
Console.WriteLine(high["samir"]);