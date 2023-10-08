namespace WebAPI.Domain.Models
{
    public class Document
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string DocumnetName { get; set; }
        public byte[] Content { get; set; }
    }
}
