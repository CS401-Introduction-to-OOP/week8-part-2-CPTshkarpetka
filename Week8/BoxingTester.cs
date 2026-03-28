namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a; //boxing
        int c = (int)b; //unboxing
        Console.WriteLine($"a: {a}, b:{b}, c:{c}");
    }
}