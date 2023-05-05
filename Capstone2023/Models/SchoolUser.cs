namespace Capstone2023.Models
{
    public class SchoolUser : User
    {
        public int? SchoolId { get; set; }
        public School School { get; set; }
    }
}
