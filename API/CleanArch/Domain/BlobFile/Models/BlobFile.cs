using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain;

public class BlobFile 
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string ContentType { get; set; } = null!;

    [NotMapped]
    public string Extension => Path.GetExtension(Name);
}