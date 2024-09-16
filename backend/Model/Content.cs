namespace Backend.Model;

public partial class Content
{
    public Guid Id { get; set; }
    public required byte[] Bytes { get; set; }
}