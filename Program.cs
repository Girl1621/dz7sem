//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами. Сделать отдельный метод который генерирует 
//двумерный массив и отдельный метод который выводит его на экран.
//m и n вводит пользователь в консоль

// Console.WriteLine("Введите m - ");
// bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
// Console.WriteLine("Введите n - ");
// bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
// Console.WriteLine($"m = {m}");
// Console.WriteLine($"n = {n}");

// int[,] array = Create2DArray(m, n);
// Print2DArray(array);

// int[,] Create2DArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     Random random = new Random();
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(-10, 20);
//         }
//     }

//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.WriteLine("Введите m - ");
// bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
// Console.WriteLine("Введите n - ");
// bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
// int[,] array = Create2DArray(5, 5);
// Print2DArray(array);
// SearchElementValue(array, m, n);

// int[,] Create2DArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToInt32(new Random().Next(-10, 20));
//         }
//     }

//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SearchElementValue(int[,] array, int m, int n)
// {
//     if( m > array.GetLength(0) -1 || n > array.GetLength(1) -1 )
//     {
//         Console.Write("ошибка!");
//     }
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             if(i == m && j == n)
//             {
//                 Console.Write($"{array[i, j]} ");
//             }
//         }
//     }

// }

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце. 
// Поиск среднее арифметического в отдельном методе.

Console.WriteLine("Введите m - ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

int[,] array = Create2DArray(m, n);
Print2DArray(array);

double[] result = SearchTheArithmeticMean(array);
Console.WriteLine();
PrintNewArray(result);
int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 11));
        }
    }

    return array;
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] SearchTheArithmeticMean(int[,] array)
{
    double[] sum = new double[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        double summ = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }

        sum[i] = summ / array.GetLength(1);
        summ = 0;
    }
    return sum;

}

void PrintNewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}