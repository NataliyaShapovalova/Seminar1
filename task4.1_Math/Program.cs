System.Console.WriteLine("Введите первое число");
int a= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число");

int c= Convert.ToInt32(Console.ReadLine());
int max=Math.Max(a,Math.Max(b,c));

System.Console.WriteLine($"Максимальное число {max}");