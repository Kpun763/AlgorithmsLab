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


            List<string> nameList = new List<string> { "Kyle", "Gerry", "Kyle" };
            bool hasRepeats = Algorithms.HasRepeatedNames(nameList);

            Console.WriteLine($"Has repeated names: {hasRepeats}");

            List<int> numbersList = new List<int> { 55, 62, 25, 10, 20, 30, 95 };

            Console.WriteLine("Original list");
            Console.WriteLine(string.Join(",", numbersList));

            Algorithms.BubbleSort(numbersList);

            Console.WriteLine("Sorted list:");
            Console.WriteLine(string.Join(",", numbersList));

        }

        
       

    }

}