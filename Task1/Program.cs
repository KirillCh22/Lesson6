int[] GenerateArray()
{
    
    Console.WriteLine("Введите числа через , ");
    string input = Console.ReadLine();
    string[] arrayNumbers = input.Split(",");
    int[] numbers = new int[arrayNumbers.Length];
    for(int i  = 0; i < arrayNumbers.Length; i++)
    {
        numbers[i] = Convert.ToInt32(arrayNumbers[i]);
    }
    return numbers;
}


void PrintArray(int[] array)
{
    string str = String.Join(" ", array);
    Console.Write("Massiv - [");
    Console.Write(str);
    Console.Write("]");
}



void ReverseArray(int[] array)
{
    int temp;
    int last_index = array.Length - 1;
    for(int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[last_index - i];
        array[last_index - i] = temp;
    }
}

int[] array = GenerateArray();
PrintArray(array);
ReverseArray(array);
Console.WriteLine();
PrintArray(array);