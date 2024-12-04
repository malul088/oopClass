namespace ConsoleApp1
{
    internal class Program
    {
        public class SumCalculator
        {
            public int sum;

            public void AddToSum(int number)
            {
                sum += number;
            }

        }
        
        public class MaxCalculator
        {
            public int max;
          
       
            public void findMax(int number)
            {
                max = number>max? number:max;
            }

        }

        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            var sumCalculator = new SumCalculator();
            var maxCalculator = new MaxCalculator();

            ArrayProcessor.ProcessArray(numbers, sumCalculator.AddToSum);
            ArrayProcessor.ProcessArray(numbers, maxCalculator.findMax);

            int totalSum = sumCalculator.sum; // Returns 15
            Console.WriteLine($"Total sum: {totalSum}");

            int max = maxCalculator.max; // Returns 5
            Console.WriteLine($"The max: {max}");
        }
    }





}