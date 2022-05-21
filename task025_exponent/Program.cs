void Exponentiation()
{
    Console.Write("Введите число, которое нужно возвести в степень: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите степень: ");
    int power = Convert.ToInt32(Console.ReadLine());
    
    double result = 1;

    if (power == 0)
    {
        Console.WriteLine($"Число {number} в степени {power} равно {result}");
    }
    else
    {
        for (int i = 0; i != power; i++)
        {
        result = result * number;
        }
        Console.WriteLine($"Число {number} в степени {power} равно {result}");
    }
}

Exponentiation();
Console.ReadLine();