namespace ticketManage.Models
{
    public class Conversation : AuditableEntity
    {
        public long Id { get; set; }
        public ICollection<ConversationMember> Members { get; set; } = [];
    }
}
