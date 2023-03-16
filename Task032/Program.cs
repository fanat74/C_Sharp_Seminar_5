// Задача 32: Напишите программу замена элементов 
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int[] array = FillArray(15, -9, 9);

void ChangeArray(int[]arr)
{
    Console.Write("[");
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]*(-1)}, ");
    }
    Console.WriteLine("]");
}

PrintArray(array);
ChangeArray(array);
