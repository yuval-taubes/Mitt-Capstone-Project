namespace Capstone2023.Models
{
    public class Incident
    {
        public int? Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public int StudentClassroomId { get; set; }
        public StudentClassroom StudentClassroom { get; set; }

        public string Message { get; set; }
    }
}
