﻿//=================================================================================================================
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите первое число для проверки какое больше");
int ChisloPervoe = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число для проверки какое больше");
int ChisloVtoroe = Convert.ToInt32(Console.ReadLine());

if(ChisloPervoe > ChisloVtoroe)
{
    Console.WriteLine("Первое число больше");
}
else if(ChisloPervoe == ChisloVtoroe)
    {
        Console.WriteLine("Вы ввели одинаковые числа");
    }
    else
    {
        Console.WriteLine("Второе число больше");
    }
*/
//===========================================================================================================
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите первое число для проверки какое больше");
int ChisloPervoe = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число для проверки какое больше");
int ChisloVtoroe = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число для проверки какое больше");
int ChisloTretee = Convert.ToInt32(Console.ReadLine());

if (ChisloPervoe==ChisloVtoroe && ChisloVtoroe==ChisloTretee)
{
    Console.WriteLine("Введены одинаковые числа");
}
else if (ChisloPervoe > ChisloVtoroe)
    {
        if (ChisloPervoe > ChisloTretee)
        {
            Console.WriteLine("Первое число максимальное");
        }
    }   else if (ChisloVtoroe > ChisloTretee)
            {
                Console.WriteLine("Второе число максимальное");
            }
    
            else
            {
                Console.WriteLine("Третье число максимальное");
            }
*/
//=================================================================================================
// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число для проверки его на чётность");
int Chislo = Convert.ToInt32(Console.ReadLine());

if(Chislo % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}
*/
//======================================================================================================
// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Введите число для вывода всех чётных чисел от 1 до этого числа");
int Chislo = Convert.ToInt32(Console.ReadLine());

int index = 1;

while(index <= Chislo)
{
    if(index % 2 == 0)
    {
        Console.Write(index + " ");
        index = index + 1;
    }
    else
    {
        index = index + 1;
    }
}
*/
//==================================================================================================================
// Работа в гурппах семинар 2
//Задача
/*
int number = new Random().Next(100, 999);
Console.WriteLine(number);

//Решение 1
int newNumber = ((number / 100) * 10) + (number % 10);
Console.WriteLine(newNumber);

// Решение 2
string newNumber1 = Convert.ToString((number / 100));
Console.WriteLine(newNumber1);
string newNumber2 = Convert.ToString(number % 10);
Console.WriteLine(newNumber2);

string numberRezult = newNumber1 + newNumber2;

Console.WriteLine(numberRezult);
*/

//Задача
/*
int n1 = new Random().Next(1, 1000);
int n2 = new Random().Next(2, 4);
int temp = n1;

if(n1 < n2)
{
    n1 = n2;
    n2 = temp;
}

if (n1 % n2 == 0)
{
    Console.WriteLine($"Число {n1} число кратно {n2}");
}
else
{
    Console.WriteLine($"Число {n1} не кратно {n2}");
}
*/
//================================================================================================================
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Решение с методом
/*void MetodVivodaVtoroiCifriTrehznachnogoChisla (int Chislo)
{
    if(Chislo>=100 && Chislo<=999)
    {
        int OstatokDelenie = (Chislo % 100);
        int VtorayaCifra = (OstatokDelenie / 10);

        Console.WriteLine($"Вторя цифра трёхзначного числа равна {VtorayaCifra}");
    }
    else
    {
        Console.WriteLine("Вы ввели не трёхзначное число");
    }
}

Console.WriteLine("Введител трёхзначное число");
int Chislo = Convert.ToInt32(Console.ReadLine());

MetodVivodaVtoroiCifriTrehznachnogoChisla(Chislo);
*/



// Решение без метода
/*
Console.WriteLine("Введител трёхзначное число");
int Chislo = Convert.ToInt32(Console.ReadLine());

if(Chislo>=100 && Chislo<=999)
{
    int OstatokDelenie = (Chislo % 100);
    int VtorayaCifra = (OstatokDelenie / 10);

    Console.WriteLine($"Вторя цифра трёхзначного числа равна {VtorayaCifra}");
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}
*/

