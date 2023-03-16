// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите размер массива");
int sizearray=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());

int [] FillArray (int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for( int i=0; i<size; i++)
    {
        arr[i]= rnd.Next(min, max+1);
    }
    return arr;
}

void PrintArray(int[]arr)
{
    Console.Write("[");
    for (int i=0; i<arr.Length; i++)
    {
        if(i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] array = FillArray(sizearray, -10, 10);

int FindNumber(int[]arr, int x)
{
    for (int i=0; i<arr.Length; i++)
    {
        if(arr[i]==x) return 1;
    }
    return 0;
}

PrintArray(array);
int findNumber=FindNumber(array, number);
Console.Write(findNumber>0? "Данное число есть в массиве" : "Числа в массиве нет");
