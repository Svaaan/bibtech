class Book
{
    public string title {get; set;}
    public int publicationYear {get; set;}
    public string author {get; set;}
    public string publisher{get; set;}
    public int date {get; set;}

    public int Isbn {get; set;}
    
 
        public Book(string title, string author, int publicationYear)
    {
        
        this.title = title;
        this.author = author;
        this.publicationYear = publicationYear;
        
    }
    //Virtual == base clas
    public virtual string ToString()
    {
        return$"Title: {title} Author: {author} Publication year: {publicationYear}";
    }
    //Empty constructor to catch book with no exact values

    public Book(string publisher, int date)
    {
        //specifik konstruktor för class tidskrift då books bas ej delar mycket med mer än title med tidskrift
        this.publisher = publisher;
        this.date = date;
    }
    public Book()
    {

    }  
}