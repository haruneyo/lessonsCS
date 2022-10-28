// 0. Вывести квадрат числа
// double squareA = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine(squareA * squareA);

/// 1. По двум заданным числам проверять является ли первое квадратом второго
/// double square = Convert.ToDouble(Console.ReadLine());
/// double num = Convert.ToDouble(Console.ReadLine());
/// if (square / num == num) System.Console.WriteLine(true);
/// else System.Console.WriteLine(false);

// 2. Даны два числа. Показать большее и меньшее число
// double numA = Convert.ToDouble(Console.ReadLine());
// double numB = Convert.ToDouble(Console.ReadLine());
// if (numA > numB)
// {
//     System.Console.WriteLine(numA + " is bigger.");
//     System.Console.WriteLine(numB + " is smaller.");
// }
// else
// {
//     System.Console.WriteLine(numB + " is bigger.");
//     System.Console.WriteLine(numA + " is smaller.");
// }

/// 3. По заданному номеру дня недели вывести его название
/// string[] dow = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
/// System.Console.WriteLine("Please enter the number of the week:");
/// int index = Convert.ToInt32(Console.ReadLine()) - 1;
/// if (index >= 0 && index <= 6) System.Console.WriteLine(dow[index]);
/// else System.Console.WriteLine(-1);

// 4. Найти максимальное из трех чисел
// double[] array = new double[3];
// System.Console.WriteLine("Enter three numbers:");
// for (int i = 0; i < 3; i++)
// {
//     array[i] = Convert.ToDouble(Console.ReadLine());
// }
// System.Console.WriteLine("The biggest number is: " + array.Max());

/// 5. Написать программу вычисления значения функции y = f(a), f(a) = a + a*2
/// System.Console.WriteLine("Enter number a:");
/// double a = Convert.ToDouble(Console.ReadLine());
/// double f = a + a * 2;
/// System.Console.WriteLine(f);

// 6. Выяснить является ли число чётным
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0) System.Console.WriteLine(true);
// else System.Console.WriteLine(false);

/// 7. Показать числа от -N до N
/// int start = new Random().Next(-100, 0);
/// int end = new Random().Next(0, 100);
/// for (int i = start; i < end; i++)
/// {
///     System.Console.WriteLine(i);
/// }

// 8. Показать четные числа от 1 до N
// int end = new Random().Next(2, 100);
// for (int i = 2; i <= end ; i += 2)
// {
//     System.Console.WriteLine(i);
// }

/// 9. Показать последнюю цифру трёхзначного числа
/// int num = new Random().Next(100, 1000);
/// int digit = num % 10;
/// System.Console.WriteLine("The number is: " + num);
/// System.Console.WriteLine("The last digit of the number is: " + digit);

// 10. Показать вторую цифру трёхзначного числа
// int num = new Random().Next(100, 1000);
// int newNum = num / 10;
// int digit = newNum % 10;
// System.Console.WriteLine("The number is: " + num);
// System.Console.WriteLine("The last digit of the number is: " + digit);

/// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
/// int num = new Random().Next(10, 100);
/// System.Console.WriteLine("The number is: " + num);
/// int tenDigit = num / 10;
/// int digit = num % 10;
/// if (tenDigit > digit) System.Console.WriteLine("The biggest is: " + tenDigit);
/// else System.Console.WriteLine("The biggest is: " + digit);

// 12. Удалить вторую цифру трёхзначного числа
// int num = new Random().Next(100, 1000);
// int hunDigit = num / 100;
// int digit = num % 10;
// System.Console.WriteLine("The number is: " + num);
// System.Console.WriteLine("The new number is " + Convert.ToString(hunDigit) + Convert.ToString(digit));

/// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток
/// System.Console.WriteLine("Enter the number:");
/// int num = Convert.ToInt32(Console.ReadLine());
/// System.Console.WriteLine("Enter the divisor:");
/// int divisor = Convert.ToInt32(Console.ReadLine());
/// int result = num % divisor;
/// if (result == 0) System.Console.WriteLine(true);
/// else System.Console.WriteLine(result);

// 14. Найти третью цифру числа или сообщить, что её нет
// int num = new Random().Next(0, 10000);
// System.Console.WriteLine("The number is: " + num);
// if (num < 100) System.Console.WriteLine("The number is less than 3 digits");
// else
// {
//     int newNum = num / 100;
//     int thirdDigit = newNum % 10;
//     System.Console.WriteLine("The third digit from the right is: " + thirdDigit);
// }