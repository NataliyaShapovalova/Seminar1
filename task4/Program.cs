System.Console.WriteLine("Введите первое число");
int a= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int c= Convert.ToInt32(Console.ReadLine());

int max=a;
if (max<b)
{
    max=b;
}

if (max<c)
{
    max=c;
}
System.Console.WriteLine($"  максимальное число {max}");