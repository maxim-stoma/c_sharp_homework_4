Console.WriteLine("Статичный массив случайных чисел от 0 до 99: ");

void SetArray(int[] variety)
{
    int length = variety.Length;
    int index = 0;

    for (index = 0; index < length; index++)
    {
        variety[index] = new Random().Next (0, 100);
    }
}

void PrintArray(int[] multitude)
{
    int dimention = multitude.Length;
    int pos = 0;

    Console.Write("[ ");
    for (pos = 0; pos < dimention; pos++)
    {
        Console.Write(multitude[pos]);
        if (pos != dimention - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
}

int[] array = new int[8];

SetArray(array);
PrintArray(array);
Console.ReadLine();