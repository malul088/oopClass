using System.Text;

internal class Program
{
    public struct PointStruct
    {
        public int x; public int y;
    }
    public class PointClass
    {
        public int x; public int y;
    }
    private static void Main(string[] args)
    {
        MeasureStructMemory();
        MeasureStringMemory();
        StrBuilder();
        str();
        GCandGen();
    }
    static void MeasureStructMemory()
    {
        long before = GC.GetAllocatedBytesForCurrentThread();
        PointStruct pointStruct = new PointStruct();
        long after = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"MeasureStructMemory: Allocated Memory={after - before}");
    }

    static void MeasureStringMemory()
    {
        long before = GC.GetAllocatedBytesForCurrentThread();
        string s = new string("123456789A");
        long after = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"MeasureStringMemory: Allocated Memory={after - before}");
    }

    static void StrBuilder() {
        long before = GC.GetAllocatedBytesForCurrentThread();
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= 100; i++)
        {
            sb.Append(i.ToString());
            sb.Append(" ");
        }
        long after = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"MeasureStringMemory: Allocated Memory={after - before}");
        Console.WriteLine( sb);
    }

    static void str()
    {
        long before = GC.GetAllocatedBytesForCurrentThread();
        string sb = "";
        for (int i = 1; i <= 100; i++)
        {
            sb+=i.ToString()+" ";
        }
        long after = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"MeasureStringMemory: Allocated Memory={after - before}");
        Console.WriteLine(sb);

    }

    static void GCandGen() { 
        PointClass pc = new PointClass();
        pc.x = 6;
        pc.y = 6;
        Console.WriteLine(GC.GetGeneration(pc));
        GC.Collect(0);
        Console.WriteLine(GC.GetGeneration(pc));
        

    }
}