//==================================================================================================================================================
// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void MassivMnVewestvennij(int m, int n)
{
    double[,] massiv = new double[m,n];
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Random random = new Random();
            massiv[i,j] = random.Next(-10,10) + random.NextDouble();
            Console.Write($"{massiv[i,j]} "); 
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк массива");
int chisloCtrok = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int chisloCtolbcov = Convert.ToInt32(Console.ReadLine());

MassivMnVewestvennij(chisloCtrok, chisloCtolbcov);
*/
//==============================================================================================================================================
// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Вариант 1
/*
void PoiskZnacheniyaElementaPoIndekcamMassiva(int ctrokiNomer, int kolonkiNomer)
{
    Random random = new Random();
    int[,] massiv = new int[random.Next(1,11),random.Next(1,11)];

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i,j] = random.Next(1,10);
            Console.Write($"[{i},{j}]{massiv[i,j]} ");
        }
        Console.WriteLine();
    }
    
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if(i == ctrokiNomer && j == kolonkiNomer) Console.WriteLine($"Значение элеметна с индексом Масссив[{ctrokiNomer},{kolonkiNomer}] = {massiv[i,j]}");
            else if (ctrokiNomer > massiv.GetLength(0) - 1 || ctrokiNomer < 0 || kolonkiNomer > massiv.GetLength(1) - 1 || kolonkiNomer < 0)
            {
                Console.WriteLine($"Элемент с индексом Массив[{ctrokiNomer},{kolonkiNomer}] в массиве отсутствует");
                break;
            }
        }
        if (ctrokiNomer > massiv.GetLength(0) - 1 || ctrokiNomer < 0 || kolonkiNomer > massiv.GetLength(1) - 1 || kolonkiNomer < 0) break;
    }
}

Console.WriteLine("Введите номер строки элемента массива");
int nomerCtroki = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента массива");
int nomerCtolbca = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

PoiskZnacheniyaElementaPoIndekcamMassiva(nomerCtroki, nomerCtolbca);
*/
// Вариант 2===================================================================================================================================
/*
void PoiskZnacheniyaElementaPoIndekcamMassiva(int ctrokiNomer, int kolonkiNomer)
{
    Random random = new Random();
    int[,] massiv = new int[random.Next(1,11),random.Next(1,11)];

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i,j] = random.Next(1,10);
            Console.Write($"[{i},{j}]{massiv[i,j]} ");
        }
        Console.WriteLine();
    }
    
    if (ctrokiNomer > massiv.GetLength(0) - 1 || ctrokiNomer < 0 || kolonkiNomer > massiv.GetLength(1) - 1 || kolonkiNomer < 0) Console.WriteLine($"Элемент с индексом Массив[{ctrokiNomer},{kolonkiNomer}] в массиве отсутствует");

    int elementNaiden = 0;

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if(i == ctrokiNomer && j == kolonkiNomer)
            {
                Console.WriteLine($"Значение элеметна с индексом Масссив[{ctrokiNomer},{kolonkiNomer}] = {massiv[i,j]}");
                elementNaiden = 1;
                break;
            }
        }
        if (elementNaiden == 1) break;
    }
}

Console.WriteLine("Введите номер строки элемента массива");
int nomerCtroki = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента массива");
int nomerCtolbca = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

PoiskZnacheniyaElementaPoIndekcamMassiva(nomerCtroki, nomerCtolbca);
*/
//==============================================================================================================================================
// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
void PodschetCrednegoArifmeticheskogoCtolbcov()
{
    Random random = new Random();
    int[,] massiv = new int[random.Next(1,11),random.Next(1,11)];

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i,j] = random.Next(1,10);
            Console.Write($"[{j}]{massiv[i,j]} ");
        }
        
        Console.WriteLine();
    }

    double summaCtolbcov = 0;
    double sredneeArifmeticheskoe = 0;
    
    Console.Write("Среднее арифметическое столбцов ");

    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        summaCtolbcov = 0;
        sredneeArifmeticheskoe = 0;

        for (int i = 0; i < massiv.GetLength(0); i++)
        {
            
            summaCtolbcov = summaCtolbcov + massiv[i,j];
        }
        sredneeArifmeticheskoe = Math.Round((summaCtolbcov / massiv.GetLength(0)), 2);
        Console.Write($"[{j}] = {sredneeArifmeticheskoe}, ");
    }

}

PodschetCrednegoArifmeticheskogoCtolbcov();
*/
//=================================================================================================================================================