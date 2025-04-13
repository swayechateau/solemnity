namespace api.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public int ChannelId { get; set; }
        public bool IsHidden { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string DeletedAt { get; set; }
    }
}