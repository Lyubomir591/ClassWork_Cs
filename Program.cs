// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// int numbers = Convert.ToInt32(Console.ReadLine());
// string number = numbers.ToString();
// Console.WriteLine(number[1]);


//Заача 2
// Console.WriteLine("Задание 2");

// string numberUser = Console.ReadLine();
// Console.WriteLine(numberUser[1]);
// int? pol = null;
// bool ted = false;

// if (numb[2] == pol)
// {
//     ted = true;
// }

// if (ted)
// {
//     Console.WriteLine("Нет числа");
// }
// else
// {
//   Console.WriteLine($"{numb[2]}");
// }
int a = Convert.ToInt32(Console.ReadLine());
int b = 10;
if (a >= 100)
{
    a %= b;
    Console.Write(a);
}
else
{
    Console.WriteLine("Нет  третьей цифры");
}
