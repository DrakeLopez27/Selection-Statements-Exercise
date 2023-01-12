namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var favoriteNumber = 27;
            Console.WriteLine("Try to guess my favorite number");

            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favoriteNumber ) 
            { 
                Console.WriteLine("Too Low!");
            }
            else if (userInput> favoriteNumber ) 
            {
                Console.WriteLine("Too High!");
            
            }
            
            else
            { 
                Console.WriteLine("NEVERMIND THEN!");
            
            }
           
            

        }
    }
}
