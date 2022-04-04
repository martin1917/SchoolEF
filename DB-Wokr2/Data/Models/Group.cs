using System.ComponentModel.DataAnnotations.Schema;

namespace DB_Wokr2.Data.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Tutor { get; set; }

        [ForeignKey("Tutor")]
        public Teacher? Teacher { get; set; }

        public List<Student> Students { get; set; } = new();
        public List<Subject> Subjects { get; set; } = new();
        public List<Schedule> Schedules { get; set; } = new();
        public List<Journal> Journals { get; set; } = new();
    }
}
