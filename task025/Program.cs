Console.Clear();

Console.WriteLine("введите первое число: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.WriteLine("введите второе число: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
Console.WriteLine(Power(number1, number2));

int Power(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}