using System.ComponentModel.DataAnnotations;

namespace DB_Wokr2.Data.Models
{
    public class LessonTime
    {
        public int Id { get; set; }
        public int Number { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm}")]
        public DateTime BeginTime { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm}")]
        public DateTime EndTime { get; set; }

        public List<Schedule> Schedules { get; set; } = new();
    }
}
