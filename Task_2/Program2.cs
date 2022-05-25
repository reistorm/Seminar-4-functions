// Напишите программу, которая принимает на вход число 
// и выдает количество цифр в числе

Console.Write("Введите натуральное число = ");
int num = int.Parse(Console.ReadLine());
int count = 0;
Console.Write($"Количество цифр в числе {num} = ");
while (num > 0)
{
    num = num / 10;
    count++;
} 
Console.WriteLine(count);




