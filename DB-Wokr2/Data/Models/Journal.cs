using System.ComponentModel.DataAnnotations.Schema;

namespace DB_Wokr2.Data.Models
{
    public class Journal
    {
        public int Id { get; set; }

        public int GroupId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public DateTime Date { get; set; }
        public bool HasAttended { get; set; }
        public int? Mark { get; set; }

        [ForeignKey("GroupId")]
        public Group? Group { get; set; }

        [ForeignKey("StudentId")]
        public Student? Student { get; set; }
        
        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

        [ForeignKey("Teacher Id")]
        public Teacher? Teacher { get; set; }
    }
}
