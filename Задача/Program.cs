Console.Clear();

int size = 0; 
int countFind = 0;
string[] array = new string[size]; 
string[] arrayCopy; 
string input;
string[] resultArray;

Console.WriteLine("Введите строки: ");  

do 
{
    input = Console.ReadLine()!;
    if (input != "")
    {
        size++;
        arrayCopy = new string[size];

        // скопировать старый массив в новый
        for (int i = 0; i < arrayCopy.Length - 1; i++)
            arrayCopy[i] = array[i];

        // добавить последнюю введенную строку в массив arrayCopy
        arrayCopy[size - 1] = input;

        // перенаправить ссылку array на arrayCopy
        array = arrayCopy;
    }

} while (input != "");

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        countFind++;
}

resultArray = new string[countFind];

PrintArray(array);
FillArray(resultArray,array);
Console.Write(" => ");
bool zeroFind = resultArray.Length > 0; 

if (zeroFind)
{
    PrintArray(resultArray);
}
else
{
    PrintArray(resultArray);
    Console.Write("]");
}


void FillArray(string[] resultArray, string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[count] = array[i];
            count++;
        }       
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}]");
    }
}