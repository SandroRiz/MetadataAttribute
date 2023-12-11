namespace MetadataAttribute.Models;
public class Book
{
    public int Id { get; set; }
    
    public string ISBN { get; set; }
    public string Title { get; set; }

    public string Description { get; set; }

    public ICollection<Author> Authors { get; set; }
}
