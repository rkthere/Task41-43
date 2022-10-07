//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива:");
int len = int.Parse(Console.ReadLine()!);
int[] arr = new int[len];
Console.WriteLine("Введите случайны числа через запятую, в соответствие указанному размеру массива:");
string[] arrayNumber = Console.ReadLine()!.Split(',');

int CheckNumber(int[] arr)
{
    int NumbersGreaterThenZero = 0;
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        arr[i] = int.Parse(arrayNumber[i]);
        if(arr[i] > 0)
        {
            NumbersGreaterThenZero++;
        }  
    }
     return NumbersGreaterThenZero;
}
int result = CheckNumber(arr);
Console.WriteLine($"Количество элементов больше 0 -> {result}");

