namespace Week8.Task2;

class Program
{
    void Main()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        p2.X = 3;

        p2.Print();
        p1.Print();

        Console.WriteLine();

        PoinRef r1 = new PoinRef { X = 1, Y = 2 };
        PoinRef r2 = r1;
        r2.X = 3;

        r2.Print();
        r1.Print();

        Console.WriteLine();

        BoxingTester.Test();
    }
}