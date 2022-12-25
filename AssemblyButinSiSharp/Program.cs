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
            
        Console.WriteLine($"Расстояние между автомобилями = {(v1+v2)*t + s}");
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
        int count = B-A+1;
        int sum = 0;
        Console.WriteLine($"Кол-во цифр между ними включительно = {count}");
        while (B >= A) { sum += B; B--; }
        Console.WriteLine($"Среднее арифметическое = {sum} / {count} = {sum/count}");
    }
    
/*12	Написать подпрограмму, вычисляющую НОК, и вычислить НОК для каждой пары чисел из трёх заданных.*/
    static int NOD(int a, int b){
        while (a != b){
            if (a > b){
                a -= b;
            } else b -= a;
        } return a; }

    static int NOK(int a, int b) => Math.Abs(a * b)/NOD(a, b);
    
    private static void work_4_1()
    {
        Console.WriteLine($"Введите значение a"); 
        var a = (int.Parse(Console.ReadLine()!));
        Console.WriteLine($"Введите значение b"); 
        var b = (int.Parse(Console.ReadLine()!));
        Console.WriteLine($"Введите значение c"); 
        var c = (int.Parse(Console.ReadLine()!));

        Console.WriteLine($"НОК a и b = {NOK(a,b)}");
        Console.WriteLine($"НОК b и c = {NOK(b,c)}");
        Console.WriteLine($"НОК a и c = {NOK(a,c)}");
    }
    
/*	Написать подпрограмму вычисления значения функции по формуле:
Вычислить f(x_1 )+f(x_2).
*/
    static int func1(int x) => x*x;
    static int func2(int x) => (x*x)+(x*4)+(5);
    static int func3(int x) => 4;

    static int GetFunc(int x)
    {
        int f;
        if (x >= 0 && x <= 2) f = func1(x);
        else if (x > 2) f = func2(x);
        else f = func3(x);
        return f;
    }

    private static void work_4_2()
    {
        Console.WriteLine($"Введите значение x1"); 
        var x1 = (int.Parse(Console.ReadLine()!));
        Console.WriteLine($"Введите значение x2"); 
        var x2 = (int.Parse(Console.ReadLine()!));

        Console.WriteLine($"{GetFunc(x1)} + {GetFunc(x2)} = {GetFunc(x1) + GetFunc(x2)}");
    }
    
    /*2	Вычислить произведение четных элементов массива.*/
    private static void work_5_1()
    {
        int[] array = new int[5] {2, 6, 7, 3, 3};
        foreach (var t in array) Console.Write($"{t} ");
        Console.WriteLine();

        int mul = 1;
        for (int i = 0; i < array.Length; i++)
            if (array[i] % 2 == 0) mul *= array[i];
        Console.WriteLine($"Произведение четных элементов = {mul}");
    }
    
    /*2	Записать строку a в обратном порядке.*/
    private static void work_5_2()
    {
        Console.WriteLine($"Напишите строку которую хотите увидеть в обратном порядке"); 
        var str = Console.ReadLine();
        char[] reverse = str.Reverse().ToArray();
        Console.WriteLine(reverse);
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
            [9] = work_5_1,
            [10] = work_5_2,
        };
         Console.WriteLine("Какую лабу делаем? (1-8)");
         int key = (int.Parse(Console.ReadLine()!));
         if (works.ContainsKey(key)) works[key]();
         else Console.WriteLine("Не такого задания");
     }
}