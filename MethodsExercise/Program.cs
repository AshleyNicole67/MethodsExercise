namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine($"Me too {userName}! What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine($"Ha Ha, {animal} that's a cool animal! What is your favorite band?");
            string band = Console.ReadLine();
            
            Console.WriteLine ($"Once upon a time, {userName} was playing at the park when they saw a {animal} holding a {favColor} Ballon, listening to {band} while skipping down the street!");
        }
        static void Main(string[] args)
        {
            Madlib();
        }
    }
}
