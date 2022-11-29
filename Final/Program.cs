string[] array = new string[] { "Hello", "2", "world", ":-)" };
int NewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) NewArray++;
}

string[] newArray = new string[NewArray];
int idx = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[idx] = array[i];
        idx++;
    }
}
PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}