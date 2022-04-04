namespace DB_Wokr2.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string? Patronymic { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public List<Subject> Subjects { get; set; } = new();
        public List<Schedule> Schedules { get; set; } = new();
        public List<Journal> Journals { get; set; } = new();
    }
}
