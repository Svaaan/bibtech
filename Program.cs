internal class Program
{
    private static void Main(string[] args)
    {
         string answer = string.Empty;
        string title;
        string author;
        string publisher;
        string narrator;

        bool menu = true;

        int option = 0;
        int optionRegister = 0;
        int optionGenre = 0;
        int publicationYear;
        int addBook = 0;
        int timeLength;
        int date;

        List<Book> addBooks = new List<Book>();

        Roman novel = new();
        Tidskrift journal = new();
        Ljudbok soundBook = new();

        Console.Clear();

        while (menu)
        {
            System.Console.WriteLine("Welcome to Bibliotech.");
            System.Console.WriteLine("[1]Register books");
            System.Console.WriteLine("[2]Browse books");
            System.Console.WriteLine("[3]Search book");
            System.Console.WriteLine("----------------------");

            answer = Console.ReadLine();
            bool isNumber = int.TryParse(answer, out option);
            if (!isNumber)
            {
                System.Console.WriteLine("Only number input is valid");
            }

            switch (option)
            {
                case 1:
                    try
                    {
                        do
                        {
                            System.Console.WriteLine("[1] Register one book");
                            System.Console.WriteLine("[2] Register multiple books");
                            System.Console.WriteLine("[3] Return to menu");
                            answer = Console.ReadLine();

                            int.TryParse(answer, out optionRegister);

                        } while (optionRegister < 1 || optionRegister > 3);

                        if (optionRegister == 1)
                        {
                            do
                            {
                                System.Console.WriteLine("[1] Register a novel");
                                System.Console.WriteLine("[2] Register a journal");
                                System.Console.WriteLine("[3] Register a soundbook");
                                answer = Console.ReadLine();

                                int.TryParse(answer, out optionGenre);

                            } while (optionGenre < 1 || optionGenre > 3);

                            if (optionGenre == 1)
                            {
                                System.Console.WriteLine("Title of book: ");
                                title = Console.ReadLine();

                                System.Console.WriteLine("Author of book: ");
                                author = Console.ReadLine();

                                System.Console.WriteLine("Publication year of book: ");
                                answer = Console.ReadLine();

                                int.TryParse(answer, out publicationYear);
                                Console.ReadLine();

                                novel = new Roman(title, author, publicationYear);
                                Library.AddSingleBook(novel);
                            }
                            else if (optionGenre == 2)
                            {
                                System.Console.WriteLine("Title of journal: ");
                                title = Console.ReadLine();

                                System.Console.WriteLine("Publisher of journal: ");
                                publisher = Console.ReadLine();

                                System.Console.WriteLine("Publisher date of journal: ");
                                answer = Console.ReadLine();
                                int.TryParse(answer, out date);


                                journal = new Tidskrift(title, publisher, date);
                                Library.AddSingleBook(journal);

                            }
                            else if (optionGenre == 3)
                            {
                                System.Console.WriteLine("Title of soundbook: ");
                                title = Console.ReadLine();

                                System.Console.WriteLine("Author of soundbook: ");
                                author = Console.ReadLine();

                                System.Console.WriteLine("Publication year of soundbook: ");
                                answer = Console.ReadLine();
                                int.TryParse(answer, out publicationYear);


                                System.Console.WriteLine("Length of soundbook: ");
                                answer = Console.ReadLine();
                                int.TryParse(answer, out timeLength);


                                System.Console.WriteLine("Narrator of soundbook: ");
                                narrator = Console.ReadLine();

                                soundBook = new Ljudbok(title, publicationYear, author, timeLength, narrator);
                                Library.AddSingleBook(soundBook);

                            }
                        }
                        else if (optionRegister == 2)
                        {
                            System.Console.WriteLine("Amount books to add:");
                            answer = Console.ReadLine();
                            int.TryParse(answer, out addBook);

                            for (int i = 0; i < addBook; i++)
                            {
                                System.Console.WriteLine("Title: ");
                                title = Console.ReadLine();

                                System.Console.WriteLine("Author: ");
                                author = Console.ReadLine();

                                System.Console.WriteLine("Publication Year: ");
                                answer = Console.ReadLine();
                                int.TryParse(answer, out publicationYear);

                                Book book = new(title, author, publicationYear);

                                addBooks.Add(book);
                            }
                            Library.AddMultipleBooks(addBooks);

                        }
                    }
                    catch (FormatException e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
                    break;

                case 2:
                    Console.Clear();

                    System.Console.WriteLine("All books available");
                    System.Console.WriteLine("Press q to exit");
                    System.Console.WriteLine("--------------------");

                    List<Book> books = Library.GetListBooks();

                    books.Add(new Book() { title = "Righteous pray", author = "John Sandford", publicationYear = 2022 });
                    books.Add(new Book() { title = "Verity", author = "Colleen Hoover", publicationYear = 2018 });
                    books.Add(new Book() { title = "It ends with us", author = "Colleen Hoover", publicationYear = 2016 });
                    books.Add(new Book() { title = "Mad honey", author = "Jodi Picoult and Jennifer Finney Boyland", publicationYear = 2022 });
                    books.Add(new Book() { title = "Fairy Tale", author = "Stephen King", publicationYear = 2022 });

                    foreach (Book item in books)
                    {
                        System.Console.WriteLine(item.ToString());
                    }
                    if (answer == "q")
                    {
                        continue;
                    }

                    break;

                case 3:

                    try
                    {
                        System.Console.WriteLine("Search title, name of author or publication year:");
                        answer = Console.ReadLine();

                        //skapar en ny lista för att ta emot sökning
                        List<Book> catchBook = new();

                        //Tilldelar listan som searchbook returnerar
                        catchBook = Library.SearchBook(answer);

                        //För varje bok item som finns i catchBook skriv ut item
                        foreach (Book item in catchBook)
                        {
                            System.Console.WriteLine(item.ToString());
                        }

                    }
                    catch (Exception e)

                    {
                        System.Console.WriteLine(e.Message);
                    }

                    break;
            }

        }
  
    }
}