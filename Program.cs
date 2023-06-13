// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



// Console.WriteLine ("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] arrayay = new int [m, n];

// void Fellarrayay(int[,] arrayay)

// {
//     for (int i = 0; i < arrayay.GetLength(0) ; i++)
//         {
//             for (int j = 0; j < arrayay.GetLength(1) ; j++)
//         {
//             arrayay[i, j] = Convert.Toint(new Random().Next(-100, 100)) / 10;
//         }
//         }
        
// }
// void Printarrayay(int[,] arrayay)
// {

//         for (int i = 0; i < arrayay.GetLength(0) ; i++)
//         {
//             for (int j = 0; j < arrayay.GetLength(1) ; j++)
//         {
//             Console.Write(arrayay[i, j] + " ");
//         }
        
//         Console.WriteLine();
//         }
// }

// Fellarrayay( arrayay );
// Printarrayay ( arrayay );


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.WriteLine ("Введите индекс строки: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите индекс столбца: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] arrayay = new int [m, n];

// void Fellarrayay()

// {
//     for (int i = 0; i < arrayay.GetLength(0) ; i++)
//         {
//             for (int j = 0; j < arrayay.GetLength(1) ; j++)
//         {
//             arrayay[i, j] = new Random().Next(-100, 100);
//         }
//         }
        
// }
// void Printarrayay()
// {

//         for (int i = 0; i < arrayay.GetLength(0) ; i++)
//         {
//             for (int j = 0; j < arrayay.GetLength(1) ; j++)
//         {
//             Console.Write(arrayay[i, j] + " ");
//         }
        
//         Console.WriteLine();
//         }
// }


// if (m < arrayay.GetLength(0) && n < arrayay.GetLength(1)) Console.WriteLine(arrayay[m, n]);
//  else Console.WriteLine($"{m}{n} -> такого числа в массиве нет");
        

// Fellarrayay( );
// Printarrayay ( );


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Random random = new Random();
// int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];


// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = random.Next(1, 10);
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("---------------------------");
// Console.WriteLine(array.GetLength(0));
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum += array[i, j];
//     }
//     Console.Write($"{ sum / array.GetLength(0)} ");
// }
