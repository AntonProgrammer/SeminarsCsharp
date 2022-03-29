//======================================================================================================================================================
// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Вариант 1
/*
void PodschetKolichestvaChiselBolweNulya(int[] massiv)
{
    int cchetchikChicelBolweNulya = 0;
    int[] massivChicelBolweNulya = new int[massiv.GetLength(0)];
    
    for (int i = 0; i < massivChicelBolweNulya.Length; i++)
    {
        massivChicelBolweNulya[i] = massiv[i];
        if(massivChicelBolweNulya[i] > 0) cchetchikChicelBolweNulya = cchetchikChicelBolweNulya + 1;
        Console.Write($"{massivChicelBolweNulya[i]} ");
    }

    Console.WriteLine();
    Console.WriteLine($"Количество числе больше нуля равно {cchetchikChicelBolweNulya}");
}

Console.WriteLine("Введите количество чисел которые будете вводить для проверки больше ли они нуля");
int kolichestvoChisel = Convert.ToInt32(Console.ReadLine());
int[] massivChisel = new int[kolichestvoChisel];

for (int i = 0; i < massivChisel.GetLength(0); i++)
{
    Console.WriteLine("Введите целое число");
    massivChisel[i] = Convert.ToInt32(Console.ReadLine());
}

PodschetKolichestvaChiselBolweNulya(massivChisel);
*/
// Вариант 2=======================================================================================================================
/*
int kolichestvoChisel = 10;
int cchetchikChicelBolweNulya = 0;
int index = 0;
int[] massivChisel = new int[10];

while(index < kolichestvoChisel)
{
    Console.WriteLine("Введите целое число");
    massivChisel[index] = Convert.ToInt32(Console.ReadLine());
    index++;
}

for (int i = 0; i < massivChisel.Length; i++)
{
    if(massivChisel[i] > 0) cchetchikChicelBolweNulya = cchetchikChicelBolweNulya + 1;
    Console.Write($"{massivChisel[i]} ");
}

Console.WriteLine($"Количество числе больше нуля равно {cchetchikChicelBolweNulya}");
*/
//==========================================================================================================================================
// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.
/*
void VivodMatrici(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if(i == 0 || i == massiv.GetLength(0) - 1 || j == 0 || j == massiv.GetLength(1) - 1) massiv[i,j] = 1;
            else massiv[i,j] = 0;
            Console.Write($"{massiv[i,j]} ");
        }

        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк матрицы");
int kolichestvoStrokMatrici = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы");
int kolichestvoStolbcovMatrici = Convert.ToInt32(Console.ReadLine());

int[,] massivPolzovatelya = new int[kolichestvoStrokMatrici, kolichestvoStolbcovMatrici];

VivodMatrici(massivPolzovatelya);
*/
//=======================================================================================================================================