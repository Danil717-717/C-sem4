// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int numberDigits(int a)
{
    int result = 0;
    for(int i = a; i > 0; i /= 10)
    {
        result++; 
    }
    return result;
}
void PrintDig(int a)
{
    Console.WriteLine($"Колличество цифр в числе {a} равна {numberDigits(a)}");
}

PrintDig(555);
PrintDig(55545);
PrintDig(5555);
PrintDig(555699);
PrintDig(550);