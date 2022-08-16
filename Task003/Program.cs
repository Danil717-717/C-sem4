// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N
// 4 -> 24 
// 5 -> 120

int multiPlic(int a)
{
    int result = 1;
    for(int i = 1; i <= a; i++)
    {
        result*=i;
    }
    return result;
}

//Console.WriteLine(multiPlic(4));

void PrintMult(int a)
{
    Console.WriteLine($"Произведение числа {a} равно {multiPlic(a)}");
}

PrintMult(4);
PrintMult(5);
PrintMult(6);