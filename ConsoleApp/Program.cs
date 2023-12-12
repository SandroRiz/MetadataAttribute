using MetadataAttribute.Models;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

var author1 = new Author { Id = 1, FirstName = "John", LastName = "Doe" };
var author2 = new Author { Id = 2, FirstName = "Jane", LastName = "Smith" };

var book = new Book()
{
    Id = 1,
    ISBN = "ABCDEXYG",
    Title = "Lorem Ipsum",
    Authors = new List<Author>() { author1, author2 }
};
author1.Books = new List<Book>() { book };
author2.Books = new List<Book>() { book }; 


MemoryStream stream = new();

JsonSerializerOptions options = new()
{
    ReferenceHandler = ReferenceHandler.IgnoreCycles,     //workaround if you don't want to use JsonIgnore
    WriteIndented = true
};

JsonSerializer.Serialize<Book>(stream, book, options);
stream.Flush();
stream.Seek(0, SeekOrigin.Begin);

Console.WriteLine(Encoding.ASCII.GetString(stream.ToArray()));