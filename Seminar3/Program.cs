//======================================================================================================
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите пятизначное число");
int Chislo = Convert.ToInt32(Console.ReadLine());
int CifraCpavа = Chislo % 10;
int CifraClevа = Chislo / 10000;

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
