// // Написать программу, которая из имеющегося массива строк формирует
// массив из срок, длина которых меньше, лиюо равно 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться 
//коллекциями, лучше обойтись исключительно массивами. 
//Примеры: 
//["hello", "2", "world", ":-)"] 
//["1234", "1567", "-2", "computer science"] ->["-2] 
//["Russia", "Denmark", "Kazan"] ->[]

string[] CreateMassive(string[] array, int value, int length = 0)
{
    string[] arr = new string[length];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= value)
        {
            if (arr.Length > 0 && j < arr.Length)
            {
                arr[j] = array[i];
                j++;
            }
            length++;
        }
    }

    if (length > 0 && arr.Length <= 0)
    return CreateMassive(array, value, length);

    return arr;
}
