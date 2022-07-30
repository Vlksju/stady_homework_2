Console.WriteLine("Программа которая выводит третью цифру числа");
Console.WriteLine("Введите число");

int number1 = Convert.ToInt32(Console.ReadLine ());

number1 = Math.Abs (number1);

if (number1<100){
    Console.WriteLine("В числе нет третьей цифры");
}
else {
    while (number1 > 999) {
        number1 = number1 / 10;
    }
    Console.WriteLine (number1 % 10);
}
