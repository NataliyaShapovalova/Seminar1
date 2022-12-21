System.Console.WriteLine("Введите число");
int N=Convert.ToInt32(Console.ReadLine());
int i=1;
if (N<=1)
{
    System.Console.WriteLine("Введите число больше чем 1");
}
else
{
    System.Console.WriteLine("Все числа от 1 до"+N);
    while (i<N+1)
    {
        System.Console.Write (i+",");
        i++
    }
}