// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// 1. Ввод N
// 2. Создание массива
// 3. Заполнение массива 
// 4. Метод получения произведений пар чисел и вывода нового массива
// 5. Распечатать результат

// 1. Ввод N
int GetNumberByUser(string text)
{
    System.Console.WriteLine("Введите число : ");
    return Convert.ToInt32(Console.ReadLine());
}

// 2. Создание массива
int[] CreateArray(int size)
{
    return new int[size];
}

// 3. Заполнение массива 
void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(10);
    }
}

// 4. Метод получения произведений пар чисел и вывода нового массива
int[] Mult(int[] array)
{
    int length = array.Length;
    int[] newArray = new int[length / 2]; 
    if (length % 2 != 0)
    {
        newArray = new int[length / 2 + 1]; 
    }
    for (int i = 0; i < length; i++)
    {
        newArray[i] = array[i] * array[length - 1];
        length--;
    }
    return newArray;
}

// 5. Распечатать результат
string GoodPrint(int[] array, int[] newArray)
 {
    return $"{String.Join(", ", array)} >> {String.Join(" ", newArray)}";
 }

int n = GetNumberByUser("");
int[] arr = CreateArray(n);
FillArray(arr);

int[] newArr = Mult(arr);
System.Console.WriteLine(GoodPrint(arr, newArr));
