namespace Backend.Model;

public partial class Content
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required byte[] Bytes { get; set; }
}