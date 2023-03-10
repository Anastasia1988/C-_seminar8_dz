// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Akermann(int numM, int numN)
{
    
    if (numM == 0) return (numN + 1);    
    else if (numM > 0 && numN == 0) return Akermann(numM - 1, 1);
    else return Akermann(numM - 1, Akermann(numM, numN - 1));     
}

int numM = ReadInt("Введите число M: ");
int numN = ReadInt("Введите число N: ");
// var myAkermann=Akermann(numM,numN);
int myAker=Akermann(numM,numN);

System.Console.WriteLine(Convert.ToString($"Результат вычисления функции Аккермана равен: {myAker}"));