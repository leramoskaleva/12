// // Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше, либо равно 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться 
//коллекциями, лучше обойтись исключительно массивами. 
//Примеры: 
//["hello", "2", "world", ":-)"] 
//["1234", "1567", "-2", "computer science"] ->["-2] 
//["Russia", "Denmark", "Kazan"] ->[]

string Promt(string message)
{
    Console.Write(message);
    return Console.ReadLine()?? String.Empty;
}

string[] CreateStringMassive(string[] array, int value, int length = 0)
{
    string[] Temp = new string[length];
    if (value <=3)
    {
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= value)
        {
            if (Temp.Length > 0 && j < Temp.Length)
            {
                Temp[j] = array[i];
                j++;
            }
            length++;
        }
    }
    }
    else
    {
        Console.Write("длина строки не может быть больше 3! ");
    } 

    if (length > 0 && Temp.Length <= 0) 
    return CreateStringMassive(array, value, length);
    return Temp;
}


string[] FillTheMassive(int lenght)
{
    string[] arr = new string[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Promt($"Введите любое значение в элемент {i} массива");
    }
    return arr;
}

int lenght = Convert.ToInt32(Promt("Введите длину массива "));
int value = Convert.ToInt32(Promt("Введите длину строки (длина строки должна быть меньше или равна 3! )"));
string[] arr = FillTheMassive(lenght);

Console.Write($"[{string.Join(", ", arr)}] -> [{string.Join(", ",CreateStringMassive(arr, value))}]");
