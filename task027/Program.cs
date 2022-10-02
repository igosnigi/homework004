Console.Clear();

Console.WriteLine("введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);
Console.WriteLine(Sum(number));

int Sum(int num)
{
    int s = 0;
    while(num > 0)
    {
        s = s + num % 10;
        num = num / 10;
    }
    return s;
}
