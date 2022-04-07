//=================================================================================================================
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
        else if(xPoint < 0 && yPoint > 0) return 2;
             else if(xPoint < 0 && yPoint < 0) return 3;
                  else if(xPoint > 0 && yPoint < 0) return 4;
                       else return 0;
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
// Задача. Найдите произведение пар чисел в одномерном массиве. Парок считаем первый и последний элемент, второй и предпоследний и т. д. Результат запишите в новом массиве. Примечание к задаче... Необходимо найти произведение пар элементов в массиве сначала первого и последнего и далее идём внутрь т.е. второго и предпоследнего и т. д. Если количество элементов нечётное то у серединного пары нет и его тогда просто плюсуем отдельно как новый элемент в новом массиве без пары. Сумму каждой пары нужно будет помещать в новый массив, а нечётный элемент нужно будет поместить без пары.
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
    double RaznicaMaxMin = 0;

    for(int i = 0; i < 10; i++)
    {
        Massiv[i] = new Random().Next(1,11);
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
//==============================================================================================================================================
// Задача. Контрольная работа
//=============================================================================================================
// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Вариант 1
/*
void MassivDo3Simvolov(string[] massiv)
{
    int cchetchik = 0;
    int dlinaNewMassiva = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if(massiv[i].Length <= 3) cchetchik = cchetchik + 1;
    }

    string[] newMassiv = new string[cchetchik];
    dlinaNewMassiva = cchetchik;
    cchetchik = 0;
    if(dlinaNewMassiva == 0) Console.Write("[]");

    for (int i = 0; i < massiv.Length; i++)
    {
        if(massiv[i].Length <= 3)
        {
            newMassiv[cchetchik] = massiv[i];
                       
            if(cchetchik == 0 && dlinaNewMassiva == 1)
            {
                Console.Write("[\"" + newMassiv[cchetchik] + "\"]");
            }
            else if(cchetchik == 0)
                {
                    Console.Write("[\"" + newMassiv[cchetchik] + "\",");
                }
                else if(cchetchik == (dlinaNewMassiva - 1))
                    {
                        Console.Write("\"" + newMassiv[cchetchik] + "\"]");
                    }
                    else
                    {
                        Console.Write("\"" + newMassiv[cchetchik] + "\",");
                    }

            cchetchik = cchetchik + 1;
        }
    }

    Console.WriteLine();
}

string[] massiv1 = {"hello", "2", "world", ":-)"};
string[] massiv2 = {"1234", "1567", "-2", "computer science"};
string[] massiv3 = {"Russia", "Denmark", "Kazan"};

MassivDo3Simvolov(massiv1);
MassivDo3Simvolov(massiv2);
MassivDo3Simvolov(massiv3);
*/
//Вариант 2 ================================================================================================================
/*
void MassivDo3Simvolov(string[] massiv)
{
    int cchetchik = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if(massiv[i].Length <= 3) cchetchik = cchetchik + 1;
    }

    string[] newMassiv = new string[cchetchik];
    
    if(cchetchik == 0) Console.Write("[]");

    cchetchik = 0;
    
    for (int i = 0; i < massiv.Length; i++)
    {
        if(massiv[i].Length <= 3)
        {
            newMassiv[cchetchik] = massiv[i];
            cchetchik = cchetchik + 1;
        }
    }

     for (int i = 0; i < newMassiv.Length; i++)
    {
        if(i == 0 && newMassiv.Length == 1)
        {
            Console.Write("[\"" + newMassiv[i] + "\"]");
        } 
        else if(i == 0 && newMassiv.Length != 1)
            {
                Console.Write("[\"" + newMassiv[i] + "\",");
            }
            else if(i == (newMassiv.Length - 1))
                {
                  Console.Write("\"" + newMassiv[i] + "\"]");
                }
                else                                          //if(i > 0 && i < (newMassiv.Length - 1)) Можно без последнего условия просто else оставить
                {
                    Console.Write("\"" + newMassiv[i] + "\",");
                } 
    }

    Console.WriteLine();
}

string[] massiv1 = {"hello", "2", "world", ":-)"};
string[] massiv2 = {"1234", "1567", "-2", "computer science"};
string[] massiv3 = {"Russia", "Denmark", "Kazan"};

MassivDo3Simvolov(massiv1);
MassivDo3Simvolov(massiv2);
MassivDo3Simvolov(massiv3);
*/
//======================================================================================================================================
// Задачи с семинара 6.
//================================================================================================================================================
// Задача. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
void ProverkaNaTreugolnik(int dlinaA, int dlinaB, int dlinaC)
{
    if(dlinaA < (dlinaB + dlinaC) && dlinaB < (dlinaA + dlinaC) && dlinaC < (dlinaA + dlinaB)) Console.WriteLine("Треугольник существует");
    else Console.WriteLine("Треугольник не существует");

}


Console.WriteLine("Введите сторону A треугольника для проверки");
int ctotonaA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B треугольника для проверки");
int ctotonaB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону C треугольника для проверки");
int ctotonaC = Convert.ToInt32(Console.ReadLine());

ProverkaNaTreugolnik(ctotonaA, ctotonaB, ctotonaC);
*/
//==============================================================================================================================================
// Задача. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Вариант 1
/*
void PerevodIz10v2(int chisloV10)
{
    string dvoichnoe = String.Empty; //  string dvoichnoe = ""; можно написать здесь так

    while(chisloV10 > 0)
    {
        dvoichnoe = Convert.ToString(chisloV10 % 2) + dvoichnoe;
        chisloV10 = chisloV10 / 2;
    }
    
    Console.WriteLine(dvoichnoe);
}

Console.WriteLine("Введите десятичное число для перевода в двоичное");
int chislo = Convert.ToInt32(Console.ReadLine());

PerevodIz10v2(chislo);
*/
//Вариант 2======================================================================================================================================
/*
Console.WriteLine("Введите десятичное число для перевода в двоичное");
int chislo = Convert.ToInt32(Console.ReadLine());
if(chislo == 0) Console.WriteLine($"[{chislo}]");
else
{
    int DlinaDvoichnogoChisla = 0;
    int i = 0;
    int KolichestvoDvoichnixKombinacijchislo = chislo + 1;
    if (Math.Log(KolichestvoDvoichnixKombinacijchislo, 2) % 1 == 0) DlinaDvoichnogoChisla = Convert.ToInt32(Math.Round(Math.Log(KolichestvoDvoichnixKombinacijchislo ,2), MidpointRounding.ToZero)); // проверяем целове число или нет
    else DlinaDvoichnogoChisla = Convert.ToInt32(Math.Round(Math.Log(KolichestvoDvoichnixKombinacijchislo ,2) + 1, MidpointRounding.ToZero));
    
   int[] massivPerevodaChisla = new int[DlinaDvoichnogoChisla];
    
    while(chislo > 0)
    {
        massivPerevodaChisla[i] = chislo % 2;
        chislo = chislo / 2;
        i++;
    }

    int[] dvoichnoeChislo = new int[DlinaDvoichnogoChisla];
    for(i = 0; i < DlinaDvoichnogoChisla; i++)
    {
        dvoichnoeChislo[i] = massivPerevodaChisla[DlinaDvoichnogoChisla - 1 - i];
    }

    Console.WriteLine("[{0}]", string.Join(" ", dvoichnoeChislo));
}
*/
// Вариант 3=============================================================================================================================
/*
Console.WriteLine("Введите десятичное число для перевода в двоичное");
int chislo = Convert.ToInt32(Console.ReadLine());
if(chislo == 0) Console.WriteLine($"[{chislo}]");
else
{
    int DlinaDvoichnogoChisla = 0;
    int i = 0;
    int KolichestvoDvoichnixKombinacijchislo = chislo + 1;
    if (Math.Log(KolichestvoDvoichnixKombinacijchislo, 2) % 1 == 0) DlinaDvoichnogoChisla = Convert.ToInt32(Math.Round(Math.Log(KolichestvoDvoichnixKombinacijchislo ,2), MidpointRounding.ToZero)); // проверяем целове число или нет
    else DlinaDvoichnogoChisla = Convert.ToInt32(Math.Round(Math.Log(KolichestvoDvoichnixKombinacijchislo ,2) + 1, MidpointRounding.ToZero));
    
    int[] massivPerevodaChisla = new int[DlinaDvoichnogoChisla];
    
    while(chislo > 0)
    {
        massivPerevodaChisla[i] = chislo % 2;
        chislo = chislo / 2;
        i++;
    }

    for(i = (massivPerevodaChisla.Length - 1); i>= 0; i--)
    {   
        if(i == massivPerevodaChisla.Length - 1 && DlinaDvoichnogoChisla == 1) Console.Write("[" + massivPerevodaChisla[i] + "]");
        else if (i == massivPerevodaChisla.Length - 1) Console.Write("[" + massivPerevodaChisla[i] + " ");
            else if (i == 0) Console.Write(massivPerevodaChisla[i] + "]");
                else Console.Write(massivPerevodaChisla[i] + " ");        
    }
}
*/
// Вариант 4 с отрицательынми числами =============================================================================================================================
/*
Console.WriteLine("Введите десятичное число для перевода в двоичное");
int chislo = Convert.ToInt32(Console.ReadLine());
if(chislo == 0) Console.WriteLine($"[{chislo}]");
else
{   
    int chisloOtricatelnoe = 0;
    if(chislo < 0 ) chisloOtricatelnoe = 1;
    
    chislo = Math.Abs(chislo);
    int dlinaDvoichnogoChisla = 0;
    int i = 0;
    int KolichestvoDvoichnixKombinacijchislo = chislo + 1;
    if (Math.Log(KolichestvoDvoichnixKombinacijchislo, 2) % 1 == 0) dlinaDvoichnogoChisla = Convert.ToInt32(Math.Round(Math.Log(KolichestvoDvoichnixKombinacijchislo ,2), MidpointRounding.ToZero)); // проверяем целове число или нет
    else dlinaDvoichnogoChisla = Convert.ToInt32(Math.Round(Math.Log(KolichestvoDvoichnixKombinacijchislo ,2) + 1, MidpointRounding.ToZero)); // так как нам нужно не остаток а полное количество бит для размещения числа без учёта знака
    
    if(chisloOtricatelnoe == 1) dlinaDvoichnogoChisla = dlinaDvoichnogoChisla + 1; // это старший бит для отрицательного знака
    
    int[] massivPerevodaChisla = new int[dlinaDvoichnogoChisla];
    
    while(chislo > 0)
    {
        massivPerevodaChisla[i] = chislo % 2;
        chislo = chislo / 2;
        i++;
    }
    if(chisloOtricatelnoe == 1) massivPerevodaChisla[massivPerevodaChisla.Length - 1] = 1;

    for(i = (massivPerevodaChisla.Length - 1); i>= 0; i--)
    {   
       if(i == massivPerevodaChisla.Length - 1 && massivPerevodaChisla.Length == 1) Console.Write("[" + massivPerevodaChisla[i] + "]");
       else if (i == massivPerevodaChisla.Length - 1) Console.Write("[" + massivPerevodaChisla[i] + " ");
            else if (i == 0) Console.Write(massivPerevodaChisla[i] + "]");
                 else Console.Write(massivPerevodaChisla[i] + " ");        
    }
}
*/
// Вариант 5================================================================================================================================
/*
string convertingToBin(int num, string snum)
{   
    if (num % 2 == 0) snum = "0" + snum;
    else snum = "1" + snum;
   
    if ((num/2) != 0) return convertingToBin(num/2, snum); 
    else return snum;
}

Console.Write("Введите десятичное число: "); 
int numberDec = Convert.ToInt32(Console.ReadLine());

string numberBin = "";
numberBin = convertingToBin(numberDec, numberBin);
Console.Write("Двоичное число: " + numberBin);
*/
//===========================================================================================================================================
// Задача. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Вариант 1
/*
void VivodChicelFibonachi(int kolichestvoChisel)
{
    int[] chislaFibonachiMassiv = new int[kolichestvoChisel];
    for(int i = 0; i < chislaFibonachiMassiv.GetLength(0); i++)
    {
        if(i == 0)
        {
            chislaFibonachiMassiv[i] = 0;
            Console.Write(chislaFibonachiMassiv[i] + " ");
        }
        else if (i == 1)
            {
                chislaFibonachiMassiv[i] = 1;
                Console.Write(chislaFibonachiMassiv[i] + " ");
            }                
            else
            {
                chislaFibonachiMassiv[i] = chislaFibonachiMassiv[i - 1] + chislaFibonachiMassiv[i - 2];
                Console.Write(chislaFibonachiMassiv[i] + " ");
            }
        Console.WriteLine(); 
    }
}

Console.WriteLine("Введите количество первых чисел Фиббоначчи которые нужно вывести");
int kolichestvoChicelFibonachi = Convert.ToInt32(Console.ReadLine());

VivodChicelFibonachi(kolichestvoChicelFibonachi);
*/
// Вариант 2
/*
void VivodChicelFibonachi(int kolichestvoChisel)
{
    int[] chislaFibonachiMassiv = new int[kolichestvoChisel];
    chislaFibonachiMassiv[0] = 0;
    chislaFibonachiMassiv[1] = 1;

    for(int i = 2; i < chislaFibonachiMassiv.GetLength(0); i++)
    {
        chislaFibonachiMassiv[i] = chislaFibonachiMassiv[i - 1] + chislaFibonachiMassiv[i - 2];
        Console.Write(chislaFibonachiMassiv[i] + " ");
    }
}

Console.WriteLine("Введите количество первых чисел Фиббоначчи которые нужно вывести");
int kolichestvoChicelFibonachi = Convert.ToInt32(Console.ReadLine());

VivodChicelFibonachi(kolichestvoChicelFibonachi);
*/
//=======================================================================================================================================
// Задача. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
void KopiaMassiv(int[,] massivKopia) //можно делать метод не void а int тогда нужно писать int[,] и добавить return
{
    int[,] newMassivKopia = new int[massivKopia.GetLength(0), massivKopia.GetLength(1)];

    for(int i = 0; i < newMassivKopia.GetLength(0); i++)
    {
        for(int j = 0; j < newMassivKopia.GetLength(1); j++)
        {
            newMassivKopia[i,j] = massivKopia[i,j];
            Console.Write(newMassivKopia[i,j] + " ");
        }

        Console.WriteLine();
    }

}

int[,] massiv = new int[3,3]; //int[,] massiv = {{1,2,3}, {4,5,6}, {7,8,9}}; можно задать вручную тогда не нужны строки с заполнением рандома

for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i,j] = new Random().Next(1,11);
        Console.Write(massiv[i,j] + " ");
    }
    
    Console.WriteLine();
}

