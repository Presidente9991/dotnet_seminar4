/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Write("Массив из 8 элементов: ");
CreateEightArray();

void CreateEightArray()
{
    int[] eightArray = new int[8];
    for (int i = 0; i < eightArray.Length; i++)
    {
        eightArray[i] = new Random().Next(1, 100);
        Console.Write(eightArray[i] + " ");
    }
}