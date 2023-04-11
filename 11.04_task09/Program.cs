//9. Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8


int number = new Random().Next(10, 100);

Console.WriteLine($"случайное число {number}");
int FirstDigit = number / 10;
int SecondGigit = number % 10;
if (FirstDigit > SecondGigit)
    Console.WriteLine($"наибольшая цифра {FirstDigit}");
else Console.WriteLine($"наибольшая цифра {SecondGigit}");