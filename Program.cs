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
// Классная работа(Function)
// Задача
// Создать метод который создает длинну массива.
// Создать метод которыйы возвращает массив с длинной и записывает в него новые значения 
// Создать меетод который автоматом принимает новый массив 

// int LengthArr(int min, int max)
// {

//     int lenta = new Random().Next(min, max);

//     return lenta;
// }
// int lengtharr = LengthArr(15, 25);
// int[] Arrey()
// {

//     int[] arr = new int[lengtharr];


//     return arr;
// }

// int[] massNewArry(int[] arr, int min, int max)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next(min, max);
//     }
//     return arr;
// }
// int[] arr = Arrey();
// massNewArry(arr, 25, 50);
// void ConsoleArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }
// ConsoleArr(arr);

// void MethodArr(int[] arry)
// {
//     int length = arry.Length;

//     for (int i = 0; i < length; i++)
//     {
//         int minnumber = i;
//         for (int j = 0 + i; j < length; j++)
//         {
//             if (arry[j] < arry[minnumber])
//             {
//                 minnumber = j;
//             }
//         }
//         int numberarr = arry[i];
//         arry[i] = arry[minnumber];
//         arry[minnumber] = numberarr;
//         Console.Write($"({arry[i]} )");

//     }
// }

// MethodArr(arr);




// int[] arr = { 99,1,343,2,55,5,5,5,23,1,47,12};
// void integro(int[] arrIng)
// {
//     int length = arrIng.Length;
//     for (int i = 0; i < length; i++)
//     {
//         int minnumber = i;
//         for (int j = 0 + i; j < length; j++)
//         {
//             if (arrIng[j] < arrIng[minnumber])
//             {
//                 minnumber = j;
//             }
//         }
//         int arrnumb = arrIng[i];
//         arrIng[i] = arrIng[minnumber];
//         arrIng[minnumber] = arrnumb;
//         Console.Write(arrIng[i]);
//     }

// }
// integro(arr);
// integro(arr);
// void mask(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }
// mask(arr);

// string text = " Взяла старуха крылышко, по коробу поскребла, по сусеку помела и наскребла муки горсти две." + " Жили-были старик со старухой." + " Вот и говорит старик старухе: ";

// string Texter(string txxt, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = txxt.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (txxt[i] == oldValue)
//         {
//             result = result + $"{newValue}";
//         }
//         else
//         {
//             result = result + $"{txxt[i]}";
//         }
//     }
//     return result;

// }
// string tex = Texter(text, 'к', 'К');
// Console.Write(tex);

//Задание №1

// Console.WriteLine("Введите полиндром :");
// int numberPOlendrom = Convert.ToInt32(Console.ReadLine());
// void Revers(int number)
// {
//     int copyNumber = number;
//     int result = 0;
//     while (number != 0)
//     {
//         int digit = number % 10;
//         result = result * 10 + digit;
//         number = number / 10;
//     }
//     if (result == copyNumber)
//     {
//         Console.WriteLine("Полиндром ");
//     }
//     else
//     {
//         Console.WriteLine("Не полиндром ");
//     }
// }
// Revers(numberPOlendrom);

// //  Задание № 3 
// Console.WriteLine("Введите число для подчета кубов ");
// int min = Convert.ToInt32(Console.ReadLine());

// void Cub(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = i * i * i;
//         Console.Write($"{sum} ");
//     }
// }
// Cub(min);
// Задание 2 
//Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Преременные двух точек с координатами условно обозначим А и Б 
// Создать метод для записи  как массив.
// double[][] Dablarr()
// {
//     double[][] mix = new double[2][];
//     mix[0] = new double[3];
//     mix[1] = new double[3];
//     int length = mix[0].Length;
//     for (int i = 0; i < length; i++)
//     {
//         Console.WriteLine("Введите координаты точки А");
//         mix[0][i] = Convert.ToInt32(Console.ReadLine());
//     }
//     for (int i = 0; i < length; i++)
//     {
//         Console.WriteLine("Введите координаты точки В");
//         mix[1][i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return mix;
// };

