namespace CSharpTutorialMarch24.ArrayDir;

public class twoDArray
{
    public static string NumberGrids()
    {
        int[,] numberGrid =
        {
            {1, 2},
            {3, 4},
            {5, 6}
        };
        return $"{numberGrid[0, 0]} and {numberGrid[2, 1]}";

    }
}