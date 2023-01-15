// Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное

// 1. Ввод N
// 2. Создание массива
// 3. Заполнение массива 0 и 1
// 4. Печать массива
// 5. Конвертация из 2-ого в 10-ое
// 6. 10110100 >> 180

// 1. Ввод N
int GetNumberByUser(string text)
{
    System.Console.WriteLine(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

// 2. Создание массива
int[] CreateArray(int N)
{
    return new int[N];
}

// 3. Заполнение массива 0 и 1
void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(2);
    }
}

// 4. Печать массива
void PrintArray(int[] col)
{
    int count = col.Length;
    for (int index = 0; index < count; index++)
    {
        System.Console.Write(col[index]);
    }
}

// 5. Конвертация из 2-ого в 10-ое
int ConvertTo10(int[] array, int radix)
{
    int length = array.Length;
    int pow = 0;
    for (int i = length - 1; i >= 0; i--)
    {
        array[i] = array[i] * Convert.ToInt32(Math.Pow(radix, pow));
        pow++;
    }
    int sum = 0;
    for (int index = 0; index < length; index++)
    {
        sum = sum + array[index];
    }
return sum;
}

// 6. 10110100 >> 180
 string GoodPrint(int[] bin, int dec)
 {
    return $"{String.Join(",", bin)} >> {dec}";
 }

// Введение дополнительного массива для вывода красивого результата
int[] ExtraArray(int[] array)
{
    int length = array.Length;
    int[] ArrToConvert = new int[length];
    for (int i = 0; i < length; i++)
    {
        ArrToConvert[i] = array[i];
    }
    return ArrToConvert;
}

int N = GetNumberByUser("Введите N ");
int[] arr = CreateArray(N);
FillArray(arr);
arr[0] = 1;

PrintArray(arr);
Console.WriteLine();

int[] extra = ExtraArray(arr);
int dec = ConvertTo10(extra, 2);
System.Console.WriteLine(GoodPrint(arr, dec));

