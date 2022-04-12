//========================================================================================================================================================
// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Вариант 1 Сартировка по возрастанию
/*
int[,] CozdanieMassiva()
{
    Random random = new Random();
   
    int[,] massiv = new int[random.Next(1, 5), random.Next(1, 5)];

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i,j] = random.Next(1,9);
        }
    }

    return massiv;
}

void Print2DMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i,j]} ");
        }

        Console.WriteLine();
    }
}

int[,] SortirovkaStrokMassiva(int[,] massiv)
{
    int tmp = 0;
        
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        int indexMinI = i;
        int indexMinJ = 0;

        for (int j = 0; j < massiv.GetLength(1) - 1; j++)
        {   
            indexMinI = i;
            indexMinJ = j;
            for (int k = j + 1; k < massiv.GetLength(1); k++)
            {
                 
                if(massiv[i,k] < massiv[indexMinI,indexMinJ])
                {
                    indexMinI = i;
                    indexMinJ = k;
                }
            }

            tmp = massiv[i,j];
            massiv[i,j] = massiv[indexMinI,indexMinJ];
            massiv[indexMinI,indexMinJ] = tmp;
            
        }

    }

    return massiv;
}

int[,] massivNaIzmenenie = CozdanieMassiva();

Print2DMassiv(massivNaIzmenenie);
Console.WriteLine();
Print2DMassiv(SortirovkaStrokMassiva(massivNaIzmenenie));
*/
// Вариант 2 Сартировка по убыванию==========================================================================================================
/*
int[,] CozdanieMassiva()
{
    Random random = new Random();
   
    int[,] massiv = new int[random.Next(1, 5), random.Next(1, 5)];

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i,j] = random.Next(1,9);
        }
    }

    return massiv;
}

void Print2DMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i,j]} ");
        }

        Console.WriteLine();
    }
}

int[,] SortirovkaStrokMassiva(int[,] massiv)
{
    int tmp = 0;
        
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        int indexMinI = i;
        int indexMinJ = 0;

        for (int j = 0; j < massiv.GetLength(1) - 1; j++)
        {   
            indexMinI = i;
            indexMinJ = j;
            for (int k = j + 1; k < massiv.GetLength(1); k++)
            {
                 
                if(massiv[i,k] > massiv[indexMinI,indexMinJ])
                {
                    indexMinI = i;
                    indexMinJ = k;
                }
            }

            tmp = massiv[i,j];
            massiv[i,j] = massiv[indexMinI,indexMinJ];
            massiv[indexMinI,indexMinJ] = tmp;
            
        }

    }

    return massiv;
}

int[,] massivNaIzmenenie = CozdanieMassiva();

Print2DMassiv(massivNaIzmenenie);
Console.WriteLine();
Print2DMassiv(SortirovkaStrokMassiva(massivNaIzmenenie));
*/
//===========================================================================================================================================
// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CozdanieDvemernogoMassiva()
{
    Random random = new Random();

    int[,] massiv = new int[random.Next(1,10),random.Next(1,5)]; // { { 9, 1, 2 }, { 1, 8, 3 }, { 5, 1, 10 }, { 6, 3, 3 } };//

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i,j] = random.Next(1,10);
        }
    }

    return massiv;
}

void Pechat2DMassiva(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]} ");
        }

        Console.WriteLine();
    }
}

void NaxogdenieMinSummiElementovCtroki(int[,] massiv)
{
    int summaElementov = int.MaxValue;
    int summaElementovTmp = 0;
    int minCtroka = 0;
    int kolichestvoMinCtrokBolwe1 = 0;

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        summaElementovTmp = 0;
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            summaElementovTmp = summaElementovTmp + massiv[i, j];
        }
        if (summaElementovTmp < summaElementov)
        {
            summaElementov = summaElementovTmp;
            minCtroka = i;
        }
    }

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        summaElementovTmp = 0;
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            summaElementovTmp = summaElementovTmp + massiv[i, j];
        }
        if (summaElementovTmp == summaElementov) kolichestvoMinCtrokBolwe1 = 1;
    }

    if (kolichestvoMinCtrokBolwe1 == 1)
    {
        for (int i = 0; i < massiv.GetLength(0); i++)
        {
            summaElementovTmp = 0;
            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                summaElementovTmp = summaElementovTmp + massiv[i, j];
            }
            if (summaElementovTmp == summaElementov)
            {
                summaElementov = summaElementovTmp;
                minCtroka = i;
                Console.Write($"Строка[{minCtroka}] ");
            }
            else if (kolichestvoMinCtrokBolwe1 == 0) Console.WriteLine($"Строка[{minCtroka}]");
        }
    }
}

int[,] massivNew = CozdanieDvemernogoMassiva();
Pechat2DMassiva(massivNew);

