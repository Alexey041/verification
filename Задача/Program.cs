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

        // добавить последнюю введенную строку в массив AS2
        arrayCopy[size - 1] = input;

        // перенаправить ссылку AS на AS2
        array = arrayCopy;
    }

} while (input != "");

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        countFind++;
}

resultArray = new string[countFind];

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

