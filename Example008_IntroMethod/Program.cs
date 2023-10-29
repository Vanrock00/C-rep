void FillArray(int[] collection)
{
    int length = collection.Length;
    int i = 0;
    while (i < length)
    {
        collection[i] = new Random().Next(1, 10);
        i ++;
    }
}
void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position ++;
    }
}    
int IndexOf(int[] collection, int find)
{
    int i = 0;
    int count = collection.Length;
    while(collection[i] != find)
    {
        i ++;
    }
    return i;
}

int[] array = new int[10];
int number = 5;
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(IndexOf(array, number));