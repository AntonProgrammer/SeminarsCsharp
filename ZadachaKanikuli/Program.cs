//================================================================================================================
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