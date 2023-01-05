class Roman : Book
{

    
    public Roman(string title, string author, int publicationYear):base(title, author, publicationYear)
    {
        
    }

        public override string ToString()
    {
        return$"Title: {title} Author: {author} Publication year: {publicationYear}";
    }
    public Roman()
    {
        //tom konstruktor för tom lista
    }
   
}