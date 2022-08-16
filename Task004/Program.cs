// Напишите программу, которая выводит массив из
// 8 элементов,
// заполненный нулями и единицами в случайном порядке


int [] arrayMass(int len)
{
    int [] arr = new int [len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0,2);
    } 
    return arr;
}

void PrintArr(int [] arr)
{
    int len = arr.Length;
    for(int i = 0; i < len; i++)
    {
        Console.Write($"{arr[i]}");
    }    
}

//arrayMass(8);
PrintArr(arrayMass(8));