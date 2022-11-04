// 23. Показать таблицу квадратов чисел от 1 до N 
// double n = Convert.ToDouble(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     double square = Math.Pow(i, 2);
//     System.Console.WriteLine(square);
// }

/// 24. Найти кубы чисел от 1 до N
/// int n = Convert.ToInt32(Console.ReadLine());
/// for (int i = 1; i <= n; i++)
/// {
///     double square = Math.Pow(i, 3);
///     System.Console.WriteLine(square);
/// }

// 25. Найти сумму чисел от 1 до А
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= a; i++)
// {
//     sum = sum + i;
// }
// System.Console.WriteLine(sum);

/// 26. Возведите число А в натуральную степень B используя цикл
/// int a = Convert.ToInt32(Console.ReadLine());
/// int b = Convert.ToInt32(Console.ReadLine());
/// int result = 1;
/// if (b == 0) System.Console.WriteLine(result);
/// else
/// {
///     for (int i = 1; i <= b; i++)
///     {
///         result = result * a;
///     }
///     System.Console.WriteLine(result);
/// }

// 27. Определить количество цифр в числе
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// if (num > 0)
// {
//     for (int i = 10; i <= num; i = i * 10)
//     {
//         count++;
//     }
// }
// else
// {
//     for (int i = -10; i >= num; i = i * 10)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine(count);

/// 28. Подсчитать сумму цифр в числе
/// int num = Convert.ToInt32(Console.ReadLine());
/// int sum = 0;
/// if (num > 0)
/// {
///     for (int i = 1; num >= 1; i++)
///     {
///         int digit = num % 10;
///         sum += digit;
///         num /= 10;
///     }
/// }
/// else
/// {
///     for (int i = 1; num <= -1; i++)
///     {
///         int digit = num % 10;
///         sum += digit;
///         num /= 10;
///     }
///     sum *= -1;
/// }
/// System.Console.WriteLine(sum);

// 29. Написать программу вычисления произведения чисел от 1 до N
// int n = Convert.ToInt32(Console.ReadLine());
// int product = 1;
// for (int i = 1; i <= n; i++)
// {
//     product *= i;
// }
// System.Console.WriteLine(product);

/// 30. Показать кубы чисел, заканчивающихся на четную цифру
/// System.Console.WriteLine("Enter the amount of numbers to generate:");
/// int count = Convert.ToInt32(Console.ReadLine());
/// double[] array = new double[count];
/// for (int i = 0; i < count; i++)
/// {
///     double a = new Random().Next(1, 11);
///     array[i] = a;
///     System.Console.WriteLine("The " + i + " index is: " + array[i]);
/// }
/// for (int i = 0; i < array.Length; i++)
/// {
///     if (array[i] % 2 == 0)
///     {
///          double pow3 = Math.Pow(array[i], 3);
///          System.Console.WriteLine("The " + array[i] + "'s power of three is: " + pow3);
///     }
/// }
