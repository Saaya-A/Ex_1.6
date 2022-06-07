class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите d ");
        int d = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= a; i++)
        {
            if (a % i == 0)
            {
                Console.WriteLine("Число {0} делится без остатка на {1}", a, i);
                if (d < i)
                    sum++;
            }
        }
        Console.WriteLine("Количество делителей, больших d " + sum);
    }
}