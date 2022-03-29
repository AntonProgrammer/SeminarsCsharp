//===========================================================================================================================================
// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int KolichestvoChetnixChiselMassiva()
{
    int[] Massiv = new int[10];
    int Cchetchik = 0;

    for(int i = 0; i < 10; i++)
    {
        Massiv[i] = new Random().Next(100,1000);
        if (Massiv[i] % 2 == 0) Cchetchik = Cchetchik + 1;
        Console.Write(Massiv[i] + " ");
    }

    Console.WriteLine();
    return Cchetchik;
}

Console.WriteLine($"В массиве чётных чисел {KolichestvoChetnixChiselMassiva()}");
*/
//============================================================================================================================================
// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//Вариант с суммой элементов массива с нечётными позициями
/*
int SummaNechetnixPozicijMassiva()
{
    int[] Massiv = new int[10];
    int SummaNechetnixPozicij = 0;

    for(int i = 0; i < 10; i++)
    {
        Massiv[i] = new Random().Next(1,11);
        Console.Write(Massiv[i] + " ");
    }

    for(int i = 0; i < 10; i++)
    {
        if(i % 2 == 0) SummaNechetnixPozicij = SummaNechetnixPozicij + Massiv[i];
    }
    Console.WriteLine();
    return SummaNechetnixPozicij;
}

Console.WriteLine($"Сумма элементов массива с нечётными позициями равна {SummaNechetnixPozicijMassiva()}");
*/
//Вариант с суммой элементов массива с нечётными индексами================================================================================
/*
int SummaNechetnixIndeksovMassiva()
{
    int[] Massiv = new int[10];
    int SummaNechetnixIndeksov = 0;

    for(int i = 0; i < 10; i++)
    {
        Massiv[i] = new Random().Next(1,11);
        Console.Write(Massiv[i] + " ");
    }

    for(int i = 0; i < 10; i++)
    {
        if(i % 2 != 0) SummaNechetnixIndeksov = SummaNechetnixIndeksov + Massiv[i];
    }
    Console.WriteLine();
    return SummaNechetnixIndeksov;
}

Console.WriteLine($"Сумма элементов массива с нечётными интексами равна {SummaNechetnixIndeksovMassiva()}");
*/
//===================================================================================================================================
// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Вариант 1
/*
double RaznicaMegduMaximalnimMinimalnimElenentomMassiva()
{
    double[] Massiv = new double[10];
    double RaznicaMaxMin = 0;

    for(int i = 0; i < 10; i++)
    {
        Massiv[i] = new Random().Next(1,100);
        Console.Write(Massiv[i] + " ");
    }

    double MaximalnijElement = Massiv[0];
    double ManimalnijElement = Massiv[0];
    Console.WriteLine();

    for(int i = 0; i < 10; i++)
    {
        if (Massiv[i] > MaximalnijElement) MaximalnijElement = Massiv[i];
    }

    Console.WriteLine($"Максимальный элемент равен {MaximalnijElement}");
   // Console.WriteLine();

    for(int i = 0; i < 10; i++)
    {
        if (Massiv[i] < ManimalnijElement) ManimalnijElement = Massiv[i];
    }

    Console.WriteLine($"Минимальный элемент равен {ManimalnijElement}");
    //Console.WriteLine();

    return RaznicaMaxMin = MaximalnijElement - ManimalnijElement;
}

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {RaznicaMegduMaximalnimMinimalnimElenentomMassiva()}");
*/
// Вариант 2===========================================================================================================================
/*
void ZapolnenieMassiva(double[] massivZapolnenij)
{
    for(int i = 0; i < 10; i++)
    {
        Random random = new Random();
        massivZapolnenij[i] = 1000 * random.NextDouble();
        Console.Write(massivZapolnenij[i] + " ");
    }
}

void RaznicaMaxMin(double[] massivRaznicaMinMax)
{
    double min = double.MaxValue, max = double.MinValue;

    for(int i = 0; i < 10; i++)
    {
        if (massivRaznicaMinMax[i] < min) min = massivRaznicaMinMax[i];
        if (massivRaznicaMinMax[i] > max) max = massivRaznicaMinMax[i];
    }

    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {max - min}");;
}

double[] massiv = new double[10];
ZapolnenieMassiva(massiv);
Console.WriteLine();
RaznicaMaxMin(massiv);
*/
//==============================================================================================================================================