// double[][] arrT = Dablarr();


// void Function(double[][] arr)
// {
//     double sum = Math.Sqrt(Math.Pow(arr[1][0] - arr[0][0], 2) + Math.Pow(arr[1][1] - arr[0][1], 2) + Math.Pow(arr[1][2] - arr[0][2], 2));

//     Console.WriteLine(sum.ToString("F" + 2));
// }
// Function(arrT);

// Сщздать массив ;
// заполнить массив 
// Вывести массив 
// Вывести сколько эллементов находится в массиве  в диапазоне от 50 до 66

// int [] Create ( int letngth){
//     return new int [letngth];
// }

// void FillArray (int [] array, int min , int max){
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         array[i]= new Random().Next(min, max);
//     }
// }

// string OutputArray (int [] array){
//     return "[" + String.Join(' ',array) + "]";
// }

// void Amount ( int [] array, int min , int max  ){
//     int length = array.Length;
//     int count = 0;
//     for (int i = 0; i < length; i++)
//     {
//         if(array[i]>= min && array[i]<= max){
//             count++;
//         }
//     }
//     Console.Write(count);
// }
// int [] array = Create(12);
// FillArray(array, 10, 99 );
// Console.WriteLine(OutputArray(array));
// Amount(array, 40 , 55 );


// ЗАдайте одомерный   массив , заполните случайными числами , Найдите сумму эллементов стоящих на нечетных позицыях

// int [] Create ( int length){
//     return new int[length];
// }
// void FillArray ( int [] array, int min, int max ){
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(min,max);
//     }
// }
// string OutputArray(int [] array){
//     return "{" + String.Join(' ', array) + "}";
// }

// void SumArrayElement ( int [] array){
//     int length = array.Length;
//     int sum  = 0 ;
//     for (int i = 0; i < length; i++)
//     {
//         if(i % 2 > 0){
//             sum = sum + array[i-1];

//         }
//     }
//     Console.WriteLine(sum);
// }
// int [] array = Create(10);
// FillArray(array, 1, 10);
// Console.WriteLine(OutputArray(array));
// SumArrayElement(array);
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[,] array = new int[4, 4];
// void FillArray(int[,] array)
// {
//     int length = array.GetLength(0);
//     for (int i = 0; i < length; i++)
//         for (int j = 0; j < array.GetLength(1); i++)
//         {
//             array[i, j] = new Random().Next(1, 25);
//         }
//     {

//     }
// }
// void OutputArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 7);
//             Console.Write(array[i, j] + " ");
//         }

//     }
// }

// OutputArray(array);
// int[] Array = { 0, 1, 2, 3, 4, 4, 5, 5, 5, 6, 7, 1, 1, 4, 7, 9, 9, 9, 6 };
// int[] count = new int[Array.Max() + 1];
// int length = Array.Length;
// for (int i = 0; i < length; i++)
// {
//     count[Array[i]]++;
// }
// for (int j = 0; j < count.Length; j++)
// {
//     if (count[j] != 0)
//     {
//         Console.WriteLine($"{j} Встречается {count[j]} - раз");
//     }
// }
//_________________________________________________________________________________
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintData(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
        Console.Write($"{inputArray[i]} ");
    Console.WriteLine();
}

int[] GetData(string line)
{
    Console.WriteLine(line);
    string inputArray = Console.ReadLine() ?? "";
    string[] numberArray = inputArray.Split(", ");
    int[] numbers = new int[numberArray.Length];
    bool correctInput = false;
    for (int i = 0; i < numberArray.Length; i++)
        correctInput = int.TryParse(numberArray[i], out numbers[i]);
    if (!correctInput)
        Console.WriteLine("Введите корректное число");
    return numbers;
}

void PositiveNumbers(int[] inputArr)
{
    int sum = 0;
    for (int i = 0; i < inputArr.Length; i++)
    {
        if (inputArr[i] > 0)
            sum++;
    }
    Console.WriteLine($"чисел больше 0: {sum}");
}

int[] arr = GetData("Введите числа через запятую: ");
PrintData(arr);
PositiveNumbers(arr);