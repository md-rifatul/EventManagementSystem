using QuickEventManagementSystem.Models;

namespace QuickEventManagementSystem.Data
{
    public static class SeedData
    {
        public static List<User> Users = new List<User>();
        public static List<Event> Events = new List<Event>();

        static SeedData()
        {
            Users.Add(new User {UserID=1,FirstName="Rifatul",LastName="Islam",ContactNumber="01712345678",Email="rifatul@gmail.com",UserType=UserType.Admin });
            Users.Add(new User {UserID=1,FirstName="Akhlakul",LastName="Islam",ContactNumber="01912345678",Email="shaker@gmail.com",UserType=UserType.Standard });
            Users.Add(new User {UserID=1,FirstName="Mahfuz",LastName="Mia",ContactNumber="01812345678",Email="mahfuz@gmail.com",UserType=UserType.External });
            Users.Add(new User {UserID=1,FirstName="Pranto",LastName="Islam",ContactNumber="01612345678",Email="pranto@gmail.com",UserType=UserType.Guest });


            Events.Add(new Event { EventId = 1, EventName = "Tech Conference", Description = "Latest trends in tech.", Date = DateTime.Now.AddDays(5), Address = "Dhaka",AssignedUser = Users[0] });
            Events.Add(new Event { EventId = 2, EventName = "Music Festival", Description = "Live bands and concerts.", Date = DateTime.Now.AddDays(10), Address = "Chittagong", AssignedUser = Users[1] });
            Events.Add(new Event { EventId = 3, EventName = "Startup Pitch", Description = "Pitch your startup idea.", Date = DateTime.Now.AddDays(-3), Address = "Sylhet", AssignedUser = Users[2] });
            Events.Add(new Event { EventId = 4, EventName = "Hackathon", Description = "24-hour coding challenge.", Date = DateTime.Now.AddDays(20), Address = "Dhaka", AssignedUser = Users[3] });
        }
    }
}
