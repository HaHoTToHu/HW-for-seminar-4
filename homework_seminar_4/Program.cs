/*Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в 
натуральную степень B.
(Math.Pow использовать нельзя!!!)*/
// void NumberDegree(int A, int B)
// {
//     int firstNumberDegree = A;
//     if (B != 0)
//     {
//        for (int i = 1; i < B; i++)
//         {
//          firstNumberDegree *= A;
//         }
//     Console.WriteLine($"{A} в степени {B} будет равно: {firstNumberDegree}");
//     }
//     else Console.WriteLine("Число в 0-ой степени всегда равно 1!");
// }

// Console.WriteLine("Введите первое число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int B = Convert.ToInt32(Console.ReadLine());

// NumberDegree(A, B);

/*Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)*/
// int summ = 0;
// int lastOne = 0;
// Console.WriteLine("Введите число: ");
// int digit = Convert.ToInt32(Console.ReadLine());
// void SumValues()
// {
//     for (int i = 0; i <= digit; i++)
//     {
//         lastOne = digit % 10;
//         summ += lastOne;
//         digit /= 10;
//     }
//     summ += digit;
// }
// SumValues();
// Console.WriteLine($"Сумма цифр в нашем числе равна: {summ}");

/*Задача 29: Напишите программу, которая задаёт массив из 
произвольного кол-ва элементов и выводит их на экран.*/
// int[] Array(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = Array(size, min, max);
// Console.WriteLine("Наш массив из произвольного кол-ва элементов:");
// ShowArray(array);