NaxogdenieMinSummiElementovCtroki(massivNew);

*/
//================================================================================================================================================
// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Вариант 1 для трёхмерного массива
/*
int[,,] Cozdanie3MernogoMassiva()
{
    Random random = new Random();
    int[,,] massiv = new int[random.Next(1, 4), random.Next(1, 4), random.Next(1, 4)];
    Console.WriteLine($"Массив[{massiv.GetLength(0)},{massiv.GetLength(1)},{massiv.GetLength(2)}]");

    int kolichestvoZapolnennix = 0;
    int kolichestvoProverennixElementov = 0;
    int kolichestvoElementov = massiv.GetLength(0) * massiv.GetLength(1) * massiv.GetLength(2);

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(2); k++)
            {
                bool unikalnoeZnachenie;

                kolichestvoZapolnennix++;

                do
                {
                    kolichestvoProverennixElementov = kolichestvoZapolnennix;

                    massiv[i,j,k] = random.Next(1, (massiv.GetLength(0) * massiv.GetLength(1) * massiv.GetLength(2)) + 1);

                    unikalnoeZnachenie = true;

                    for (int l = 0; l < massiv.GetLength(0); l++)
                    {
                        for (int m = 0; m < massiv.GetLength(1); m++)
                        {
                            for (int n = 0; n < massiv.GetLength(2); n++)
                            {
                                kolichestvoProverennixElementov--;

                                if (kolichestvoProverennixElementov == 0) break;
                                if (massiv[i, j, k] == massiv[l, m, n])
                                {
                                    unikalnoeZnachenie = false;
                                    break;
                                }
                            }

                            if (unikalnoeZnachenie == false) break;
                            if (kolichestvoProverennixElementov == 0) break;
                        }

                        if (unikalnoeZnachenie == false) break;
                        if (kolichestvoProverennixElementov == 0) break;
                    }

                    if (kolichestvoProverennixElementov == 0) break;

                } while (!unikalnoeZnachenie);

                if (kolichestvoZapolnennix == kolichestvoElementov) break;
            }

            if (kolichestvoZapolnennix == kolichestvoElementov) break;
        }

        if (kolichestvoZapolnennix == kolichestvoElementov) break;
    }

    return massiv;
}

void Pechat3MernogoMassiva(int[,,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(2); k++)
            {
                Console.Write($"{massiv[i, j, k]}[{i},{j},{k}] ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

Pechat3MernogoMassiva(Cozdanie3MernogoMassiva());
*/
// Вариант 2 для двумерного масссива
/*
int[,] Cozdanie3MernogoMassiva()
{
    Random random = new Random();
    int[,] massiv = new int[random.Next(1, 11), random.Next(1, 11)];
    Console.WriteLine($"Массив[{massiv.GetLength(0)},{massiv.GetLength(1)}]");

    int kolichestvoZapolnennix = 0;
    int kolichestvoProverennixElementov = 0;
    int kolichestvoElementov = massiv.GetLength(0) * massiv.GetLength(1);

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            bool unikalnoeZnachenie;

            kolichestvoZapolnennix++;

            do
            {
                kolichestvoProverennixElementov = kolichestvoZapolnennix;

                massiv[i, j] = random.Next(1, (massiv.GetLength(0) * massiv.GetLength(1)) + 1);

                unikalnoeZnachenie = true;

                for (int l = 0; l < massiv.GetLength(0); l++)
                {
                    for (int m = 0; m < massiv.GetLength(1); m++)
                    {
                        kolichestvoProverennixElementov--;

                        if (kolichestvoProverennixElementov == 0) break;
                        if (massiv[i, j] == massiv[l, m])
                        {
                            unikalnoeZnachenie = false;
                            break;
                        }
                    }

                    if (unikalnoeZnachenie == false) break;
                    if (kolichestvoProverennixElementov == 0) break;
                }

                if (kolichestvoProverennixElementov == 0) break;

            } while (!unikalnoeZnachenie);

            if (kolichestvoZapolnennix == kolichestvoElementov) break;
            if (kolichestvoZapolnennix == kolichestvoElementov) break;
        }

        if (kolichestvoZapolnennix == kolichestvoElementov) break;
    }

    return massiv;
}

void Pechat3MernogoMassiva(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]}[{i},{j}] ");
        }

        Console.WriteLine();
    }
}

Pechat3MernogoMassiva(Cozdanie3MernogoMassiva());
*/
// Вариант 3 для одномерного массива==================================================================================================
/*
int[] Cozdanie3MernogoMassiva()
{
    Random random = new Random();
    int[] massiv = new int[random.Next(1, 11)];
    Console.WriteLine($"Массив[{massiv.GetLength(0)}]");

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        bool unikalnoeZnachenie;

        do
        {
            massiv[i] = random.Next(1, massiv.GetLength(0) + 1);

            unikalnoeZnachenie = true;

            for (int j = 0; j < i; j++)
            {
                if (massiv[i] == massiv[j])
                {
                    unikalnoeZnachenie = false;
                    break;
                }
            }

        } while (!unikalnoeZnachenie);
    }

    return massiv;
}

void Pechat3MernogoMassiva(int[] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        Console.Write($"{massiv[i]}[{i}] ");
    }
}

Pechat3MernogoMassiva(Cozdanie3MernogoMassiva());
*/
//============================================================================================================================================
// Задача 4. Заполните спирально массив 4 на 4.
// Вариант 1 для квадратной матрицы
/*
int[,] CozdanieMassiva()
{
    int[,] massiv = new int[4, 4];

    return massiv;
}

void Print2DMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]} ");
        }

        Console.WriteLine();
    }
}

int[,] ZapolnenieMassivaPoCpirali(int[,] massiv)
{
    int chisloZapolnenie = 1;
    
    for (int cdvig = 0; cdvig < massiv.GetLength(0) - 2; cdvig++)
    {
          for (int i = 0 + cdvig; i < massiv.GetLength(1) - cdvig; i++)
        {
            massiv[0 + cdvig, i] = chisloZapolnenie;
            chisloZapolnenie++;
        }

        chisloZapolnenie--;

        for (int i = 0 + cdvig; i < massiv.GetLength(0) - cdvig; i++)
        {
            massiv[i, 3 - cdvig] = chisloZapolnenie;
            chisloZapolnenie++;
        }

        chisloZapolnenie--;

        for (int i = massiv.GetLength(1) - 1 - cdvig; i >= 0 + cdvig; i--)
        {
            massiv[3 - cdvig, i] = chisloZapolnenie;
            chisloZapolnenie++;
        }

        chisloZapolnenie--;

        for (int i = massiv.GetLength(0) - 1 - cdvig; i >= 1 + cdvig; i--)
        {
            massiv[i, 0 + cdvig] = chisloZapolnenie;
            chisloZapolnenie++;
        }
    }

    return massiv;
}



int[,] massivNaIzmenenie = CozdanieMassiva();

Print2DMassiv(ZapolnenieMassivaPoCpirali(massivNaIzmenenie));
*/
// Вариант 2 для любой двумерной матрицы=================================================================================================
/*
int[,] CozdanieMassiva()
{
    Random random = new Random();

    int[,] massiv = new int[random.Next(1, 10), random.Next(1, 10)];

    return massiv;
}

void Print2DMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]} ");
        }

        Console.WriteLine();
    }
}

int[,] ZapolnenieMassivaPoCpirali(int[,] massiv)
{

    Console.WriteLine($"Массив[{massiv.GetLength(0)},{massiv.GetLength(1)}]");
    int chisloZapolnenie = 1;
    int kolichestvoCdvigov = 0;
    int kolichestvoElementovMassiva = massiv.GetLength(1) * massiv.GetLength(0);
    int counterChisloElementovZapolneniya = 0;

    if (massiv.GetLength(0) < massiv.GetLength(1) && massiv.GetLength(0) % 2 == 0) kolichestvoCdvigov = massiv.GetLength(0) / 2;
    if (massiv.GetLength(1) < massiv.GetLength(0) && massiv.GetLength(1) % 2 == 0) kolichestvoCdvigov = massiv.GetLength(1) / 2;
    if (massiv.GetLength(0) < massiv.GetLength(1) && massiv.GetLength(0) % 2 != 0) kolichestvoCdvigov = (massiv.GetLength(0) / 2) + 1;
    if (massiv.GetLength(1) < massiv.GetLength(0) && massiv.GetLength(1) % 2 != 0) kolichestvoCdvigov = (massiv.GetLength(1) / 2) + 1;
    if (massiv.GetLength(0) == massiv.GetLength(1) && massiv.GetLength(0) % 2 == 0) kolichestvoCdvigov = massiv.GetLength(0) / 2;
    if (massiv.GetLength(0) == massiv.GetLength(1) && massiv.GetLength(0) % 2 != 0) kolichestvoCdvigov = (massiv.GetLength(0) / 2) + 1;

    for (int cdvig = 0; cdvig < kolichestvoCdvigov; cdvig++)
    {
        for (int i = 0 + cdvig; i < massiv.GetLength(1) - cdvig; i++)
        {
            massiv[0 + cdvig, i] = chisloZapolnenie;
            chisloZapolnenie++;
            counterChisloElementovZapolneniya++;
            if (counterChisloElementovZapolneniya == kolichestvoElementovMassiva) break;
        }

        counterChisloElementovZapolneniya--;
        chisloZapolnenie--;

        for (int i = 0 + cdvig; i < massiv.GetLength(0) - cdvig; i++)
        {
            massiv[i, massiv.GetLength(1) - 1 - cdvig] = chisloZapolnenie;
            chisloZapolnenie++;
            counterChisloElementovZapolneniya++;
            if (counterChisloElementovZapolneniya == kolichestvoElementovMassiva) break;
        }

        counterChisloElementovZapolneniya--;
        chisloZapolnenie--;

        for (int i = massiv.GetLength(1) - 1 - cdvig; i >= 0 + cdvig; i--)
        {
            massiv[massiv.GetLength(0) - 1 - cdvig, i] = chisloZapolnenie;
            chisloZapolnenie++;
            counterChisloElementovZapolneniya++;
            if (counterChisloElementovZapolneniya == kolichestvoElementovMassiva) break;
        }

        counterChisloElementovZapolneniya--;
        chisloZapolnenie--;

        for (int i = massiv.GetLength(0) - 1 - cdvig; i >= 1 + cdvig; i--)
        {
            massiv[i, 0 + cdvig] = chisloZapolnenie;
            chisloZapolnenie++;
            counterChisloElementovZapolneniya++;
            if (counterChisloElementovZapolneniya == kolichestvoElementovMassiva) break;
        }

        if (counterChisloElementovZapolneniya == kolichestvoElementovMassiva) break;
    }

    return massiv;
}



int[,] massivNaIzmenenie = CozdanieMassiva();

Print2DMassiv(ZapolnenieMassivaPoCpirali(massivNaIzmenenie));
*/
// Вариант 3 для любой двумерной матрицы=================================================================================================
/*
int[,] CozdanieMassiva()
{
    Random random = new Random();
    int[,] massiv = new int[random.Next(2,10),random.Next(2,10)];

    return massiv;
}

void Print2DMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]} ");
        }

        Console.WriteLine();
    }
}

int[,] ZapolnenieMassivaPoCpirali(int[,] massiv)
{
    int counter = 1;
    int zapolnenieKolonokClevaNapravo = 0;
    int zapolnenieKolonokCpravoNalevo = massiv.GetLength(1) - 1;
    int zapolnenieCtrokCverxuVniz = 0;
    int zapolnenieCtrokCnizuVverx = massiv.GetLength(0) - 1;
    int kolichestvoElementovMassiva = massiv.GetLength(1) * massiv.GetLength(0);
    int counterChisloElementovZapolneniya = 1;

    while (zapolnenieKolonokClevaNapravo <= zapolnenieKolonokCpravoNalevo && zapolnenieCtrokCverxuVniz <= zapolnenieCtrokCnizuVverx)
    {
        if(counterChisloElementovZapolneniya == kolichestvoElementovMassiva) break;

        for (int i = zapolnenieKolonokClevaNapravo; i <= zapolnenieKolonokCpravoNalevo; i++)
        {
            massiv[zapolnenieCtrokCverxuVniz,i] = counter;
            counter++;
            counterChisloElementovZapolneniya++;

        }
        zapolnenieCtrokCverxuVniz++;

        if(counterChisloElementovZapolneniya == kolichestvoElementovMassiva) break;

        for (int i = zapolnenieCtrokCverxuVniz; i <= zapolnenieCtrokCnizuVverx; i++)
        {
            massiv[i,zapolnenieKolonokCpravoNalevo] = counter;
            counter++;
            counterChisloElementovZapolneniya++;
        }
        zapolnenieKolonokCpravoNalevo--;

        if(counterChisloElementovZapolneniya == kolichestvoElementovMassiva) break;

        for (int i = zapolnenieKolonokCpravoNalevo; i >= zapolnenieKolonokClevaNapravo; i--)
        {
            massiv[zapolnenieCtrokCnizuVverx,i] = counter;
            counter++;
            counterChisloElementovZapolneniya++;
        }
        zapolnenieCtrokCnizuVverx--;

        if(counterChisloElementovZapolneniya == kolichestvoElementovMassiva) break;

        for (int i = zapolnenieCtrokCnizuVverx; i >= zapolnenieCtrokCverxuVniz; i--)
        {
            massiv[i,zapolnenieKolonokClevaNapravo] = counter;
            counter++;
            counterChisloElementovZapolneniya++;
        }
        zapolnenieKolonokClevaNapravo++;

        if(counterChisloElementovZapolneniya == kolichestvoElementovMassiva) break;
    }

    Console.WriteLine($"{kolichestvoElementovMassiva}   {counterChisloElementovZapolneniya} ");
    return massiv;
    
}

int[,] massivNaIzmenenie = CozdanieMassiva();

Print2DMassiv(massivNaIzmenenie);
Console.WriteLine();
Print2DMassiv(ZapolnenieMassivaPoCpirali(massivNaIzmenenie));
*/
//================================================================================================================================================