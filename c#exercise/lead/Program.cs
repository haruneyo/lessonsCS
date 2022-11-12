// 41. Выяснить являются ли три числа сторонами треугольника 
// Console.WriteLine("Enter three numbers:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DoNumbersBelongToTriangleSides(num1, num2, num3));
// bool DoNumbersBelongToTriangleSides(int a, int b, int c)
// {
//     if (a > b + c || b > a + c || c > a + b) return false;
//     else return true;
// }
/// 42. Определить сколько чисел больше 0 введено с клавиатуры
/// System.Console.WriteLine("Specify how many numbers to enter:");
/// int m = Convert.ToInt32(Console.ReadLine());
/// int[] array = new int[m];
/// FillArray(array);
/// System.Console.WriteLine($"The amount of numbers bigger than zero in the array is: {BiggerThanZero(array)}");
/// void FillArray(int[] a)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         System.Console.WriteLine($"Enter the {i + 1} number:");
///         a[i] = Convert.ToInt32(Console.ReadLine());
///     }
/// }
/// int BiggerThanZero(int[] a)
/// {
///     int count = 0;
///     for (int i = 0; i < a.Length; i++)
///     {
///         if (a[i] > 0) count++;
///     }
///     return count;
/// }
// DOES NOT WORK CORRECTLY 43. Написать программу преобразования десятичного числа в двоичное
// System.Console.WriteLine("Enter a number to convert to binary:");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[ArrayElements(number)];
// FillArray(array, number);
// System.Console.Write($"The number {number} in binary is: ");
// PrintArray(array);
// int ArrayElements(int num)
// {
//     int count = 2;
//     while (num / 2 != 1)
//     {
//         num = num / 2;
//         count++;
//     }
//     return count;
// }
// void FillArray(int[] a, int num)
// {
//     for (int i = a.Length - 1; i > 0; i--)
//     {
//         a[i] = num % 2;
//     }
//     a[0] = 1;
// }
// void PrintArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         System.Console.Write(a[i]);
//     }
// }
/// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
/// System.Console.WriteLine("Enter k1, b1, k2, b2:");
/// double k1 = Convert.ToDouble(Console.ReadLine());
/// double b1 = Convert.ToDouble(Console.ReadLine());
/// double k2 = Convert.ToDouble(Console.ReadLine());
/// double b2 = Convert.ToDouble(Console.ReadLine());
/// FindPointOfIntersection (k1, b1, k2, b2);
/// void FindPointOfIntersection(double k1, double b1, double k2, double b2)
/// {
///     double x = (b2 - b1) / (k1 - k2);
///     double y = k1 * x + b1;
///     x = Math.Round(x, 3);
///     y = Math.Round(y, 3);
///     System.Console.WriteLine($"Two lines (y = k1 * x + b1) and (y = k2 * x + b2) intersect at [{x}, {y}]");
/// }
// 45. Показать числа Фибоначчи
// int Fibonacci(int num)
// {
//     if (num == 1 || num == 2) return 1;
//     else return Fibonacci(num-1) + Fibonacci(num-2);
// }
// for (int i = 1; i < 10; i++)
// {
//     System.Console.WriteLine(Fibonacci(i));
// }
/// 46. Написать программу масштабирования фигуры
/// double[] shape = new double[8];
/// FillArray(shape, 0, 10);
/// PrintArray(shape);
/// Resize(shape, .5);
/// PrintArray(shape);
/// void FillArray(double[] a, int min, int max)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         a[i] = new Random().Next(min, max + 1);
///     }
/// }
/// void PrintArray(double[] a)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         System.Console.Write($"{a[i]} ");
///     }
///     System.Console.WriteLine();
/// }
/// void Resize(double[] a, double amount)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         a[i] *= amount;
///     }
/// }
// 47. Написать программу копирования массива
// int[] array = new int[5];
// FillArray(array, 0, 10);
// PrintArray(array);
// PrintArray(CopyArray(array));
// void FillArray(int[] a, int min, int max)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = new Random().Next(min, max + 1);
//     }
// }
// void PrintArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         System.Console.Write($"{a[i]} ");
//     }
//     System.Console.WriteLine();
// }
// int[] CopyArray(int[] array)
// {
//     int[] copy = new int[array.Length];
//     for (int i = 0; i < copy.Length; i++)
//     {
//         copy[i] = array[i];
//     }
//     return copy;
// }