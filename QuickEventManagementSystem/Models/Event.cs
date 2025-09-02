namespace QuickEventManagementSystem.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }

        public User AssignedUser { get; set; }
    }
}
