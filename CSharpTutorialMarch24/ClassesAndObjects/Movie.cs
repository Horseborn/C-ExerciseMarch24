namespace CSharpTutorialMarch24.ClassesAndObjects;

public class Movie
{
    public string title;
    public string director;
    private string rating;

    public Movie(string argTitle, string argDirector, string argRating)
    {
        title = argTitle;
        director = argDirector;
        Rating = argRating;
    }

    public string Rating
    {
        get { return rating; }
        set
        {
            if (value is "G" or "PG" or "PG-13" or "R" or "NR")
            {
                rating = value;
            }
            else
            {
                rating = "NR";
            }
        }
    }
}