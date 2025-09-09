string s = Console.ReadLine();
char[] arr = s.ToCharArray();
for (int i = 0; i < arr.Length; i+=2)
{
    int min_idx = i;
    for (int j = i+2; j < arr.Length; j+=2)
    {
        if (arr[j] < arr[min_idx])
        {
            min_idx = j;
        }
        
    }
    char temp = arr[i];
    arr[i] = arr[min_idx];
    arr[min_idx] = temp;
}

Console.WriteLine(new string(arr));