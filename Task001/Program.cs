// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А

int Sum(int a)
{
    int result = 0;
    for (int number = 0; number <= a; number++)
    {
        result += number;
    }
    return result;
}

void PrintSum(int a)
{
    Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sum(a)}");
}

PrintSum(5);
PrintSum(10);
PrintSum(0);
PrintSum(-20);

//Console.WriteLine(Sum(5)); // 1+2+3+4+5 = 15
//Console.WriteLine(Sum(10));
//Console.WriteLine(Sum(0));
//Console.WriteLine(Sum(-20));