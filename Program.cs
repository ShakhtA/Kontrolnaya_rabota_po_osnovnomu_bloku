// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//  Примеры:
//  [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//  [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//  [“Russia”, “Denmark”, “Kazan”] → []

    Console.Clear();
    int sizeArray = new Random().Next(5, 10); 
    
    string[] text = new string[sizeArray];
    FillArray(text);
    int sizeNewArray = GetSizeNewArray(text);    
    string[] correctedText = new string[sizeNewArray];
    FillCorrectedText(text, correctedText);

    PrintResult(text, correctedText);

//===================БЛОК ОПИСАНИЙ===============

void FillArray(string[] arr)
{
    for (int i = 0; i < text.Length; i++)
    {
        Console.Write("Введите строку: ");
        arr[i] = Console.ReadLine();
    }
}
   
int GetSizeNewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
            count++;
    }
    return count;
}
   
void FillCorrectedText(string[] arr, string[] newArr)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length < 4)
        {
            newArr[j] = arr[i];
            j++;
        }
}

void PrintResult(string[] arr, string[] newArr)
{
    Console.Write($"[\"{String.Join("\", \"", arr)}\"] -> [\"{String.Join("\", \"", newArr)}\"]");
    Console.WriteLine();
}
