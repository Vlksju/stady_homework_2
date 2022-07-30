Console.WriteLine("Программа которая вычисляет вторую цифру трехзначного числа");
Console.WriteLine("Введите трехзначное число");

int number1 = Convert.ToInt32(Console.ReadLine ());

int digit = number1 /10 % 10;

Console.WriteLine(digit);