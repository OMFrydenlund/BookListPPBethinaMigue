using BookListPPBethinaMigue;

List<BookModel> bookList = new List<BookModel>();

// HARDCODED VALUES
//{
//    new BookModel("Diavola", 2024, "Jennifer Marie Thorne", "Horror", 296, "" +
//        "Anna has two rules for the annual Pace family destination vacations: Tread lightly and survive."),
//    new BookModel("Lady Macbeth", 2024, "Ava Reid", "Fantasy", 320, "The Lady knows the stories: how her eyes induce madness in men. "),
//    new BookModel("Circe", 2018, "Madeline Miller", "Fiction", 393, 
//        "In the house of Helios, god of the sun and mightiest of the Titans, a daughter is born. "),
//};

Console.Write("Welcome to your personal book app!");
bool isChoosing = true;
while (isChoosing)
{
    Console.Write("Choose an action:\n1. Add book\n2. View your library\n3. Exit\n\n");
    string userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "1":
            CreateNewBook();
            break;
        case "2":
            DoWeHaveBooks(bookList);
            break;
        case "3":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}

void CreateNewBook()
{
    BookModel newBook = new BookModel();
    newBook.GetAllBookInfo(newBook);
    bookList.Add(newBook);
    Console.WriteLine($"{newBook._title} has been added to the library!");
    Thread.Sleep(2000);
}

void DoWeHaveBooks(List<BookModel> listOfBooks)
{
    if (listOfBooks.Count == 0)
    {
        Console.WriteLine("There are no books in your library.");
    }
    else
    {
        ShowBookList(listOfBooks);
    }
}

void ShowBookList(List<BookModel> listOfBooks)
{
    foreach (BookModel book in listOfBooks)
    {
        book.PrintBookInfo();        
    }
}

Console.ReadLine();

