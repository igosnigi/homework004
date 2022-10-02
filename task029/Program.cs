Console.Clear();

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    Random rand = new Random();
for (int i = 0; i < 8; i++)
{
    array[i] = rand.Next();
}
}
void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]} ");
    }
}