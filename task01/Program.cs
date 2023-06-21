/* 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите первое число (A): ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число (B): ");
int numberB = int.Parse(Console.ReadLine()!);

Console.Write($"{numberA}, {numberB} -> ");
Degree(numberA, numberB);

void Degree(int numA, int numB) 
{
    int result = 1;
    for (int i = 1; i <= numB; i++) 
    {
        result *= numA;
    }
    Console.WriteLine(result);
}

