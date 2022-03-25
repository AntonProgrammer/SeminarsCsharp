//================================================================================================================
// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int VozvedenitChislaCtepen (int ChisloA, int CtepenB)
{
    int rezultat = 1;
    for (int i = 0; i < CtepenB; i++)
    {
        rezultat = rezultat * ChisloA;
    }

    return rezultat;
}

Console.WriteLine("Введите число");
int Chislo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень в которую нужно возвести число");
int Ctepen = Convert.ToInt32(Console.ReadLine());
if (Ctepen < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Число {Chislo} в степени {Ctepen} равно {VozvedenitChislaCtepen(Chislo,Ctepen)}");
*/
//============================================================================================================
// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SummaCifrChisla(int ChisloA)
{
    int rezultat = 0;
    ChisloA = Math.Abs(ChisloA);

    while(ChisloA > 0)
    {
        rezultat = rezultat + (ChisloA % 10);
        ChisloA = ChisloA / 10;
    }

    return rezultat;
}

Console.WriteLine("Введите число");
int Chislo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр введённого числа {Chislo} равна {SummaCifrChisla(Chislo)}");
*/
//=============================================================================================================
// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
void Massiv8Elementov()
{
    int[] Massiv = new int[8];
    for(int i = 0; i < 8; i++)
    {
        Random CluchainoeChislo = new Random();
        Massiv[i] = CluchainoeChislo.Next();
        Console.Write(Massiv[i] + " ");
    }
}

Massiv8Elementov();
*/
//================================================================================================================