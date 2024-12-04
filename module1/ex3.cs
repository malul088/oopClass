internal class Program
{
    struct s
    {
        public int x;
        public int y;
    }
    struct s1
    {
        public int x;
        public int y;
        public int x1;
        public int y1;
    }

    class c
    {
        public int x;
        public int y;

    }
    class c1
    {
        public int x;
        public int y;
        public int x1;
        public int y1;
    }

    private static void Main(string[] args)
    {
        //a.
        Console.WriteLine("A.");
        long baselineMemory = GC.GetAllocatedBytesForCurrentThread();
        int [] intArray = new int[100];
        long afterArray = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"Int Array Allocation: {afterArray - baselineMemory} bytes");
        Console.WriteLine("Array size is: 100");
        Console.WriteLine("Int variable has 4 Bytes ->->-> 4*100=400, 424-400= 24");
        Console.WriteLine();

        baselineMemory = GC.GetAllocatedBytesForCurrentThread();
        double[] doublelArray = new double[100];
        afterArray = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"Double Array Allocation: {afterArray - baselineMemory} bytes");
        Console.WriteLine("Array size is: 100");
        Console.WriteLine("Double has 8 Byte ->->-> 8*100=800, 824-800= 24");
        Console.WriteLine();

        baselineMemory = GC.GetAllocatedBytesForCurrentThread();
        char[] charArray = new char[100];
        afterArray = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"Char Array Allocation: {afterArray - baselineMemory} bytes");
        Console.WriteLine("Array size is: 100");
        Console.WriteLine("Char has 2 Byte ->->-> 2*100=200, 224-200= 24");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        //b.
        Console.WriteLine("B.");
        baselineMemory = GC.GetAllocatedBytesForCurrentThread();
        s[] structArray = new s[100];
        afterArray = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"Struct Array Allocation: {afterArray - baselineMemory} bytes");
        Console.WriteLine("Array size is: 100");
        Console.WriteLine("Stuct has 2 Ints (8 Bytes) ->->-> 8*100=800, 824-800= 24");
        Console.WriteLine();

        baselineMemory = GC.GetAllocatedBytesForCurrentThread();
        s[] structArray1 = new s[1000];
        afterArray = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"Struct Array Allocation: {afterArray - baselineMemory} bytes");
        Console.WriteLine("Array size is: 1000");
        Console.WriteLine("Stuct has 2 Ints (8 Bytes) ->->-> 8*1000=8000, 8024-8000= 24");
        Console.WriteLine();

        baselineMemory = GC.GetAllocatedBytesForCurrentThread();
        c[] classArray = new c[100];
        afterArray = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"Class Array Allocation: {afterArray - baselineMemory} bytes");
        Console.WriteLine("Array size is: 100");
        Console.WriteLine("Class is always takes 8 bytes (in a 64 bit computer) ->->-> 8*100=800, 824-800= 24");
        Console.WriteLine();

        baselineMemory = GC.GetAllocatedBytesForCurrentThread();
        c[] classArray1 = new c[1000];
        afterArray = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"Class Array Allocation: {afterArray - baselineMemory} bytes");
        Console.WriteLine("Array size is: 1000");
        Console.WriteLine("Class is always takes 8 bytes (in a 64 bit computer) ->->-> 8*1000=800, 8024-8000= 24");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        baselineMemory = GC.GetAllocatedBytesForCurrentThread();
        s1[] structArray2 = new s1[100];
        afterArray = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"Struct Array with 4 int Allocation: {afterArray - baselineMemory} bytes");
        Console.WriteLine("Array size is: 100");
        Console.WriteLine("Stuct has 4 Ints (16 Bytes) ->->-> 16*100=1600, 1624-1600= 24");
        Console.WriteLine();

        baselineMemory = GC.GetAllocatedBytesForCurrentThread();
        c1[] classArray2 = new c1[100];
        afterArray = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"Class Array with 4 int Allocation: {afterArray - baselineMemory} bytes");
        Console.WriteLine("Array size is: 1000");
        Console.WriteLine("Class is always takes 8 bytes (in a 64 bit computer) ->->-> 8*100=800, 824-800= 24");
        Console.WriteLine();
    }
}