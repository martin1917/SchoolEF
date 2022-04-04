using System.ComponentModel.DataAnnotations.Schema;

namespace DB_Wokr2.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string? Patronymic { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        public Group? Group { get; set; }

        public List<Journal> Journals { get; set; } = new();
    }
}
