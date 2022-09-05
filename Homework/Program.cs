string[] array1 = new string[] {"hello","2", "world", ":-)"};
string[] array2 = new string[array1.Length];
int count =0;
for (int i = 0; i < array1.Length; i++)
{
    if(array1[i].Length <= 3)
    {
        array2[count] = array1[i];
        count++;
    }
}
for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();
