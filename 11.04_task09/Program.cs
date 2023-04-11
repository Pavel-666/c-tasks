//9. Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8


int number = new Random().Next(10, 100);

Console.WriteLine($"случайное число {number}");
int firstDigit = number / 10;
int secondGigit = number % 10;
// if (FirstDigit > SecondGigit)
//     Console.WriteLine($"наибольшая цифра {FirstDigit}");
// else Console.WriteLine($"наибольшая цифра {SecondGigit}");


// int maxDigit = firstDigit > secondGigit ? firstDigit : secondGigit;
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondGigit = num % 10;
    int maxDigit = firstDigit > secondGigit ? firstDigit : secondGigit;
    return maxDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");
