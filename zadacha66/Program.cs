// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int SumArray(int numN, int numM)
{
    int count = 0;
    int sum = 0;
    for (int i = numN; count <= numM; count++)
        if (numN <= numM)
        {
            sum = sum + numN++;

        }
    return sum;
}
void PrintSumArray(int numN, int numM)
{
        System.Console.WriteLine($"сумму натуральных элементов в промежутке от {numN}  до {numM} равна {SumArray(numN, numM)}");
}

int numN = ReadInt("Введите число N: ");
int numM = ReadInt("Введите число M: ");

var mySum= SumArray(numN, numM);
PrintSumArray(numN, numM);