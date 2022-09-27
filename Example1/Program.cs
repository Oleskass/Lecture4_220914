﻿//=================== Двумерные массивы: =============================  
// string[,] table = new string[2,3];
// от нуля

// string[,] table = new string[2, 5]; //0,0 0,1 0,2 0,3 0,4
//                                     //1,0 1,1 1,2 1,3 1,4
//                                     //String.Empty - инициализация строк
// table[1, 2] = "blabla";  // обращение  к эл-ту массива

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-"); //интерполяция строк
//     }
// }


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) //внешний цикл - строки
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //внутренний цикл - столбцы
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine(); //для перехода на новую строку
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10); //[1;10)
//         }
//     }
// }

// int[,] matrix = new int[3, 4]; //создаём двумерный массив - матрицу
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine(); //прослойка ))
// PrintArray(matrix);

// int[,] pic = new int[,] //необяз.указывать кол-во строк и столбцов если у нас есть фиксированные данные
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++) //внешний цикл - строки
//     {
//         for (int j = 0; j < image.GetLength(1); j++) //внутренний цикл - столбцы
//         {
//             if (image[i, j] == 0) Console.Write(" "); //если эл-т массива равен 0, то мы печатаем вместо него пробел
//             else Console.Write($"+"); //иначе печатаем плюсик
//         }
//         Console.WriteLine(); //для перехода на новую строку
//     }
// }

// void FillImage(int row, int col) //в скобках строка и столбец, с которых мы начнём нашу закраску
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col); //рекурсия - метод, который вызывает сам себя
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }

// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);

// ===================== Факториал: =====================================

// int Factorial(int n)
// {
//     // 1! =1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// // Console.WriteLine(Factorial(3)); // 1*2*3 = 6

// for (int i = 1; i < 40; i++) //
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}"); //на i=17 начинаются отриц.числа - это из-за переполнения типа int, они не вмещаются
// }

// double Factorial(int n) // меняем тип данных на double
// {
//     // 1! =1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }


// for (int i = 1; i < 40; i++) //
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}"); 
// }


// ===================== Фибоначчи: =====================================

// 1 1 2 3 5 8 13 21 ... 
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n) //для больших чисел double
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 10; i++) //с 40 начинает тормозить по расчётам
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}