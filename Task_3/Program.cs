// Напишите программу, которая выводит массив 
// из 8 элементов, заполненный нулями и единицами 
// в случайном порядке

int[] arr = new int[8]; // создаем массив из 8 чисел
int[] PrintArray(int[] array) // создаем метод PrintArray 
{
    int count = array.Length; //указываем длину массива
    for (int i = 0; i < count; i++) // инициализация счетчика
    {
        array[i] = new Random().Next(0, 2); //каждому элементу присваиваем число 0 или 1
        Console.Write(array[i]);

    }
    return array;
}

PrintArray(arr);
