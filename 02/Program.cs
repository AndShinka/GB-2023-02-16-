// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

int[,] CreateAndFillArray(int rows, int columns){
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = random.Next(1, 10);
    }
    return array;
}

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
           Console.Write($"{array[i,j]}\t");
        Console.WriteLine();
    }
}

int[,] CrossArray(int[,] array){
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = i; j < array.GetLength(1); j++)
        {
            temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
            Console.WriteLine($" {i}    {j}");
        }
    }
    return array;
}

/*
int[,] CrossArray(int[,] array){
    int[,] array2 = new int[array.GetLength(1),array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++)
            array2[i,j] = array[j,i];
    }
    return array2;
}
*/
Console.Clear();
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
if (rows==columns) {
    int[,] array = CreateAndFillArray(rows, columns);
    PrintArray(array);
    Console.WriteLine();
    PrintArray(CrossArray(array));
} else Console.WriteLine("Массив не квадратный!");
