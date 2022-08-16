// Напишите цикл, который принимает 
// на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int numA, int numB)
{
    int count = 1;
    for(int i = 1; i <= numB; i++)
    {
        count *= numA;
    }
    return count;
}

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Degree(numA, numB);
Console.WriteLine($"{numA}, {numB} -> " + exponentiation + $" (число {numA} в {numB} степени )");