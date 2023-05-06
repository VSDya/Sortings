/*void Check(int[] data)
{
    bool flag = true;
    int size = data.Length;
    for (int i = 0; i < size - 1; i++)
    {
        if (!(data[i] <= data[i + 1]))
        {
            flag = false;
            break;
        }
    }
    Console.WriteLine(flag);
}

const int n = 1000;

int[] array = Enumerable.Range(1, n)
                        .Select(item => Random.Shared.Next(1000))
                        //.Select(item => n - item)
                        .ToArray();

// Console.WriteLine($"Array: [{String.Join(' ', array)}]");
int count = 0;
bool needSort = true;
int j = 0;
while (needSort)
{
    needSort = false;
    for (int i = n - 1; i > j; i--)
    {
        if (array[i] < array[i - 1])
        {
            int temp = array[i];
            array[i] = array[i - 1];
            array[i - 1] = temp;
            needSort = true;
        }
        count++;
    }
    j++;
}
// Console.WriteLine($"Array: [{String.Join(' ', array)}]");
Console.WriteLine($"count {((n * n - n) / 2) - count}");
Check(array);*/