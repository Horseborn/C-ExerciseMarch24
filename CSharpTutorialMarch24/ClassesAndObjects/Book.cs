namespace CSharpTutorialMarch24.ClassesAndObjects;

public class Book
{
    public string? title;
    public string? author;
    public int? pages;

    public Book(string argTitle, string argAuthor, int? argPages)
    {
        title = argTitle;
        author = argAuthor;
        pages = argPages;
    }

    
}