Console.Clear();
int StringLenght(string[] arr) // Ищем строки <= 3 символа.
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}
string[] NewArray(string[] arr, int count) //Формируем итоговый массив.
{
    string[] arrNew = new string[count];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrNew[arrNew.Length - count] = arr[i];
            count--;
        }
    }
    return arrNew;
}
string[] array = new string[] {"Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};
Console.WriteLine($"Начальный массив: [{string.Join(" , ", array)}]");
int stringLenght = StringLenght(array);
string[] newArray = NewArray(array, stringLenght);
Console.WriteLine($"Итоговый массив: [{string.Join(" , ", newArray)}]");



 