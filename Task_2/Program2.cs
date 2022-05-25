// Напишите программу, которая принимает на вход число 
// и выдает количество цифр в числе

//Console.Write("Введите натуральное число = ");
//int num = int.Parse(Console.ReadLine());
//int count = 0;
//Console.Write($"Количество цифр в числе {num} = ");
//while (num > 0)
//{
//    num = num / 10;
//    count++;
//}
//Console.WriteLine(count);

// через цикл for
Console.Write("Введите натуральное число = ");
int num = int.Parse(Console.ReadLine());
int dig = 0;
for (int i = 1; i < num; i = i * 10)
{
    dig++;
}
Console.WriteLine($"Количество цифр в строке {num} = {dig}");


// end