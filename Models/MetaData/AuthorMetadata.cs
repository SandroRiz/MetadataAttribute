using MetadataAttribute.Models;
using System.Text.Json.Serialization;

namespace MetadataAttribute.MetaData;
public class AuthorMetadata
{

    [JsonIgnore]
    public ICollection<Book> Books { get; set; }
    
}
