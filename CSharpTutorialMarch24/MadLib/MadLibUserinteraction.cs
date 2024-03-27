namespace CSharpTutorialMarch24;

public class MadLibUserinteraction
{
    public static void RunMadLibGame()
    {
        Console.WriteLine("Hello, please type!");
        string color = Console.ReadLine();
        string pluralNoun = Console.ReadLine();
        string celebrity = Console.ReadLine();

        Console.WriteLine(MadLib.MadLibSetter(color, pluralNoun, celebrity));
        return;
    }
}