//===============================================================================================================
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int MetodPodschetaKolichestvaCifrChisla(int Chislo)
{
    int KolichestvoCifr = 0;

    while(Chislo > 0)
    {
        Chislo = Chislo / 10;
        KolichestvoCifr = KolichestvoCifr + 1;
    }

    return KolichestvoCifr;
}

Console.WriteLine("Введите число");
int Chislo = Convert.ToInt32(Console.ReadLine());
int KolichestvoCifr = MetodPodschetaKolichestvaCifrChisla(Chislo);
Console.WriteLine($"кол цифр {KolichestvoCifr}");
int TretiyaCifra = 0;

if(KolichestvoCifr == 3)
{
    TretiyaCifra = Chislo % 10;

    Console.WriteLine($"Третья цифра введённого числа {TretiyaCifra}");
}
else if(KolichestvoCifr > 3)
    {
        while(KolichestvoCifr > 3)
        {
            Chislo = Chislo / 10;
            KolichestvoCifr = KolichestvoCifr - 1;
        }

        TretiyaCifra = Chislo % 10;

        Console.WriteLine($"Третья цифра введённого числа {TretiyaCifra}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет у введённого числа");
    }
*/
//==========================================================================================================
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*Console.WriteLine("Введите номер дня недели");
int NomerNedeli = Convert.ToInt32(Console.ReadLine());

switch(NomerNedeli)
{
    case 1:
    {
        Console.WriteLine("Нет... понедельник не выходной");
        break;
    }
    case 2:
    {
        Console.WriteLine("Нет... вторник не выходной");
        break;
    }
    case 3:
    {
        Console.WriteLine("Нет... среда не выходной");
        break;
    }
    case 4:
    {
        Console.WriteLine("Нет... четверг не выходной");
        break;
    }
    case 5:
    {
        Console.WriteLine("Нет... пятница не выходной");
        break;
    }
    case 6:
    {
        Console.WriteLine("Да... суббота выходной");
        break;
    }
    case 7:
    {
        Console.WriteLine("Да... воскресенье выходной");
        break;
    }
    default:
    {
        Console.WriteLine("Такого номера дня недели нет");
        break;
    }
}
*/
//=====================================================================================================
// работа на семинаре 3.
// Задача. Написать программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int GetQuart(double xPoint, double yPoint)
{
    if(xPoint > 0 && yPoint > 0) return 1;
    if(xPoint < 0 && yPoint > 0) return 2;
    if(xPoint < 0 && yPoint < 0) return 3;
    if(xPoint > 0 && yPoint < 0) return 4;
    return 0;
}
double x, y;
int quartNum;
Console.Write("Input X: ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y: ");
y = Convert.ToDouble(Console.ReadLine());

quartNum = GetQuart(x, y);
if(quartNum == 0) Console.WriteLine("Нельзя однозначно определить четверть");
else Console.WriteLine("Данная точка находится в " + quartNum + " четверти");
*/
//========================================================================================
// Задача. Написать программу, которая принимает на вход номер четверти и выводит на экран диапазон координат, доступных в этой четверти

/*if(numChetvert == 1) Console.WriteLine("Можно ввести х > 0 и у > 0");
    if(numChetvert == 2) Console.WriteLine("Можно ввести х > 0 и у < 0");
    if(numChetvert == 3) Console.WriteLine("Можно ввести х < 0 и у < 0");
    if(numChetvert == 4) Console.WriteLine("Можно ввести х < 0 и у > 0");
    if()

*/
/*
void NomerChetverti(int numChetvert)
{
    switch(numChetvert)
    {
        case 1:
        {
            Console.WriteLine("Можно ввести х > 0 и у > 0");
            break;
        }
        case 2:
        {
            Console.WriteLine("Можно ввести х < 0 и у > 0");
            break;
        }
        case 3:
        {
            Console.WriteLine("Можно ввести х < 0 и у < 0");
            break;
        }
        case 4:
        {
            Console.WriteLine("Можно ввести х > 0 и у < 0");
            break;
        }
        default:
        {
            Console.WriteLine("Не пиши ерунды");
            break;
        }
    }    
}

Console.WriteLine("Введите номер четверти");
int Chetvert = Convert.ToInt32(Console.ReadLine());
NomerChetverti(Chetvert);
*/
//============================================================================================================
// Задача. Написать программу, принимающую на вход координаты двух точек и определяющую расстояние между ними.
/*
int MetodRasstoyaniyaMegduDvumyaTochkami(int Ax, int Ay, int )


Console.WriteLine("Введите координаты x и y первой точки");
int koordinataAx =Convert.ToInt32(Console.ReadLine());
int koordinataAy =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x и y второй точки");
int koordinataBx =Convert.ToInt32(Console.ReadLine());
int koordinataBy =Convert.ToInt32(Console.ReadLine());
*/
// Решение с преподавателем
/*
double GetDistance(double x1, double y1, double x2, double y2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double rusult = Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2));
    return rusult;
}


double xA, yA, xB, yB;
//double distance;

Console.Write("Input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X of point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetDistance(xA, yA, xB, yB));
*/
//======================================================================================================
// Задачи ДЗ с семинара 3

// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите пятизначное число");
int Chislo = Convert.ToInt32(Console.ReadLine());
int CifraCpavа = 0;
int CifraClevа = 0;

CifraCpavа = Chislo % 10;
CifraClevа = Chislo / 10000;
if(CifraCpavа == CifraClevа)
{
    CifraCpavа = (Chislo % 100) / 10;
    CifraClevа = (Chislo / 1000) % 10;
    if(CifraCpavа == CifraClevа)
    {
        Console.WriteLine("Введённое число является полиндромом");
    }
    else
    {
        Console.WriteLine("Введённое число не является полиндромом");
    }
}
else
{
    Console.WriteLine("Введённое число не является полиндромом");
}
*/
//========================================================================================================
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// ввести 001222 для проверки будет 3
/*
double RasstoyanieMegduDvumyaTochkami3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xRasstoyanie = x2 - x1;
    double yRasstoyanie = y2 - y1;
    double zRasstoyanie = z2 - z1;
    double ruzultat = Math.Sqrt(Math.Pow(xRasstoyanie,2) + Math.Pow(yRasstoyanie,2) + Math.Pow(zRasstoyanie,2));
    return ruzultat;
}

double xA, yA, zA, xB, yB, zB;

Console.Write("Введите координату х точки A ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y точки A ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z точки A ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х точки B ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y точки B ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z точки B ");
zB = Convert.ToDouble(Console.ReadLine());


Console.WriteLine(RasstoyanieMegduDvumyaTochkami3D(xA, yA, zA, xB, yB, zB));
*/
//==============================================================================================
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.WriteLine("Введите число для вывода таблицы кубов чисел от 1 до этого числа");
int Chislo = Convert.ToInt32(Console.ReadLine());
int index = 1;
int kubChisla = 1;

while(index <= Chislo)
{
    kubChisla = Convert.ToInt32(Math.Pow(index,3));
    Console.Write(kubChisla + " ");
    index = index + 1;
}
*/
//=================================================================================================================
// Задача на каникулах. Пользователь вводит целые числа до тех пор, пока не введёт ноль. Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел. А теперь самое интересное: создавать массивы в процессе решения запрещено.
/*
int Min; 
int MinPlus;
int MaxMinus;
int Max;
int vremennaya;
int index = 1;

Console.WriteLine("Введите число последовательности");
vremennaya = Convert.ToInt32(Console.ReadLine());
Min = vremennaya;
MinPlus = vremennaya;
MaxMinus = vremennaya;
Max = vremennaya;

while(true)
{
    Console.WriteLine("Введите число последовательности");
    vremennaya = Convert.ToInt32(Console.ReadLine());

    if(vremennaya == 0) break;
    index = index + 1;
    
    if(vremennaya > Max)
    {
        MaxMinus = Max;
        Max = vremennaya;
    } 
    
    if(vremennaya < Min)
    {
        MinPlus = Min;
        Min = vremennaya;
    }
}

if(index == 1)
{
    Console.WriteLine("Ввели чисел последовательности меньше двух");
}
else if(index == 2)
    {
        Console.WriteLine($"Минимальное {Min} и максимальное {Max}");
    }
    else
    {
        Console.WriteLine($"Минимальные два {Min} и {MinPlus} максимальные два {MaxMinus} и {Max}");
    }
*/
//===============================================================================================================
