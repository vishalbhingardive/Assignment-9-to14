//12. Create two class book and library and implement has-a-relationship between those classes
//A. Display Books of library; B.library has many books


Book b = new Book(1, "Life");
Library l = new Library("SuryaVanshi","Ahmednagar", b);
l.display();

public class Book
{
    public int AuthorId;
    public string BookName;
    public Book(int authorId, string bookName)
    {
        this.AuthorId = authorId;
        this.BookName = bookName;

    }
}
public class Library
{
    public string Location;
    public string Name;
    public Book book;//Library Has- A-Books  

    public Library( string name,string location, Book book)
    {
        this.Location = location;
        this.Name = name;
        this.book = book;
    }
    public void display()
    {
        Console.WriteLine("Library Name: "+Name + " Location: " +Location+" Book ID: "+book.AuthorId + " Book Name: " + book.BookName);
    }
}





