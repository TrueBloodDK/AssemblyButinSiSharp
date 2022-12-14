namespace AllLabs;


class Program
{
    static void work_1()
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
     
    static void Main()
    {
        Dictionary<int, Action> Works = new Dictionary<int, Action>
        {
            [1] = work_1,
        };
        Console.WriteLine("Какую лабу делаем? (1-8)");
        int key = (int.Parse(Console.ReadLine()!));
        if (Works.ContainsKey(key)) Works[key]();
        else Console.WriteLine("Не такого задания");
    }
}