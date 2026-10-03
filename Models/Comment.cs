namespace ticketManage.Models
{
    public class Comment : AuditableEntity
    {
        public long Id { get; set; }
        public long TicketId { get; set; }
        public Ticket Ticket { get; set; } = null!;

        public long? ParentCommentId { get; set; }
        public Comment? ParentComment { get; set; }
        public ICollection<Comment> Replies { get; set; } = [];
        public ICollection<FileAsset> Attachments { get; set; } = [];
        public bool IsDeleted { get; set; }
    }
}
