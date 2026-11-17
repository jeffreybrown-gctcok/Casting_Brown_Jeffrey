internal class Program
{
    private static void Main(string[] args)
    {
        //asking the user for a whole number
        Console.WriteLine("Type a whole number and hit enter");
        //allowing user to input a whole number
        int favNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your favorite number is " + favNumber);
        //asking the user if they like games
        Console.WriteLine("Do you like video games, true or false?");
        //Getting answer as string
        string isTrue = Console.ReadLine();
        //converting response to bool
        bool likesGames = Convert.ToBoolean(isTrue);
        //displaying answer
        Console.WriteLine($"It is {likesGames} that you like video games!");
    }
}