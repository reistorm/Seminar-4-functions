// Программа, которая выведет произведение чисел от 1 до N

Console.WriteLine("Введите число N = ");
int num = int.Parse(Console.ReadLine());
int prod = 1;

for (int i = 1; i <= num; i++)
{
prod = i * prod;
}
Console.WriteLine($"Произведение чисел от 1 до N = {prod}");