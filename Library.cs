class Library
{
    // lista för böcker
    private static List<Book> Books = new List<Book>();

    public static void AddSingleBook(Book newbook)
    {

        Books.Add(newbook);

    }
    public static void AddMultipleBooks(List<Book> list)
    {
        //Inbyggd funktion för listor att expandera med mer items direkt
        Books.AddRange(list);
        
    }

    public static List<Book> GetListBooks()
    {   // returnerar books i listan Book.
        return Books;
    }

    public static List<Book> SearchBook (string search)
    {
        List<Book> findBook = new();
        foreach(Book item in Books)
        {
            if(item.title.ToLower() == search.ToLower())
            {
                findBook.Add(item);

            }
            else if(item.author.ToLower() == search.ToLower())
            {
                findBook.Add(item);
            }
            else if(item.publicationYear.ToString() == search)
            {
                findBook.Add(item);
            }

        }   
        return findBook;
    }
    
}