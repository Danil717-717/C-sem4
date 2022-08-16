// Напишите программу, которая
// задаёт массив из 8 элементов и выводит их на экран
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] ArrayRnd(int n)
{
    int[] arr = new int [n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write(" [ ");
    for ( int i = 0; i < arr.Length; i++)
    {
        if (i>0) Console.Write(", ");
        Console.Write($"{arr[i]}");
    }
        Console.WriteLine("]");
}

PrintArray(ArrayRnd(8));
PrintArray(ArrayRnd(8));
PrintArray(ArrayRnd(8));
PrintArray(ArrayRnd(8));