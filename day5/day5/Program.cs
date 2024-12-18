using day5;

internal class Program
{
    private static void Main(string[] args)
    {
        Fraction a = new Fraction(2,10);
        Fraction b = new Fraction(6,8);
        Fraction newFraction = a + b;

        Console.WriteLine($"a={a.ToString()} b={b.ToString()}");
        Console.WriteLine($"a+b= {newFraction.ToString()} {newFraction.getDouble()}");
        newFraction = a - b;
        Console.WriteLine($"a-b= {newFraction.ToString()} {newFraction.getDouble()}");
        newFraction = a * b;
        Console.WriteLine($"a*b= {newFraction.ToString()} {newFraction.getDouble()}");
        newFraction = a / b;
        Console.WriteLine($"a/b= {newFraction.ToString()} {newFraction.getDouble()}");
        bool ans = a == b;
        Console.WriteLine($"{a.ToString()} == {b.ToString()} = {ans}");
        ans = a > b;
        Console.WriteLine($"{a.ToString()} > {b.ToString()} = {ans}");
        ans = a < b;
        Console.WriteLine($"{a.ToString()} < {b.ToString()} = {ans}");

        List<Fraction> rows = new List<Fraction>();
        List<Fraction> columns = new List<Fraction>();
        for (int i = 0; i < 5; i++)
        {
            rows.Add(new Fraction(i+1, 5));
            columns.Add(new Fraction(i+1,5));
        }
        Console.WriteLine("Plus table");
        GenericOperationTable<Fraction> got = new GenericOperationTable<Fraction>(rows, columns, (x, y) => x + y);
        got.printList();

        Console.WriteLine("\nMinus table");
        got = new GenericOperationTable<Fraction>(rows, columns, (x, y) => x - y);
        got.printList();

        Console.WriteLine("\nmultiply table");
        got = new GenericOperationTable<Fraction>(rows, columns, (x, y) => x * y);
        got.printList();

    }
}