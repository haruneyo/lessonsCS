// 15. Дано число. Проверить кратно ли оно 7 и 23
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Checker(num));
// bool Checker(int x)
// {
//     int modOne = x % 7;
//     int modTwo = x % 23;
//     if (modOne == 0 && modTwo == 0) return true;
//     else return false;
// }

/// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
/// System.Console.WriteLine("Please enter the number of the day of the week:");
/// int num = Convert.ToInt32(Console.ReadLine());
/// if (num < 1 || num > 7) System.Console.WriteLine("This day of the week does not exist");
/// else System.Console.WriteLine("Is it the weekend? --> " + weekendCheck(num));
/// bool weekendCheck(int num)
/// {
///     if (num == 6 || num == 7) return true;
///     else return false;
/// }

// 17. По двум заданным числам проверять является ли одно квадратом другого
// int numOne = Convert.ToInt32(Console.ReadLine());
// int numTwo = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Square(numOne, numTwo));
// bool Square(int x, int y)
// {
//     if (y * y == x) return true;
//     else return false;
// }

/// ??? 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// int x = new Random().Next(-10, 11);
// int y = new Random().Next(-10, 11);
// System.Console.WriteLine(x);
// System.Console.WriteLine(y);
// if (x == 0 || y == 0) System.Console.WriteLine("Try again");
// else System.Console.WriteLine(FindQuadrant(x, y));
// string FindQuadrant(int a, int b)
// {
//     if (a > 0 && b > 0) return "1st quadrant";
//     if (a > 0 && b < 0) return "2nd quadrant";
//     if (a < 0 && b < 0) return "3rd quadrant";
//     else return "4th quadrant";
// }

/// 20. Задать номер четверти, показать диапазоны для возможных координат
/// int quadrant = new Random().Next(1, 5);
/// System.Console.WriteLine(XYRange(quadrant));
/// string XYRange(int a)
/// {
///     if (a == 1) return "x > 0, y > 0";
///     if (a == 2) return "x > 0, y < 0";
///     if (a == 3) return "x < 0, y < 0";
///     if (a == 4) return "x < 0, y > 0";
///     else return "Please enter the number from 1 to 4";
/// }

// 21. Программа проверяет пятизначное число на палиндром
// int num = new Random().Next(10000, 100000);
// System.Console.WriteLine("The number is: " + num + ". Is it a palindrome? --> " + IfPalindrome(num));
// bool IfPalindrome(int number)
// {
//     int a = (number / 1000) / 10;
//     int b = (number / 1000) % 10;
//     int z = (number % 100) % 10;
//     int y = (number % 100) / 10;
//     if (a == z && b == y) return true;
//     else return false;
// }

/// 22. Найти расстояние между точками в пространстве 2D/3D
/// System.Console.WriteLine("Choose 2 or 3 dimensions:");
/// int choice = Convert.ToInt32(Console.ReadLine());
/// if (choice == 2)
/// {
///     System.Console.WriteLine("Enter the coordinates of the two points (x1, y1; x2, y2):");
///     int x1 = Convert.ToInt32(Console.ReadLine());
///     int y1 = Convert.ToInt32(Console.ReadLine());
///     int x2 = Convert.ToInt32(Console.ReadLine());
///     int y2 = Convert.ToInt32(Console.ReadLine());
///     System.Console.WriteLine(TwoPointsDistance2D(x1, y1, x2, y2));
/// }
/// if (choice == 3)
/// {
///     System.Console.WriteLine("Enter the coordinates of the two points (x1, y1, z1; x2, y2, z2):");
///     int x1 = Convert.ToInt32(Console.ReadLine());
///     int y1 = Convert.ToInt32(Console.ReadLine());
///     int z1 = Convert.ToInt32(Console.ReadLine());
///     int x2 = Convert.ToInt32(Console.ReadLine());
///     int y2 = Convert.ToInt32(Console.ReadLine());
///     int z2 = Convert.ToInt32(Console.ReadLine());
///     System.Console.WriteLine(TwoPointsDistance3D(x1, y1, z1, x2, y2, z2));
/// }
/// double TwoPointsDistance2D(int a1, int b1, int a2, int b2)
/// {
///     double p1 = Math.Pow((a2 - a1), 2);
///     double p2 = Math.Pow((b2 - b1), 2);
///     double distance = Math.Sqrt(p1 + p2);
///     return distance;
/// }
/// double TwoPointsDistance3D(int a1, int b1, int c1, int a2, int b2, int c2)
/// {
///     double p1 = Math.Pow((a2 - a1), 2);
///     double p2 = Math.Pow((b2 - b1), 2);
///     double p3 = Math.Pow((c2 - c1), 2);
///     double distance = Math.Sqrt(p1 + p2 + p3);
///     return distance;
/// }