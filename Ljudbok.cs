class Ljudbok : Book
{
    public int timeLength { get; set; }
    public string narrator { get; set; }
    public Ljudbok(string title, int publicationYear, string author, int timeLength, string narrator) : base(title, author, publicationYear)
    {
        this.timeLength = timeLength;
        this.narrator = narrator;
    }

    public override string ToString()
    {
        return $"Title: {title} Author: {author} Publication year: {publicationYear} TimeLength: {timeLength} Narrator: {narrator}";
    }

    public Ljudbok()
    {
        //tom konstruktor för tomma listor
    }

}