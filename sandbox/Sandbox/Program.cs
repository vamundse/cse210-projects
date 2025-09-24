using System;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetTitle("John by the sea");
        book1.SetAuthor("Martha Robins");

        Console.WriteLine(book1.GetBookInfo());

        PictureBook book2 = new PictureBook();
        book2.SetTitle("Adam goes to Space");
        book2.SetAuthor("John Murtaugh");
        book2.SetIllustrator("Casey John");

        Console.WriteLine(book2.GetPictureBookInfo());

        Book book3 = new Book("Hugo Duncan", "The great Escape");
        Console.WriteLine(book3.GetBookInfo());

        PictureBook book4 = new PictureBook("Hawkeye", "Robin Hood", "Gunnar Sørensen");
        Console.WriteLine(book4.GetPictureBookInfo());
    }
}