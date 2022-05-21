void GetSumOfDigits()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int div = num;
    int mult;
    int sum = 0;

    for (num = div; div != 0; div = div / 10)
    {
        mult = div % 10;
        sum = sum + mult;
    }
    Console.WriteLine($"Сумма цифр числа {num} равна {sum}");
}

GetSumOfDigits();
Console.ReadLine();