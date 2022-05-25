// Программа, которая выведет произведение чисел от 1 до N

Console.WriteLine("Введите число N = ");
int num = int.Parse(Console.ReadLine());
int num1 = 1;

for (int i = 1; i <= num; i++)
{
num1 = i * num1;
}
Console.WriteLine($"Произведение чисел от 1 до N = {num1}");