namespace WebAPI.Domain.Models
{
    public class DocumentModel
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string DocumnetName { get; set; }
        public byte[] Content { get; set; }
    }
}
