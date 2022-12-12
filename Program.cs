// Д.з.1 Напишите программу, которая 
// принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// bool Polindrom (int number)
//  {  
//     if (number/10000 == number%10 || (number/1000)%10 == (number%100)/10)
//         return true;

//     else
//         return false;
//  }

// Console.Write("Enter a five - digit number:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99999 || num<= 10000)
// {
//     Console.WriteLine("introduction error");
// }
// else
// {
//     bool result=Polindrom(num);
//     Console.WriteLine($"Result is {result}");
// }

// Д.з.2 Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Distanse(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     double kvx = Math.Pow((xb-xa),2);
//     double kvy = Math.Pow((yb-ya),2);
//     double kvz = Math.Pow((zb-za),2);
//     double sumkv = kvx + kvy + kvz;
//     double result = Math.Sqrt(sumkv);
//     return Math.Round(result,2); 
// }
// Console.Write("Input an x-coordinate A:");
// double xA = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input an y-coordinate A:");
// double yA = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input an z-coordinate A:");
// double zA = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input an x-coordinate B:");
// double xB = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input an y-coordinate B:");
// double yB = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input an z-coordinate B:");
// double zB = Convert.ToDouble(Console.ReadLine());

// double res = Distanse (xA, yA, zA, xB, yB, zB);
// Console.WriteLine($"Расстояние между двух точек {res}");


// Д.з.3 Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// void Kub(int number)
// {
//    int counter = 1;
//    while (counter<=number)
//    {
//     Console.Write($"{Math.Pow(counter,3)}");
//     if (counter!=number) Console.Write (", ");
//     counter++;
//    }

// }
//  Console.Write("Input a number:");
//  int num = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine ("Table of cubes:");
//  Kub(num);

