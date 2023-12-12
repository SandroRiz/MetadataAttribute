using MetadataAttribute.Models;
using Microsoft.AspNetCore.Http.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<JsonOptions>(options =>
{
   // options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;       //comment to test JsonIgnore attribute
    options.SerializerOptions.WriteIndented = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/book", () =>
{
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

    return Results.Ok(book);
})
.WithName("GetBook")
.WithOpenApi();

app.Run();

