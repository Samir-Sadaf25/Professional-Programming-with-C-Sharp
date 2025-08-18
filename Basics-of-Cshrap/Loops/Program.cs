
var x = 328492;

for (var i = 0; i < 5; i++)
{
    Console.WriteLine(x);
}

while (true)
{
    var line = Console.ReadLine();

    if (line == string.Empty)
        break;
}


int t = 0;
do
{
    Console.WriteLine(t);
    t++;

} while (t > 0 && t < 5);

var t2 = 0;

while (t2 > 0 && t2 < 5)
{
    Console.WriteLine(t2);
    t2++;

}


int[] ages = [33, 44, 55, 77];
var sum = 0;
foreach (var age in ages)
{
    sum = sum + age;
}
Console.WriteLine(sum);



