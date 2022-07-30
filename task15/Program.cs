Console.WriteLine("Программа которая определяет буднитй или");
Console.WriteLine("выходной по номеру дня неделт.");

Console.WriteLine("Введите номер дня недели");

int number1 = Convert.ToInt32(Console.ReadLine ());

if (number1 >= 8) {
    Console.WriteLine("Дня недели с таким номером не существует");
}
else {
    if (number1 == 6 | number1 == 7) {
       Console.WriteLine("Выходной день"); 
    }
    else {
        Console.WriteLine("Будний день");
    }
}
