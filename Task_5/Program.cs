// Напишите программу, которая выводит массив 
// из 8 элементов, заполненный нулями и единицами 
// в случайном порядке (решение Григория для любых чисел)

int[] Gen_Array()
{
    Console.WriteLine("Введите число элементов массива: ");
    int N = int.Parse(Console.ReadLine());
    int[] arr = new int[N];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0,2);
    }
    return arr;
}
int[] newarr = Gen_Array();

var str = string.Join(" ", newarr);
Console.WriteLine(str);


