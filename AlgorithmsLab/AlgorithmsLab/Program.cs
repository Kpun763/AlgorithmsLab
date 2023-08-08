namespace AlgorithmsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            bool isEven = Algorithms.IsEven(num);

            Console.WriteLine($"{num} is even: {isEven}");

            List<int> numberList = new List<int> { 20, 50, 63, 90};

            bool allLessThan100 = Algorithms.AllNumbersLessThan100(numberList);

            Console.WriteLine($"All numbers are less than 100: {allLessThan100}");
        }

        
       

    }

}