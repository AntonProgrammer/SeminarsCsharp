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