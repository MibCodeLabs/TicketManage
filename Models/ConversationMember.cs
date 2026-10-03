namespace ticketManage.Models
{
    public class ConversationMember : AuditableEntity
    {
        public long MemberId { get; set; }
        public long ConversationId { get; set; }
        public User Member { get; set; } = null!;
        public Conversation Conversation { get; set; } = null!;

    }
}
