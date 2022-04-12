//================================================================================================================================================
// Задача Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.
// Варинат 1 с равнобердренным треугольником
/*
int MetodPodcchetaKolichestvaCifrCtroki(int[][] massiv, int nomerStroki)
{
    int valTmp;
    int kolichestvoCifrCtroki = 0;

    for (int i = nomerStroki; i <= nomerStroki; i++)
    {
        for (int j = 0; j < massiv[i].Length; j++)
        {
            valTmp = massiv[i][j];

            while (valTmp > 0)
            {
                valTmp = valTmp / 10;
                kolichestvoCifrCtroki = kolichestvoCifrCtroki + 1;
            }
        }

    }

    return kolichestvoCifrCtroki;
}

Console.WriteLine("Введите порядок степени для треугольника");
int num = Convert.ToInt32(Console.ReadLine());
int kolichestvoZnakovMaxCtroki;
int kolichestvoCifrMaxCtoka = 0;
int perekluchatelСhetnayaPoclednyayaStroka = 0;
int[][] massivPascal = new int[num][];
int newMassiv = 0;

while (newMassiv < num)
{
    massivPascal[newMassiv] = new int[newMassiv + 1];
    newMassiv++;
}

int val;

for (int i = 0; i < num; i++)  // Можно так написать  for (int i = 0; i < massivPascal.Length; i++)
{
    val = 1;

    for (int j = 0; j <= i; j++)   // Можно так написать  for (int j = 0; j <= massivPascal[i].Length; j++) 
    {
        massivPascal[i][j] = val;
        val = (val * (i - j)) / (j + 1);
    }
}

int valTmp;

for (int i = num - 1; i < massivPascal.Length; i++)
{
    for (int j = 0; j < massivPascal[i].Length; j++)
    {
        valTmp = massivPascal[i][j];

        while (valTmp > 0)
        {
            valTmp = valTmp / 10;
            kolichestvoCifrMaxCtoka = kolichestvoCifrMaxCtoka + 1;
        }
    }
}

kolichestvoZnakovMaxCtroki = kolichestvoCifrMaxCtoka + (massivPascal[num - 1].Length - 1);

if (kolichestvoZnakovMaxCtroki % 2 == 0)
{
    perekluchatelСhetnayaPoclednyayaStroka = 1;
    kolichestvoZnakovMaxCtroki = kolichestvoZnakovMaxCtroki + 1;
}

int seredinaPoslednejCtroki = kolichestvoZnakovMaxCtroki / 2 + 1;
int kolichestvoProbelovNachaloPervojCtroki = seredinaPoslednejCtroki - 1;
int kolichestvoProbelovCverxuVniz = num; // нужно чтобы не захватывать последнюю строку и она была без пробелов так как отталкиваемся от неё
int kolichestvoCtrokBezPervojPocledney = num - 1; // 1 так как идёт заход на цикл так должно быть 2
int otstupCnachala;
int kolichestvoProbelovPosleduuwixCtrok = 0;
int cchetchikRaznici = 0;

for (int i = 0; i < massivPascal.Length; i++)
{
    if (i == 0) otstupCnachala = kolichestvoProbelovNachaloPervojCtroki;
    else otstupCnachala = kolichestvoProbelovPosleduuwixCtrok;

    while (otstupCnachala > 0 && kolichestvoProbelovCverxuVniz - 1 > 0) // && kolichestvoProbelovNachaloPervojCtroki > 0
    {
        Console.Write($" ");
        otstupCnachala--;
    }

    int raznica;
    cchetchikRaznici = 0;

    for (int j = 0; j < massivPascal[i].Length; j++)
    {
        if (i == (massivPascal.Length - 1))
        {
            if (perekluchatelСhetnayaPoclednyayaStroka == 1 && j == massivPascal[i].Length / 2)
            {
                Console.Write($"{massivPascal[massivPascal.Length - 1][massivPascal[i].Length / 2]}  ");
            }
            else Console.Write($"{massivPascal[i][j]} ");
        }
        else if (massivPascal[i].Length == 1)
        {
            Console.Write($"{massivPascal[i][j]}");

        }
        else if (massivPascal[i].Length >= 2 && i != (massivPascal.Length - 1))
        {
            Console.Write($"{massivPascal[i][j]}");

            int otstupProbelovOtElementa = (kolichestvoZnakovMaxCtroki - (kolichestvoCtrokBezPervojPocledney * 2) - MetodPodcchetaKolichestvaCifrCtroki(massivPascal, i)) / (massivPascal[i].Length - 1);
            raznica = kolichestvoZnakovMaxCtroki - (kolichestvoCtrokBezPervojPocledney * 2) - (otstupProbelovOtElementa * (massivPascal[i].Length - 1) + MetodPodcchetaKolichestvaCifrCtroki(massivPascal, i));

            if (j < massivPascal[i].Length - 1) // && j != 0
            {
                while (otstupProbelovOtElementa > 0)
                {
                    Console.Write($" ");
                    otstupProbelovOtElementa--;
                }
            }

            if (cchetchikRaznici < raznica)
            {
                Console.Write($" ");
                cchetchikRaznici++;
            }
        }
    }

    Console.WriteLine();

    kolichestvoProbelovCverxuVniz--;
    kolichestvoCtrokBezPervojPocledney--;
    kolichestvoProbelovPosleduuwixCtrok = kolichestvoProbelovNachaloPervojCtroki - ((kolichestvoZnakovMaxCtroki - (kolichestvoCtrokBezPervojPocledney * 2)) / 2);

}
*/
// Вариант 2 с произвольным треугольником без ровнобедренного===============================================================================
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
// Вариант 3 с более ровным треугольником без массива=========================================================================================================
/*
Console.WriteLine("Введите порядок степени для треугольника");
int num = Convert.ToInt32(Console.ReadLine());
int max = int.MinValue;
int KolichestvoCifrMax = 0;

for (int i = 0; i < num; i++)
{
    int tmpVal = 1;

    for (int j = 0; j <= i; j++)
    {
        tmpVal = (tmpVal * (i - j)) / (j + 1);
        if (tmpVal > max) max = tmpVal;
    }
}

for (int i = 0; i < num; i++)
{
    for (int j = num; j > i + 1; j--) // или for (int j = 0; j > i; j--) чтоб был не в виде треугольника или for (int j = num; j > i + 1; j--) чтоб начинались слева сразу без пробела
    {
        KolichestvoCifrMax = 0;

        int tmpMax = max;
        while (tmpMax > 0)
        {
            tmpMax = tmpMax / 10;
            KolichestvoCifrMax = KolichestvoCifrMax + 1;
        }

        while (KolichestvoCifrMax > 0)
        {
            Console.Write(" ");
            KolichestvoCifrMax--;
        }
    }

    int val = 1;

    for (int j = 0; j <= i; j++)
    {
        int valTmp2 = val;
        Console.Write(val + " ");
        val = (val * (i - j)) / (j + 1);

        KolichestvoCifrMax = 0;

        int tmpMax = max;

        while (tmpMax > 0)
        {
            tmpMax = tmpMax / 10;
            KolichestvoCifrMax = KolichestvoCifrMax + 1;
        }

        int KolichestvoCifrvalTmp2 = 0;

        while (valTmp2 > 0)
        {
            valTmp2 = valTmp2 / 10;
            KolichestvoCifrvalTmp2 = KolichestvoCifrvalTmp2 + 1;
        }

        int kolichestvoProbelov = KolichestvoCifrMax - KolichestvoCifrvalTmp2;

        while (kolichestvoProbelov > 0)
        {
            Console.Write(" ");
            kolichestvoProbelov--;
        }

        kolichestvoProbelov = 0;
        KolichestvoCifrvalTmp2 = 0;
        KolichestvoCifrMax = 0;
    }

    Console.WriteLine();
}
*/
// вариант 4 с треугольником с пробелами между строк==================================================================================================================================================
/*
int i, n, c;
Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
string s = Console.ReadLine();
n = Convert.ToInt32(s);

for (i = 0; i < n; i++)
{
    for (c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отсутп
    {
        Console.Write(" ");
    }
    for (c = 0; c <= i; c++)
    {
        Console.Write(" "); // создаём пробелы между элементами треугольника
        Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
    }
    Console.WriteLine();
    Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
}
Console.ReadLine();

static float factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;

}
*/
//=====================================================================================================================================