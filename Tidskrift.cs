class Tidskrift : Book
{
    public int date { get; set; }
    public string publisher { get; set; }
    public Tidskrift(string title, string publisher, int date) : base(title, publisher, date)
    {

    }

    public override string ToString()
    {
        return $"Title: {title} Publisher: {publisher} Date: {date}";
    }
    public Tidskrift()
    {
        //Tom konstruktor för tom lista
    }
}