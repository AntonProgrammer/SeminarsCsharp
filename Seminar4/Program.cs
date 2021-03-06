//================================================================================================================
// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Вариант 1
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
// Вариант 2====================================================================================================
/*
void VozvedenitChislaCtepen(int ChisloA, int CtepenB) // здесь формулировка задачи что два натуральных числа A и B
{
    if (ChisloA < 1 || CtepenB < 1) 
    {
        Console.WriteLine("Вы ввели ненатуральное число и степень");
    }
    else
    {
        int rezultat = 1;

        for (int i = 0; i < CtepenB; i++)
        {
            rezultat = rezultat * ChisloA;
        }

        Console.WriteLine($"Число {ChisloA} в степени {CtepenB} равно {rezultat}");
    }
}

Console.WriteLine("Введите число");
int Chislo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень в которую нужно возвести число");
int Ctepen = Convert.ToInt32(Console.ReadLine());

VozvedenitChislaCtepen(Chislo,Ctepen);
*/
//============================================================================================================
// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Вариант 1
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
// Вариант 2===========================================================================================================================
/*
int chislo = 74;

void SummaCifrChisla(int chisloSummaCifr)
{
    string chisloString = Convert.ToString(chisloSummaCifr);
    int summaCifrChisla = 0;

    for (int i = 0; i < chisloString.Length; i++)
    {
        summaCifrChisla = summaCifrChisla + (int)char.GetNumericValue(chisloString,i);
    }

    Console.WriteLine(summaCifrChisla);
}

SummaCifrChisla(chislo);
*/
// Вариант 3==========================================================================================================================
/*
void SummaCifrChisla(int chisloSummaCifr)
{
    string chisloString = Convert.ToString(chisloSummaCifr);
    int summaCifrChisla = 0;

    for (int i = 0; i < chisloString.Length; i++)
    {
        summaCifrChisla = summaCifrChisla + Convert.ToInt32($"{chisloString[i]}");  //(int)char.GetNumericValue(chisloString,i) или для массива (int)char.GetNumericValue(chisloString);
    }

    Console.WriteLine(summaCifrChisla);
}

Console.WriteLine("Введите число для подсчёта суммы цифр числа");
int chislo = Convert.ToInt32(Console.ReadLine());
SummaCifrChisla(chislo);
*/
// Вариант 4===========================================================================================================================
/*
void SummaCifrChisla(string chisloSummaCifr)
{
    int summaCifrChisla = 0;

    for (int i = 0; i < chisloSummaCifr.Length; i++)
    {
        summaCifrChisla = summaCifrChisla + (int)char.GetNumericValue(chisloSummaCifr,i);
    }

    Console.WriteLine(summaCifrChisla);
}

Console.WriteLine("Введите число для подсчёта суммы цифр числа");
int chislo = Convert.ToInt32(Console.ReadLine()); // сразу в string Console.ReadLine() записать даёт но с комментарием и подчёркиванием
string chisloString = Convert.ToString(chislo);
SummaCifrChisla(chisloString);
*/
// Вариант 5===========================================================================================================================
/*
void SummaCifrChisla(string chisloSummaCifr)
{
    int summaCifrChisla = 0;

    for (int i = 0; i < chisloSummaCifr.Length; i++)
    {
        summaCifrChisla = summaCifrChisla + (int)char.GetNumericValue(chisloSummaCifr,i);
    }

    Console.WriteLine(summaCifrChisla);
}

Console.WriteLine("Введите число для подсчёта суммы цифр числа");
string chislo = Console.ReadLine();
SummaCifrChisla(chislo);
*/
// Вариант 6================================================================================================================================
/*
void SummaCifrChisla(char[] chisloSummaCifr)
{
    int summaCifrChisla = 0;

    for (int i = 0; i < chisloSummaCifr.Length; i++)
    {
        summaCifrChisla = summaCifrChisla + Convert.ToInt32(Convert.ToString(chisloSummaCifr[i]));
    }

    Console.WriteLine(summaCifrChisla);
}

Console.WriteLine("Введите число для подсчёта суммы цифр числа");
string chislo = Console.ReadLine();
char[] chisloChar = chislo.ToCharArray();

SummaCifrChisla(chisloChar);
*/
// Вариант 7 не решённый======================================================================================
/*
void SummaCifrChisla(string chisloSummaCifr)
{
    int summaCifrChisla = 0;

    for (int i = 0; i < chisloSummaCifr.Length; i++)
    {
        summaCifrChisla = summaCifrChisla + Convert.ToInt32(chisloSummaCifr[i]); // не работает конверт возможно проблема с кодом ASC2
    }

    Console.WriteLine(summaCifrChisla);
}

string chislo = "108";
SummaCifrChisla(chislo);
*/
//======================================================================================================================================
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