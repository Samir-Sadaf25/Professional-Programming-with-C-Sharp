(string name, int age) person = ("samir", 23);
person.name = "sadaf";
person.age = 25;

(int, string)[] arr = new (int, string)[2];

int[] nums = [1, 2, 3, 4, 3, 2, 2, 3, 2, 4, 2, 5, 5, 1];

(int number, int howMany)[] count = new (int, int)[nums.Length];
int idx = 0;
for (int i = 0; i < nums.Length; i++)
{
    bool found = false;
    for (int j = 0; j < count.Length; j++)
    {
        if (count[j].number == nums[i])
        {
            count[j].howMany++;
            found = true;
            
        }
    }
    if(!found)
    {
        count[idx++] = (nums[i], 1);
    }
}
//for (int  i = 0;  i < idx;  i++)
//{
//    Console.WriteLine($"{count[i].number}: {count[i].howMany}");
//}

// another example of Tuple
(int sum,int difference) calculate(int x,int y)
{
    return (sum: x + y, difference: x - y);
}
var (sum, diff) = calculate(15, 5);
Console.WriteLine($"{sum},{diff}");