Console.WriteLine();
KopiaMassiv(massiv);
*/
//==========================================================================================================================================
// Задача. Сортировка массива
// Вариант от меньшего к большему
/*
void PechatMassiva(int[] massivPechat)
{
    for (int i = 0; i < massivPechat.Length; i++)
    {
        Console.Write($"{massivPechat[i]} ");
    }

    Console.WriteLine();
}

void SortirovkaMassiva(int[] massivSortirovka)
{
    for (int i = 0; i < massivSortirovka.Length - 1; i++)
    {
        int minPoziciya = i;

        for (int j = i + 1; j < massivSortirovka.Length; j++)
        {
            if(massivSortirovka[j] < massivSortirovka[minPoziciya]) minPoziciya = j;
        }

        int vremennayaPoziciya = massivSortirovka[i];
        massivSortirovka[i] = massivSortirovka[minPoziciya];
        massivSortirovka[minPoziciya] = vremennayaPoziciya;
    }
}

int[] massiv = {1,5,4,3,2,6,7,1,1};
PechatMassiva(massiv);
SortirovkaMassiva(massiv);
PechatMassiva(massiv);
*/
// Вариант от большего к меньшему
/*
void PechatMassiva(int[] massivPechat)
{
    for (int i = 0; i < massivPechat.Length; i++)
    {
        Console.Write($"{massivPechat[i]} ");
    }

    Console.WriteLine();
}

void SortirovkaMassiva(int[] massivSortirovka)
{
    for (int i = 0; i < massivSortirovka.Length - 1; i++)
    {
        int maxPoziciya = i;

        for (int j = i + 1; j < massivSortirovka.Length; j++)
        {
            if(massivSortirovka[j] > massivSortirovka[maxPoziciya]) maxPoziciya = j;
        }

        int vremennayaPoziciya = massivSortirovka[i];
        massivSortirovka[i] = massivSortirovka[maxPoziciya];
        massivSortirovka[maxPoziciya] = vremennayaPoziciya;
    }
}

int[] massiv = {1,5,4,3,2,6,7,1,1};
PechatMassiva(massiv);
SortirovkaMassiva(massiv);
PechatMassiva(massiv);
*/
//============================================================================================================================================
// Задачи. Семинар 7
//============================================================================================================================================
// Задача. Задайте двумерный массив размером m×n, заполненный случайными двухзначными целыми числами.
/*
void Array (int m, int n)
{
    Random r = new Random();
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = r.Next (10, 100);
            Console.Write ($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int dlinaRow = 3;
int dlinaCol = 4;
Array(dlinaRow, dlinaCol);
*/
//============================================================================================================================================
// Задача. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
/*
void Array(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i+j;
            Console.Write ($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
int dlinaRow = 3;
int dlinaCol = 4;
Array(dlinaRow, dlinaCol);
*/
//===================================================================================================================================================
// Задача. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты. В квадрат возводим значение элемента.
/*
void Array (int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next (2, 10);
            Console.Write ($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] = matrix[i, j] * matrix[i, j]; // эту строчку можно было сделать сразу в первом цикле после заполенния рандомом просто сделали в отдельном для проверки самих себя, тогда второй цикл нужно просто удалить.
            Console.Write ($"{matrix [i,j]} ");
        }
        Console.WriteLine();
    }
}
int dlinaRow = 3;
int dlinaCol = 4;
Array(dlinaRow, dlinaCol);
*/
//============================================================================================================================================
// Задача. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.). Массив при этом должен быть строго квадратным.
/*
void Array(int m)
{
    int sum = 0;
    int[,] matrix = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix [i, j] = new Random().Next (1, 10);
            if (i == j) sum = sum + matrix[i, j];
            Console.Write ($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(sum);
}
int dlina = 3;

Array(dlina);
*/
//===================================================================================================================================================
// ДЗ семинар 7
//================================================================================================================================================
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
// Задачи. Семинар 8.
//==================================================================================================================================================
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Вариант 1
/*
void MassivRandom()
{
    Random random = new Random();

    int[,] massiv = new int[random.Next(1, 10), random.Next(1, 10)];

    Console.WriteLine($"Массив[{massiv.GetLength(0)},{massiv.GetLength(1)}]");

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i,j] = random.Next(1, 10);
            Console.Write($"{massiv[i,j]} ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();

    int[,] massivZamenaCtrok = new int[massiv.GetLength(0), massiv.GetLength(1)];

    for (int i = 0; i < massivZamenaCtrok.GetLength(0); i++)
    {
        for (int j = 0; j < massivZamenaCtrok.GetLength(1); j++)
        {
            massivZamenaCtrok[i,j] = massiv[i,j];
            if(i == 0) massivZamenaCtrok[0,j] = massiv[massiv.GetLength(0) - 1,j];
            if(i == massiv.GetLength(0) - 1) massivZamenaCtrok[massiv.GetLength(0) - 1,j] = massiv[0,j];
            Console.Write($"{massivZamenaCtrok[i,j]} ");
        }

        Console.WriteLine();
    }
}

MassivRandom();
*/
// Вариант 2======================================================================================================================================
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

