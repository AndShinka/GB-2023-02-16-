Console.Clear();
Console.WriteLine("Поиск заданного числа в двумерном массиве" !);
Console.WriteLine();

void PrintMass(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i , j]} \t" !);
        }
        Console.WriteLine();
    }
}

int[,] CreateMass(int size)
{   
    int[,] massive = new int[size, size];
    Random rnd = new Random();
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i , j] = rnd.Next(0 , 11);
        }
    }
    return massive;
}

int ReadNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int ComputeDiagonal(int[,] mass)
{
    int sumDiagonal = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
       sumDiagonal += mass[i, i];
    }
    return sumDiagonal;
}

int sizeNum = ReadNum("Enter massive size:"!);
int[,] array = CreateMass(sizeNum);


Console.WriteLine("Задача: найти сумму главной диагонали");
PrintMass(array);
Console.WriteLine();
Console.WriteLine($" Cумма главной диагонали равна {ComputeDiagonal(array)}");