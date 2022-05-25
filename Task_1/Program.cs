// конвертация
//Console.WriteLine("Hello, World!");
// метод WriteLine, который не возвращает никакого значения и в скобках принимает аргумент строку

//int num = int.Parse(Console.ReadLine());
// Readline для ввода строки, текста; т.к. мы
// вводим число, то нельзя просто написать 
// int num = Console.ReadLine будет ошибка
// поэтому используем int.Parse для преобразования числа в текст
// int.Parse возвращает тип int и принимает string

// Задача 
// напишите программу, которая принимает на вход число А
// и выдает сумму чисел от 1 до А

Console.Write("Введите число А = ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= num; i++)
{
    sum = i + sum;
}
Console.WriteLine($"Сумма число от 1 до {num} = {sum}");




