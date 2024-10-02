using System;
using System.Collections.Generic;
using System.Linq;

// Yazarlar tablosunu temsil eden sınıf
public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
}

// Kitaplar tablosunu temsil eden sınıf
public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
}

class Program
{
    static void Main()
    {
        // Yazarlar listesini oluşturuyoruz
        List<Author> authors = new List<Author>
        {
            new Author { AuthorId = 1, Name = "Orhan Pamuk" },
            new Author { AuthorId = 2, Name = "Elif Şafak" },
            new Author { AuthorId = 3, Name = "Ahmet Ümit" }
        };

        // Kitaplar listesini oluşturuyoruz
        List<Book> books = new List<Book>
        {
            new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
            new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 },
            new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
            new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 }
        };

        // LINQ ile kitapları ve yazarları birleştiriyoruz (Join işlemi)
        var bookWithAuthors = from book in books
                              join author in authors
                              on book.AuthorId equals author.AuthorId
                              select new { book.Title, author.Name };

        // Sonuçları ekrana yazdırıyoruz
        Console.WriteLine("Kitaplar ve Yazarlar:");
        foreach (var item in bookWithAuthors)
        {
            Console.WriteLine($"Kitap: {item.Title}, Yazar: {item.Name}");
        }
    }
}
