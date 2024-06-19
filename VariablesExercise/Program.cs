namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string frenchCapitol = "Paris";
            int capitalFounding = 843;
            char euroSymbol = '$';
            bool isCoolplace = true;
            double currentTemp = 63.9;
            decimal currentLatitude = 48.86m;

            //Initialize variables - Tried to make it more unique this time :) 

            Console.WriteLine($"The capitol of France: {frenchCapitol}");
            Console.WriteLine($"When the capitol of France was founded: {capitalFounding}");
            Console.WriteLine($"Currency accepted in Paris: {euroSymbol}");
            Console.WriteLine($"Paris is a cool place?: {isCoolplace}");
            Console.WriteLine($"Current Temperature: {currentTemp}");
            Console.WriteLine($"What is the latitude of Paris: {currentLatitude}");

            Console.WriteLine($"My name is {frenchCapitol} and I was founded in {capitalFounding}. I do not accept the {euroSymbol} as a currency. it is {isCoolplace}, I have often been reported as a good tourist destination.\n My temperature is currently {currentTemp} and latitude is {currentLatitude}");

        }
    }
}
