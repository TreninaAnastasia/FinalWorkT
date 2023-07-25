// Задача: Написать программу, которая из имеющегося массива
//  строк формирует новый массив из строк, длина которых меньше, 
//  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

Console.WriteLine("Введите значение элемента 1");
string first = Console.ReadLine()!;
Console.WriteLine("Введите значение элемента 2");
string second = Console.ReadLine()!;
Console.WriteLine("Введите значение элемента 3");
string third = Console.ReadLine()!;


string[] Array = Main(first,second,third); 
SecondArray(Array);

static string[] Main ( string first, string second, string third)
{
    List<string> list = new List <string> { first, second, third};
    string[] array = list.ToArray();
    return array;
}

static void SecondArray( string[] Array)
{
    int count = 0;
    string[] secondArray = new string[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        if ( Array[i].Length < 3)
        {
            secondArray[count] = Array[i];
            count += 1;
        }
        else if (Array[i].Length == 3)
        {
            secondArray[count] = Array[i];
            count += 1;
        }
    }
    Console.WriteLine(String.Join(" ", secondArray));
}
