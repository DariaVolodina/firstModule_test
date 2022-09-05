// Задача: 
// "Написать программу, которая из имеющегося массива строк формирует 
//массив из строк, длина которых меньше либо равна 3 символа."

void ShowArray (string [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");

    Console.Write(array[array.Length - 1] + ".");
    Console.WriteLine(); 
    Console.WriteLine();
}

string [] SelectFromArray(string [] array, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i].Length <= max)
            count++;

    string [] newArray = new string [count];

    for (int i = 0, ii = 0; i < array.Length; i++)
        if(array[i].Length <= max)
        {
            newArray[ii] = array[i];
            ii++;
        }    

    return newArray;
}

string[] CreateArray (int size) 
{
    string [] array = new string [size];

    Console.Write("Input first element of the array: ");
    array[0] = Console.ReadLine();

    for (int i = 1; i < size; i++)
    {
        Console.Write("Input nest element: ");
        array[i] = Console.ReadLine(); 
    }

    return array;
}


Console.Write("Input size of array: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
string [] array = CreateArray (sizeOfArray);

//string[] array1 = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "Russia", "Denmark", "Kazan"}; // массив задан в примере задачи

ShowArray(array);

int numberOfSymbols = 3;
string [] newArray = SelectFromArray(array, numberOfSymbols);
ShowArray(newArray);
