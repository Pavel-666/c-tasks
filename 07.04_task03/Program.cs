Сonsole.WriteLine("Введите порядковый номер дня недели");
int NumberDay = Convert.ToInt32(Console.ReadLine());

if (NumberDay == 1)
    Console.WriteLine("понедельник");
if (NumberDay == 2)
    Console.WriteLine("вторник");
if (NumberDay == 3)
    Console.WriteLine("среда");
if (NumberDay == 4)
    Console.WriteLine("четверг");
if (NumberDay == 5)
    Console.WriteLine("пятница");
if (NumberDay == 6)
    Console.WriteLine("суббота");
if (NumberDay == 7)
    Console.WriteLine("воскресение");
else Console.WriteLine("такого дня недели нет");