Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());

int number2sqere = number2 * number2;
if ( number2sqere == number1 ) 
    Console.WriteLine("все верно") ;
else Console.WriteLine("кажется, где то ошибка");