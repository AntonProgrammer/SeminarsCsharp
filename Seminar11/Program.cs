//=====================================================================================================================================
// Задача. Заданы 2 массива: info b data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info; data = {0,1,1,1,1,0,0,0,1}, info = {2,3,3,1}.
// Сделать для произвольного варианта массива data, когда могут не совпадать размерности массивов и для него не хватает чисел.
/*
int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 }; // полный будет int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
int[] info = { 2, 3, 3, 1, 4, 3 };
int indexNachalaChisla = 0;
int intdexKonecChesla = 1;
int cchetchik = 0;
int kolichestvoChiselData = data.Length;
int cchetchikKolichestvoChiselData = 0;

double[] newMassiv = new double[info.Length];

while (cchetchik < info.Length)
{
    double decyatichnoeChislo = 0;
    int ctepen = 0;

    cchetchikKolichestvoChiselData = cchetchikKolichestvoChiselData + info[cchetchik];

    if (cchetchikKolichestvoChiselData <= kolichestvoChiselData)
    {
        for (int i = intdexKonecChesla; i >= indexNachalaChisla; i--)
        {
            decyatichnoeChislo = decyatichnoeChislo + (data[i] * Math.Pow(2, ctepen));
            ctepen++;
        }
        newMassiv[cchetchik] = decyatichnoeChislo;
        cchetchik++;
        if (cchetchik == info.Length) break;
        indexNachalaChisla = intdexKonecChesla + 1;
        if (cchetchik == 1) intdexKonecChesla = 1;
        intdexKonecChesla = intdexKonecChesla + info[cchetchik];
    }
    else break;
}

if (kolichestvoChiselData < cchetchikKolichestvoChiselData)
{
    Console.WriteLine("Откорректируйте содержимое массива data в соответствии с info");
}

for (int i = 0; i < cchetchik; i++)
{
    Console.Write($"[{newMassiv[i]}] ");
}
*/
//=========================================================================================================================================