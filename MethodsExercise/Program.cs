namespace MethodsExercise
{
    public class Program
    {
        public static void GreetPlayer(string playerName)
        {
            
            Console.WriteLine($"\nHello, {playerName} ");
            
        }
        
        static void Main(string[] args)
       {
           Console.WriteLine("What is your name?");
           var playerName = Console.ReadLine();
           GreetPlayer(playerName);
           
           Console.WriteLine("What is your favorite color?");
           var color = Console.ReadLine();
           Console.WriteLine($"\n{color} is an interesting pick...");
           Console.WriteLine("Since I'm not from this planet, I never heard of it.");
           Console.WriteLine($"Why \"{color}\" specifically? If you don't mind me asking of course?");
           var reason = Console.ReadLine();
           
           Console.WriteLine("\nSooooo.... What is your favorite animal?");
           var animal = Console.ReadLine();
           
           Console.WriteLine("\nFinal question... What is your favorite band?");
           var band = Console.ReadLine(); 
           
           Console.WriteLine("\nHm... I'm not the one to really judge... ");
           Console.WriteLine("But all i got to say is that, you're an unusual person.");
           Console.WriteLine("Not in a bad way of course... At least I think");

           Console.WriteLine(Add(50,10));
           Console.WriteLine(Subtract(50,10));
           Console.WriteLine(Multiply(50,10));
           Console.WriteLine(Divide(50,10));
           
       }
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
