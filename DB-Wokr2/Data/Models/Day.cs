namespace DB_Wokr2.Data.Models
{
    public class Day
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string DayName { get; set; }


        public List<Schedule> Schedules { get; set; } = new();
    }
}
