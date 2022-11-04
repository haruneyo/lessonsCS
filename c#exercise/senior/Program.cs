// 31. Задать массив из 8 элементов и вывести их на экран 
// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);
// void FillArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = new Random().Next(-100, 100);
//     }
// }
// void PrintArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         System.Console.WriteLine($"The {i} index is: {a[i]}");
//     }
// }

/// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
/// int[] array = new int[8];
/// FillArray(array);
/// PrintArray(array);
/// void FillArray(int[] a)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         a[i] = new Random().Next(0, 2);
///     }
/// }
/// void PrintArray(int[] a)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         System.Console.WriteLine($"The {i} index is: {a[i]}");
///     }
/// }

// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива
// int[] array = new int[12];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine(SumPosArray(array));
// System.Console.WriteLine(SumNegArray(array));
// void FillArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = new Random().Next(-9, 10);
//     }
// }
// void PrintArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         System.Console.WriteLine($"The {i} index is: {a[i]}");
//     }
// }
// int SumPosArray(int[] a)
// {
//     int sum = 0;
//     for (int i = 0; i < a.Length; i++)
//     {
//         if (a[i] > 0) sum += a[i];
//     }
//     return sum;
// }
// int SumNegArray(int[] a)
// {
//     int sum = 0;
//     for (int i = 0; i < a.Length; i++)
//     {
//         if (a[i] < 0) sum += a[i];
//     }
//     return sum;
// }

/// 34. Написать программу замену элементов массива на противоположные
/// int[] array = new int[12];
/// FillArray(array);
/// PrintArray(array);
/// ReverseArrayNumber(array);
/// PrintArray(array);
/// void FillArray(int[] a)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         a[i] = new Random().Next(-9, 10);
///     }
/// }
/// void PrintArray(int[] a)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         System.Console.WriteLine($"The {i} index is: {a[i]}");
///     }
/// }
/// void ReverseArrayNumber(int[] a)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         a[i] = -a[i];
///     }
/// }

// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// int[] array = new int[12];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine(IsNumberInArray(array, 5));
// void FillArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = new Random().Next(0, 10);
//     }
// }
// void PrintArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         System.Console.WriteLine($"The {i} index is: {a[i]}");
//     }
// }
// bool IsNumberInArray(int[] a, int number)
// {
//     bool flag = false;
//     for (int i = 0; i < a.Length; i++)
//     {
//         if (a[i] == number)
//         {
//             flag = true;
//             break;
//         }
//     }
//     return flag;
// }

/// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
/// int[] array = new int[6];
/// FillArray(array);
/// PrintArray(array);
/// System.Console.WriteLine($"The amount of even numbers in the array is: {NumberOfEvenInArray(array)}");
/// System.Console.WriteLine($"The amount of uneven numbers in the array is: {NumberOfUnevenInArray(array)}");
/// void FillArray(int[] a)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         a[i] = new Random().Next(100, 1000);
///     }
/// }
/// void PrintArray(int[] a)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         System.Console.WriteLine($"The {i} index is: {a[i]}");
///     }
/// }
/// int NumberOfEvenInArray(int[] a)
/// {
///     int count = 0;
///     for (int i = 0; i < a.Length; i++)
///     {
///         if (a[i] % 2 == 0) count++;
///     }
///     return count;
/// }
/// int NumberOfUnevenInArray(int[] a)
/// {
///     int count = 0;
///     for (int i = 0; i < a.Length; i++)
///     {
///         if (a[i] % 2 != 0) count++;
///     }
///     return count;
/// }

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// int[] array = new int[123];
// FillArray(array);
// System.Console.WriteLine($"There are {FindCertainNumbersInArray(array, 10, 99)} numbers in the range [10, 99]");
// void FillArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = new Random().Next(0, 1000);
//     }
// }
// int FindCertainNumbersInArray(int[] a, int min, int max)
// {
//     int count = 0;
//     for (int i = 0; i < a.Length; i++)
//     {
//         if (a[i] >= min && a[i] <= max)
//         {
//             System.Console.WriteLine($"The {i} index is number: {a[i]}");
//             count++;
//         }
//     }
//     return count;
// }

/// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
/// int[] array = new int[12];
/// FillArray(array);
/// PrintArray(array);
/// System.Console.WriteLine($"The sum of uneven elements in the array is: {SumOfUnevenIndexInArray(array)}");
/// void FillArray(int[] a)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         a[i] = new Random().Next(0, 100);
///     }
/// }
/// void PrintArray(int[] a)
/// {
///     for (int i = 0; i < a.Length; i++)
///     {
///         System.Console.WriteLine($"The {i} index is: {a[i]}");
///     }
/// }
/// int SumOfUnevenIndexInArray(int[] a)
/// {
///     int sum = 0;
///     for (int i = 1; i < a.Length; i += 2)
///     {
///         sum += a[i];
///     }
///     return sum;
/// }

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// int[] array = new int[11];
// FillArray(array);
// PrintArray(array);
// ProductOfPairsInArray(array);
// void FillArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = new Random().Next(0, 10);
//     }
// }
// void PrintArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         System.Console.WriteLine($"The {i} index is: {a[i]}");
//     }
// }
// void ProductOfPairsInArray(int[] a)
// {
//     int product;
//     int rightIndex = a.Length - 1;
//     for (int i = 0; i < rightIndex - i; i++)
//     {
//         product = a[i] * a[rightIndex - i];
//         System.Console.WriteLine($"The product of {i} index and {rightIndex - i} is: {product}");
//     }
// }

/// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
/// double[] array = { -28.82, 39.31, -7, 36, 78.38, -56.9, 34.2 };
/// double max = MaxInArray(array);
/// double min = MinInArray(array);
/// System.Console.WriteLine(DifferenceMaxMin(max, min));
/// double MaxInArray(double[] a)
/// {
///     double max = a[0];
///     for (int i = 1; i < a.Length; i++)
///     {
///         if (a[i] > max) max = a[i];
///     }
///     return max;
/// }
/// double MinInArray(double[] a)
/// {
///     double min = a[0];
///     for (int i = 1; i < a.Length; i++)
///     {
///         if (a[i] < min) min = a[i];
///     }
///     return min;
/// }
/// double DifferenceMaxMin(double maxNumber, double minNumber)
/// {
///     double difference = maxNumber - minNumber;
///     return difference;
/// }
