// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);



// // Создание массива
// double[,] GetArray(int m, int n, double minValue, double maxValue)
// {
// double[,] res = new double[m,n];
// for(int i = 0; i < m; i++){
//  for(int j = 0; j < n; j++){
//    res [i,j] = random.NextDouble(minValue, maxValue + 1);
//  }
// }
// return res;
// }
// // Печать массива
// void PrintArray(double[,] array){
// for(int i = 0; i < array.GetLength(0); i++){
// for(int j = 0; j < array.GetLength(1); j++){
// Console.Write($"{array[i,j]} ");
// }
// Console.WriteLine();
// }
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// позиция i = 4, j = 2 -> такой позиции нет
// позиция i = 1, j = 0 -> 5

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите искомый номер строки элемента массива: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите искомый номер столбца элемента массива: ");
int b = int.Parse(Console.ReadLine()!);

int [,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);


// Создание массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
int[,] res = new int[m,n];
for(int i = 0; i < m; i++){
for(int j = 0; j < n; j++){
res[i,j] = new Random().Next(minValue, maxValue + 1);
}
}
return res;
}
// Печать массива
void PrintArray(int[,] array){
for(int i = 0; i < array.GetLength(0); i++){
for(int j = 0; j < array.GetLength(1); j++){
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
}

 if(a>= array.GetLength(0) && b>=array.GetLength(1)){
    Console.WriteLine("Превышена размерность массива: ");}
    else{
        int c = array[a,b];
     Console.WriteLine($" Искомый элемент массива: { c } ");
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом 
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
