namespace MethodsExercise
{
    public class Program
    {
        // Method to handle user input and story creation
        public static void CreateStory()
        {
            // Prompt the user for their name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // Prompt the user for their favorite color
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            // Prompt the user for their favorite animal
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            // Prompt the user for their favorite band
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            // Create a fun story using string interpolation
            Console.WriteLine($"\nOnce upon a time, there was a person named {name} who loved the color {color}. " +
                              $"One day, {name} found a magical {animal} that could sing songs by {band}. " +
                              $"It was the start of an unforgettable adventure!");
        }


        // Methods to handle math operations

        public static int Add(int num1, int num2) 
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }




        // Main method
        static void Main(string[] args)
        {
            // Call the CreateStory method
            CreateStory();
            //Math Methods
            Console.WriteLine(Add(5, 2));
            Console.WriteLine(Subtract(10, 1));
            Console.WriteLine(Multiply(6, 7));
            Console.WriteLine(Divide(200, 2));

        }
    }
}
