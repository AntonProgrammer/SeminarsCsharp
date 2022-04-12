//=====================================================================================================================================
// Задача. Заданы 2 массива: info b data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info; data = {0,1,1,1,1,0,0,0,1}, info = {2,3,3,1}.
/*
int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int indexNachalaChisla = 0;
int intdexKonecChesla = 1;
int cchetchik = 0;
int ctepen = 0;

double[] newMassiv = new double[info.Length];

while (cchetchik < info.Length)
{
    double decyatichnoeChislo = 0;
    ctepen = 0;

    for (int i = intdexKonecChesla; i >= indexNachalaChisla; i--)
    {
        decyatichnoeChislo = decyatichnoeChislo + (data[i] * Math.Pow(2, ctepen));
        ctepen++;
    }
    newMassiv[cchetchik] = decyatichnoeChislo;
    cchetchik++;
    if (cchetchik == 4) break;
    indexNachalaChisla = intdexKonecChesla + 1;
    if (cchetchik == 1) intdexKonecChesla = 1;
    intdexKonecChesla = intdexKonecChesla + info[cchetchik];
}

for (int i = 0; i < newMassiv.Length; i++)
{
    Console.Write($"[{newMassiv[i]}] ");
}
*/
//=====================================================================================================================================