// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int numbers = Convert.ToInt32(Console.ReadLine());
// string number = numbers.ToString();
// Console.WriteLine(number[1]);


// // задача2
// int a = Convert.ToInt32(Console.ReadLine());
// int b = 10;
// if (a >= 100 && a <= 1000)
// {
//     a %= b;
//     Console.Write(a);
// }
// else if (a > 1000)
// {
//     string numb = a.ToString();
//     Console.WriteLine(numb[2]);
// }
// else
// {
//     Console.WriteLine("Нет  третьей цифры");
// }
// Задача 3

// int[] arrDay = { 1, 2, 3, 4, 5, 6, 7 };
// Console.WriteLine("Введите цифру обозначающую день недели");
// int nuberDeyUser = Convert.ToInt32(Console.ReadLine());
// bool day = false;
// if (nuberDeyUser == 6 || nuberDeyUser == 7)
// {
//     day = true;
// }

// foreach (var item in arrDay)
// {
//     if (item == nuberDeyUser)
//     {
//         if (day)
//         {
//             Console.WriteLine("Выходной день");
//         }
//         else
//         {
//             Console.WriteLine("Рабочий день");
//         }

//     }
// }
//Задание 4
// int[] numbersArrUser = new int[8];

// for (int counter = 0; counter < numbersArrUser.Length; counter++)
// {
//     Console.WriteLine($"Введите {counter + 1}-е число");
//     numbersArrUser[counter] = Convert.ToInt32(Console.ReadLine());


// }
// int sum = 0;
// foreach (var item in numbersArrUser)
// {

//     sum = item + sum;

// }
// Console.WriteLine($"Средняя {sum / numbersArrUser.Length}");