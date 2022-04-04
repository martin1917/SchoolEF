﻿namespace DB_Wokr2.Data.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Group> Groups { get; set; } = new();
        public List<Teacher> Teachers { get; set; } = new();
        public List<Schedule> Schedules { get; set; } = new();
        public List<Journal> Journals { get; set; } = new();
    }
}
