﻿System.Console.WriteLine("Введите первое число");
int a= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b= Convert.ToInt32(Console.ReadLine());
int max=Math.Max(a,b);
int min=Math.Min(a,b);
System.Console.WriteLine($"Максимальное число {max},Минимальное число {min}");