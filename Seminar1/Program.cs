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
//==================================================================================================================
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
//=======================================================================================================
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
//========================================================================================================
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
// Задачи с семинара 4 
//===============================================================================================================
// Задача. Напишите программу которая принимает на вход число и выдаёт количество цифр в числе.
//Вариант 1
/*
void MetodPodschetaKolichestvaCifrChisla(int Chislo)
{
    int KolichestvoCifr = 0;

    if (Chislo == 0) 
    {
        KolichestvoCifr = 1;
        Console.WriteLine($"Количество цифр в введённом числе {KolichestvoCifr}");
    }
    else
    {
        while(Math.Abs(Chislo) > 0)
        {
            Chislo = Chislo / 10;
            KolichestvoCifr = KolichestvoCifr + 1;
        }

        Console.WriteLine($"Количество цифр в введённом числе {KolichestvoCifr}");
    }
    
}

Console.WriteLine("Введите число");
int Chislo = Convert.ToInt32(Console.ReadLine());
MetodPodschetaKolichestvaCifrChisla(Chislo);
*/
//Вариант 2
/*
void MetodPodschetaKolichestvaCifrChisla(int Chislo)
{
    //нужно сделать дополнительное условие когда вводят ноль так как условие цикла не работает и возвращает 1 потом
    int KolichestvoCifr = 1; 

    while(Math.Abs(Chislo / 10) > 0)
    {
        Chislo = Chislo / 10;
        KolichestvoCifr = KolichestvoCifr + 1;
    }

    Console.WriteLine($"Количество цифр в введённом числе {KolichestvoCifr}");
}

Console.WriteLine("Введите число");
int Chislo = Convert.ToInt32(Console.ReadLine());
MetodPodschetaKolichestvaCifrChisla(Chislo);
*/
//==========================================================================================================
// Задача. Напишите программу которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А. Примечание: Число A считаем натуральным.
/*
int SummaChiselOt1DoA (int ChisloA)
{
    int rezultat = 0;
    int i = 1;

    while(i <= ChisloA)
    {
        rezultat = rezultat + i;
        i++;
    }
    
    return rezultat;
}

Console.WriteLine("Введите целое число");
int Chislo = Convert.ToInt32(Console.ReadLine());
if(Chislo < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Сумма чисел от 1 до {Chislo} равна {SummaChiselOt1DoA(Chislo)}");
*/
//================================================================================================================
// Задача. Напишите программу которая принимает на вход число (N) и выдаёт произведение чисел от 1 до N. Примечание: Число N считаем натуральным.
/*
int ProizvedenieChiselOt1DoN (int ChisloN)
{
    int rezultat = 1;
    int i = 1;

    while(i <= ChisloN)
    {
        rezultat = rezultat * i;
        i++;
    }
    
    return rezultat;
}

Console.WriteLine("Введите целое число");
int Chislo = Convert.ToInt32(Console.ReadLine());
if(Chislo < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Произведение чисел от 1 до {Chislo} равно {ProizvedenieChiselOt1DoN(Chislo)}");
*/
//===========================================================================================================
// Задача. Напишите программу которая выводит массив из 8 элементов заполненный нулями и единицами в случайном порядке.
/*
void VivodMassiva8Elementov()
{
    int[] a = new int[8];
    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0,2);
        Console.Write(a[i] + " ");
    }
}

VivodMassiva8Elementov();
*/
//=============================================================================================================
// Решение зада ДЗ с семинара 4
//=============================================================================================================
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
// Задачи с семинара 5
//===============================================================================================================
// Задача. Задать массив из 12 элементов заполненный случайными числами из промежутка от -9 до 9, т.е. массив целых чисел получится. Найти сумму отрицательных и положительных элементов массива.
// Вариант без функции
/*
int[] Massiv = new int[12];
int SummaPologitelnixElementov = 0;
int SummaOtricatelnixElementov = 0;
for(int i = 0; i < 12; i++)
{
    Massiv[i] = new Random().Next(-9, 10);
    if(Massiv[i] > 0) SummaPologitelnixElementov = SummaPologitelnixElementov + Massiv[i];
    else SummaOtricatelnixElementov = SummaOtricatelnixElementov + Massiv[i];
    Console.Write(Massiv[i] + " ");
}

Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов равна {SummaPologitelnixElementov}. Сумма отрицательных элементов равна {SummaOtricatelnixElementov}");
*/
// Вариант c функцией
/*
void SummaPologitelnixOtricatelnixElementov()
{
    int[] Massiv = new int[12];
    int SummaPologitelnixElementov = 0;
    int SummaOtricatelnixElementov = 0;
    for(int i = 0; i < 12; i++)
    {
        Massiv[i] = new Random().Next(-9, 10);
        if(Massiv[i] >= 0) SummaPologitelnixElementov = SummaPologitelnixElementov + Massiv[i];
        else SummaOtricatelnixElementov = SummaOtricatelnixElementov + Massiv[i];
        Console.Write(Massiv[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных элементов равна {SummaPologitelnixElementov}. Сумма отрицательных элементов равна {SummaOtricatelnixElementov}");
}

SummaPologitelnixOtricatelnixElementov();
*/
//===============================================================================================================
// Задача. Перевернуть элементы массива, только не по порядку а по знаку. Например -5 должно стать 5, минус 18 должно стать 18 и т. д. т. е. пройтись по массиву и в каждом элементе заменить знак.
/*
int[] Massiv = new int[12];

for(int i = 0; i < 12; i++)
{
    Massiv[i] = new Random().Next(-9, 10);
    Console.Write(Massiv[i] + " ");
}

Console.WriteLine();

for(int i = 0; i < 12; i++)
{
    Console.Write(Massiv[i]*(-1) + " ");
}
*/
//===============================================================================================================
// Задача. Задать произвольный массив. Необходимо написать программу которая позволяет пользователю ввести число и выводить да если это число присутствует в массиве или нет если его там нет.
/*
int[] Massiv = new int[15];
int PerekluchatelChisloNaideno = 0;

for(int i = 0; i < 15; i++)
{
    Massiv[i] = new Random().Next(1,16);
    Console.Write(Massiv[i] + " ");    
}

Console.WriteLine();
Console.WriteLine("Введите число для проверки наличия в массиве");
int Chislo = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < 15; i++ )
{
    if(Massiv[i] == Chislo) 
    {
        Console.WriteLine($"Да... число {Chislo} в массиве присутствует");
        PerekluchatelChisloNaideno = 1;
        break;
    }
}

if(PerekluchatelChisloNaideno == 0) Console.WriteLine($"Нет... число {Chislo} в массиве отсутствует");
*/
//==============================================================================================================
// Задача. Необходимо создать одномерный массив из 123 случайных чисел и необходимо найти количество элементов которые лежать в отрезке от 10 до 99. Имеется ввиду не индекс элементов а само значение элементов.
/*
int[] Massiv = new int[123];
int KolichestvoElementov = 0;

for(int i = 0; i < 123; i++)
{
    Massiv[i] = new Random().Next(1,1000);
    if(Massiv[i] >= 10 && Massiv[i] <= 99) KolichestvoElementov = KolichestvoElementov +1;
}

Console.WriteLine($"Количество элементов массива на отрезке от [10,99] равно {KolichestvoElementov}");
*/
//==================================================================================================================
// Задача. Необходимо найти произведение пар элементов в массиве по принципу полиндромов сначала первого и последнего и далее идём внутрь т.е. второго и предпоследнего. Если количество нечётное то у серединного пары нет его тогда просто плюсуем. И все суммы каждой пары нужно будет помещать в новый массив, а нечётный нужно будет поместить без пары просто в элемент его.
//Вариант 1
/*
Console.WriteLine("Введите длинну массива");
int DlinaMassiva = Convert.ToInt32(Console.ReadLine());
int[] Massiv = new int[DlinaMassiva];
int NechetnijElement = 1;
if(DlinaMassiva % 2 == 0) NechetnijElement = 0;
int[] MassivProizvedenij = new int[(DlinaMassiva / 2) + NechetnijElement];

for(int i = 0; i < DlinaMassiva; i++)
{
    Massiv[i] = i + 1;
    Console.Write(Massiv[i] + " ");
}

Console.WriteLine();

for(int i = 0; i < ((DlinaMassiva / 2) + NechetnijElement); i++)
{
    if(i == DlinaMassiva - 1 - i)
    {
        MassivProizvedenij[i] = Massiv[i];
        Console.Write(MassivProizvedenij[i] + " ");
        break;
    }
    MassivProizvedenij[i] = Massiv[i] * Massiv[DlinaMassiva - 1 - i];
    Console.Write(MassivProizvedenij[i] + " ");
}
*/
//Вариант 2
/*
Console.WriteLine("Введите длинну массива");
int DlinaMassiva = Convert.ToInt32(Console.ReadLine());
int[] Massiv = new int[DlinaMassiva];
int NechetnijElement = 1;
if(DlinaMassiva % 2 == 0) NechetnijElement = 0;
int[] MassivProizvedenij = new int[(DlinaMassiva / 2) + NechetnijElement];

for(int i = 0; i < DlinaMassiva; i++)
{
    Massiv[i] = i + 1;
    Console.Write(Massiv[i] + " ");
}

Console.WriteLine();

for(int i = 0; i < ((DlinaMassiva / 2) + NechetnijElement); i++)
{
    MassivProizvedenij[i] = Massiv[i] * Massiv[DlinaMassiva - 1 - i];
    if(i == DlinaMassiva - 1 - i) MassivProizvedenij[i] = Massiv[i];
    Console.Write(MassivProizvedenij[i] + " ");
}
*/
//Вариант 3
/*
Console.WriteLine("Введите длинну массива");
int DlinaMassiva = Convert.ToInt32(Console.ReadLine());
int[] Massiv = new int[DlinaMassiva];
int NechetnijElement = 0;
if(DlinaMassiva % 2 != 0) NechetnijElement = 1;
int[] MassivProizvedenij = new int[(DlinaMassiva / 2) + NechetnijElement];

for(int i = 0; i < DlinaMassiva; i++)
{
    Massiv[i] = i + 1;
    Console.Write(Massiv[i] + " ");
}

Console.WriteLine();

for(int i = 0; i < (DlinaMassiva / 2); i++)
{
    MassivProizvedenij[i] = Massiv[i] * Massiv[DlinaMassiva - 1 - i];
    Console.Write(MassivProizvedenij[i] + " ");
}

if(NechetnijElement == 1) MassivProizvedenij[DlinaMassiva / 2] = Massiv[DlinaMassiva / 2];
Console.Write(MassivProizvedenij[DlinaMassiva / 2] + " ");
*/
//===================================================================================================================================
// Решение задач ДЗ с семинара 5
//====================================================================================================================================
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
/*
double RaznicaMegduMaximalnimMinimalnimElenentomMassiva()
{
    double[] Massiv = new double[10];
    double MaximalnijElement = Massiv[0];
    double ManimalnijElement = Massiv[0];
    double RaznicaMaxMin = 0;

    for(int i = 0; i < 10; i++)
    {
        Massiv[i] = new Random().Next(-10,11);
        Console.Write(Massiv[i] + " ");
    }

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
//==============================================================================================================================================