int[,] ZamenaPervojPoslednejCtrokiMassiva(int[,] massiv)
{
    int tmp = 0;

    for (int i = 0; i < massiv.GetLength(1); i++)
    {
        tmp = massiv[0,i];
        massiv[0,i] = massiv[massiv.GetLength(0) - 1, i];
        massiv[massiv.GetLength(0) - 1, i] = tmp;

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

int[,] massivNaIzmenenie = CozdanieMassiva();

Print2DMassiv(massivNaIzmenenie);
Console.WriteLine();
Print2DMassiv(ZamenaPervojPoslednejCtrokiMassiva(massivNaIzmenenie));
*/
//=============================================================================================================================================
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Вариант 1
/*
void MassivRandom()
{
    Random random = new Random();

    int[,] massiv = new int[random.Next(1, 5), random.Next(1, 5)];

    if (massiv.GetLength(0) != massiv.GetLength(1)) Console.WriteLine($"Массив[{massiv.GetLength(0)},{massiv.GetLength(1)}] не является квадратным и заменить строки и столбцы невозможно");
    else
    {
        Console.WriteLine($"Массив[{massiv.GetLength(0)},{massiv.GetLength(1)}]");

        for (int i = 0; i < massiv.GetLength(0); i++)
        {
            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                massiv[i,j] = random.Next(1, 10);
                Console.Write($"{massiv[i,j]} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        int[,] massivZamenaCtrok = new int[massiv.GetLength(0), massiv.GetLength(1)];

        for (int i = 0; i < massivZamenaCtrok.GetLength(0); i++)
        {
            for (int j = 0; j < massivZamenaCtrok.GetLength(1); j++)
            {
                massivZamenaCtrok[j,i] = massiv[i,j]; // если стразу выводить на экран то будут нули так как элементы ещё не все заполненны которые мы меняем в массив е massivZamenaCtrok[i,j] а уже выводим их на экран
            }
        }

        for (int i = 0; i < massivZamenaCtrok.GetLength(0); i++)
        {
            for (int j = 0; j < massivZamenaCtrok.GetLength(1); j++)
            {
                Console.Write($"{massivZamenaCtrok[i,j]} ");
            }

            Console.WriteLine();
        }
    }
}

MassivRandom();
*/
//Вариант 2=======================================================================================================================================
/*
void MassivRandom()
{
    Random random = new Random();

    int[,] massiv = new int[random.Next(1, 5), random.Next(1, 5)];

    if (massiv.GetLength(0) != massiv.GetLength(1)) Console.WriteLine($"Массив[{massiv.GetLength(0)},{massiv.GetLength(1)}] не является квадратным и заменить строки и столбцы невозможно");
    else
    {
        Console.WriteLine($"Массив[{massiv.GetLength(0)},{massiv.GetLength(1)}]");

        for (int i = 0; i < massiv.GetLength(0); i++)
        {
            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                massiv[i,j] = random.Next(1, 10);
                Console.Write($"{massiv[i,j]} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        int[,] massivZamenaCtrok = new int[massiv.GetLength(0), massiv.GetLength(1)];

        for (int i = 0; i < massivZamenaCtrok.GetLength(0); i++)
        {
            for (int j = 0; j < massivZamenaCtrok.GetLength(1); j++)
            {
                massivZamenaCtrok[i,j] = massiv[j,i];
                Console.Write($"{massivZamenaCtrok[i,j]} ");
            }

            Console.WriteLine();
        }

    }
}

MassivRandom();
*/
// Вариант 3====================================================================================================================================
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

int[,] ZamenaVcexCtrokCtolbcovMassivaMestami(int[,] massiv)
{
    if(massiv.GetLength(0) == massiv.GetLength(1))
    {
        int tmp = 0;
        for (int i = 0; i < massiv.GetLength(0); i++)
        {
            for (int j = i; j < massiv.GetLength(1); j++)
            {
                tmp = massiv[i,j];
                massiv[i,j] = massiv[j,i];
                massiv[j,i] = tmp;
            }
        }
    }
    else Console.WriteLine($"Массив[{massiv.GetLength(0)},{massiv.GetLength(1)}] не является квадратным и заменить строки и столбцы невозможно");
    
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

int[,] massivNaIzmenenie = CozdanieMassiva();

Print2DMassiv(massivNaIzmenenie);
Console.WriteLine();
Print2DMassiv(ZamenaVcexCtrokCtolbcovMassivaMestami(massivNaIzmenenie));
*/
// Вариант 4=======================================================================================================================================
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

int[,] ZamenaVcexCtrokCtolbcovMassivaMestami(int[,] massiv)
{
    int tmp = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = i; j < massiv.GetLength(1); j++)
        {
            tmp = massiv[i,j];
            massiv[i,j] = massiv[j,i];
            massiv[j,i] = tmp;
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

int[,] massivNaIzmenenie = CozdanieMassiva();

if(massivNaIzmenenie.GetLength(0) != massivNaIzmenenie.GetLength(1)) Console.WriteLine($"Массив[{massivNaIzmenenie.GetLength(0)},{massivNaIzmenenie.GetLength(1)}] не является квадратным и заменить строки и столбцы невозможно");
else
{
    Print2DMassiv(massivNaIzmenenie);
    Console.WriteLine();
    Print2DMassiv(ZamenaVcexCtrokCtolbcovMassivaMestami(massivNaIzmenenie));
}
*/
//=============================================================================================================================================
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент. (Заполнить нулями эти строки а не удалять)
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

int[,] UdalenieCtrokiCtolbcaNaimenwegoElementaMassiva(int[,] massiv)
{
    int indexMinI = 0;
    int indexMinJ = 0;
    int minElement = massiv[0,0];

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if(massiv[i,j] < minElement)
            {
                minElement = massiv[i,j];
                indexMinI = i;
                indexMinJ = j;
            }
        }
    }

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        massiv[i,indexMinJ] = 0;
    }

    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[indexMinI,j] = 0;
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

int[,] massivNaIzmenenie = CozdanieMassiva();

Print2DMassiv(massivNaIzmenenie);
Console.WriteLine();
Print2DMassiv(UdalenieCtrokiCtolbcaNaimenwegoElementaMassiva(massivNaIzmenenie));
*/
//========================================================================================================================================
// ДЗ Семинар 8
//========================================================================================================================================
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
//============================================================================================================================================
// Задача 4. Заполните спирально массив 4 на 4.
// Вариант 1 для квадратной матрицы
/*
int[,] CozdanieMassiva()
{
    Random random = new Random();

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
//=========================================================================================================================================
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
//=========================================================================================================================================
// Задачи. Семинар 9.
//=========================================================================================================================================
// Задача. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
/*
void NaxogdeniePereceheniyaPryamix(double k1Chislo, double k2Chislo, double b1Chislo, double b2Chislo)
{
    double x = (b2Chislo - b1Chislo) / (k1Chislo - k2Chislo);
    double y = (k1Chislo * x) + b1Chislo;

    Console.WriteLine($"Координата у = {x}, х = {y}");
}

Console.WriteLine("Введите коэффециент k1 первой прямой");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффециент k2 второй прямой");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффециент b1 первой прямой");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффециент b2 второй прямой");
double b2 = Convert.ToDouble(Console.ReadLine());

NaxogdeniePereceheniyaPryamix(k1, k2, b1, b2);
*/
//=============================================================================================================================================
// Задача Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.
/*
Console.WriteLine("Введите порядок степени для треугольника");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    for (int j = num; j > i + 1; j--) // или for (int j = 0; j > i; j--) чтоб был не в виде треугольника или for (int j = num; j > i + 1; j--) чтоб начинались слева сразу без пробела
    {
        Console.Write(" ");
    }

    int val = 1;

    for (int j = 0; j <= i; j++)
    {
        Console.Write(val + " ");
        val = (val * (i - j)) / (j + 1);
    }

    Console.WriteLine();
}
*/
//================================================================================================================================================
