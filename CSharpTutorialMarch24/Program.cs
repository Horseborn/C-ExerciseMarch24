using CSharpTutorialMarch24.ClassesAndObjects;

namespace CSharpTutorialMarch24;

class Program
{
    private static void Main()
    {


        Movie movie1 = new Movie("The Avengers", "Joss Wheadon", "PG-13");
        Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");
        // G, PG, PG-13, R, NR
        
        Console.WriteLine(movie1.Rating);


        // Student student1 = new Student("Jim", "Business", 2.8);
        // Student student2 = new Student("Pam", "Art", 3.6);
        // Console.WriteLine(student1.HasHonors());
        // Console.WriteLine(student2.HasHonors());


        // Book book = new Book("Conferring", "Ballsack Jersey", 69);
        // Console.WriteLine($"The title of the book is {book.title}, its author is {book.author} and it has {book.pages} pages.");

        /*string userInput = Console.ReadLine();
        int chosenTask = Convert.ToInt32(userInput);
        bool toRun = true;
        while (toRun)
        {
            switch (chosenTask)
            {
                case 1:
                    Console.WriteLine(ArrayDir.twoDArray.NumberGrids());
                    break;
                case 2:
                    Console.WriteLine(GetPower.GetPower.GetPow(4, 3));
                    break;
                case 3:
                    MadLibUserinteraction.RunMadLibGame();
                    break;
                case 4:
                    GuessingGame.GameBuilder.Game();
                    break;
                case 0:
                    toRun = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again. Type '0' to exit");
                    break;
            }*/
    }

        
        //
        //
        //
    }
//}
    
