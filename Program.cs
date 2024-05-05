namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        MenuOption();
    }
    static void MenuOption()
    {
        Console.Clear();

        Console.WriteLine("Choose an operation: ");
        Console.WriteLine("1 - Sum");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Division");
        Console.WriteLine("4 - Multiplication");
        Console.WriteLine("5 - Quit");

        Console.WriteLine("-------------------");

        Console.Write("Select an option: ");
        short vOption = short.Parse(Console.ReadLine());

        switch (vOption)
        {
            case 1: Sum(); break;
            case 2: Subtraction(); break;
            case 3: Division(); break;
            case 4: Multiplication(); break;
            case 5: Quit(); break;
            default: MenuOption(); break;
        }
    }

    static void Quit()
    {
        Console.WriteLine("Leaving... Until next time!");
        System.Environment.Exit(0);
    }

    static void Sum()
    {
        Console.Clear();

        Console.Write("Enter the first value: ");
        float n1 = float.Parse(Console.ReadLine());

        Console.Write("Enter the second value: ");
        float n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        double? result = n1 + n2;
        Console.WriteLine("result: " + result);

        Console.ReadKey();
        MenuOption();
    }

    static void Subtraction()
    {
        Console.Clear();

        Console.Write("Enter the first value: ");
        float n1 = float.Parse(Console.ReadLine());

        Console.Write("Enter the second value: ");
        float n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("result: " + (n1 - n2));

        Console.ReadKey();
        MenuOption();
    }

    static void Division()
    {
        Console.Clear();

        Console.Write("Enter the first value: ");
        float n1 = float.Parse(Console.ReadLine());

        Console.Write("Enter the second value: ");
        float n2 = float.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine($"result : {n1 / n2}");

        Console.ReadKey();
        MenuOption();
    }

    static void Multiplication()
    {
        Console.Clear();

        Console.Write("Enter the first value: ");
        var n1 = float.Parse(Console.ReadLine());

        Console.Write("Enter the second value: ");
        var n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        var result = n1 * n2;
        Console.WriteLine($"result: {result}");

        Console.ReadKey();
        MenuOption();
    }
}
