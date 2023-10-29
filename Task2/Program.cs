int[] GenerateArray()
{
    string[] str;
    Console.WriteLine("Введите 3 числа через , ");
    str = Console.ReadLine().Split(",");

    int[] array = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        array[i] = Convert.ToInt32(str[i]);
    }

    return array;
}


void CheckTriangle(int[] array)
{
    int summa = 0;
    for(int i = 0; i < array.Length; i++)
    {
        summa += array[i];
    }
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= summa - array[i])
        {
            Console.WriteLine("Error!");
            return;
        } 

    }
    Console.WriteLine("Треугольник с такими сторонами может существовать");
}


int[] array = GenerateArray();
CheckTriangle(array);
