namespace AssemblyButinSiSharp;

internal static class Program
{
    private static void work_1_1()
    {
        int sum = 0;
        int a = (int.Parse(Console.ReadLine()!)) + 1;
        sum += a;
        Console.WriteLine($"Кол-во парт = {a/2}");
        
        a = (int.Parse(Console.ReadLine()!)) + 1;
        sum += a; 
        Console.WriteLine($"Кол-во парт = {a/2}");
        
        a = (int.Parse(Console.ReadLine()!)) + 1;
        sum += a;
        Console.WriteLine($"Кол-во парт = {a/2}");
        
        int result = sum / 2;
        Console.WriteLine($"Кол-во всех парт = {result}");
    }

    private static void work_1_2()
    {
        Console.WriteLine($"Введите значение v1"); 
            var v1 = (int.Parse(Console.ReadLine()!));
        Console.WriteLine($"Введите значение v2"); 
            var v2 = (int.Parse(Console.ReadLine()!));
        Console.WriteLine($"Введите значение t"); 
            var t = (int.Parse(Console.ReadLine()!));
        Console.WriteLine($"Введите значение s"); 
            var s = (int.Parse(Console.ReadLine()!));
            
        Console.WriteLine($"Расстояние между автомобилями = {(v1+v2)*t - s}");
    }

    private static void work_2_1()
    {
        Console.WriteLine($"Введите значение первого катета");
            var katet1 = (int.Parse(Console.ReadLine()!));
        Console.WriteLine($"Введите значение второго катета");
            var katet2 = (int.Parse(Console.ReadLine()!));
        Console.WriteLine($"Введите значение стороны квадрата");
            var square = (int.Parse(Console.ReadLine()!));

            Console.WriteLine(katet1 * katet2 / 2 > square * square
                ? "Площадь треугольника больше площади квадрата"
                : "Площадь треугольника меньше площади квадрата");
    }

    private static void work_2_2()
    {
        Console.WriteLine($"Введите число");
        var num = (int.Parse(Console.ReadLine()!));
        Console.WriteLine(num % 2 == 0
            ? $"Число {num} является четным поэтому ответ {num+1}"
            : $"Число {num} является нечетным поэтому ответ {num}");
    }

    private static void work_3_1()
    {
        Console.WriteLine($"Введите число");
        var num = (int.Parse(Console.ReadLine()!));
        Console.Write($"Факториал числа {num}");
        var grade = num-1;
        while (grade > 0) { num *= grade; grade--; }
        Console.WriteLine($"является число {num}");
    }

    private static void work_3_2()
    {
        Console.WriteLine($"Введите числа A и B так чтобы A<B");
        int A = (int.Parse(Console.ReadLine()!));
        int B = (int.Parse(Console.ReadLine()!));
        int sum = B-A;
       /* while (B > A)
        {
            Console.WriteLine($"{A} + {B} = {A + B}");
            A += B;
            B--;
            sum++;
        }*/
       for (int i = B - A; i == 0; i--)
       {
           Console.WriteLine($"{A} + {B} = {A + B}");
           A += B;
       }
        Console.WriteLine($"Среднее арифметическое = {A/sum}");
    }

    private static void work_4_1()
    {
    }

    private static void work_4_2()
    {
    }


    private static void Main()
    {
        var works = new Dictionary<int, Action>
        {
            [1] = work_1_1,
            [2] = work_1_2,
            [3] = work_2_1,
            [4] = work_2_2,
            [5] = work_3_1,
            [6] = work_3_2,
            [7] = work_4_1,
            [8] = work_4_2,
        };
        Console.WriteLine("Какую лабу делаем? (1-8)");
        int key = (int.Parse(Console.ReadLine()!));
        if (works.ContainsKey(key)) works[key]();
        else Console.WriteLine("Не такого задания");
    }
}