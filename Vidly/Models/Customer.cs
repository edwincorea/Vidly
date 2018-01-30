namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        // Navigation property
        public MembershipType MembershipType { get; set; }
        // For optimizations, we declare a foreign key. By convention: ClassName+Id
        public byte MembershipTypeId { get; set; } 
    }
}