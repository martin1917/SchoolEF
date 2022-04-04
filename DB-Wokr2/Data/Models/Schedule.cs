using System.ComponentModel.DataAnnotations.Schema;

namespace DB_Wokr2.Data.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int DayId { get; set; }
        public int LessonId { get; set; }
        public int GroupId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        [ForeignKey("DayId")]
        public Day? Day { get; set; }

        [ForeignKey("LessonId")]
        public LessonTime? LessonTime { get; set; }

        [ForeignKey("GroupId")]
        public Group? Group { get; set; }

        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

        [ForeignKey("TeacherId")]
        public Teacher? Teacher { get; set; }
    }
}
