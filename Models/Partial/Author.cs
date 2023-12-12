using MetadataAttribute.MetaData;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MetadataAttribute.Models;

// Tried both Attributes...seems asp.net core use ModelMetadataType instead MetadataType

//[ModelMetadataType(typeof(AuthorMetadata))]
[MetadataType(typeof(AuthorMetadata))]
public partial class Author
{
  
}
