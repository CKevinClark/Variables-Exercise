namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 31;
            char middleInitial = 'D';
            bool isOver18 = true;
            double currentTemp = 77.9;
            decimal currentPrice = 29.99m;

            //Initialize variables

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Over 18?: {isOver18}");
            Console.WriteLine($"Current Temperature: {currentTemp}");
            Console.WriteLine($"Current Price: {currentPrice}");

            Console.WriteLine($"My name is {name} and I am {age}. I have been sometimes called {middleInitial} due to it being my intial. For the last 12 years I have been over 18, it's {isOver18}. My pits are currently {currentTemp} and my networth is {currentPrice}");

        }
    }
}
