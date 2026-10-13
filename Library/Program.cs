using Library;

List<Book> books = new List<Book>();
List<Member> members = new List<Member>();





books.Add(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
books.Add(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));

members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0790345666);

foreach (Book book in books)
{
        Console.WriteLine($"Book title:{book.Title}");
        Console.WriteLine($"Book title:{book.Author}");
        Console.WriteLine($"Book title:{book.ISBN}");
}

foreach (Member member in members)
{
    Console.WriteLine($"Member ID: {member.MemberId}");
    Console.WriteLine($"Name: {member.Name}");
    Console.WriteLine($"Address: {member.Address}");
    Console.WriteLine($"Phone: {member.Phone}");
}
