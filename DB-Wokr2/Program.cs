using DB_Wokr2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DB_Wokr2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new ApplicationContext())
            {
                Teacher teacher1 = new Teacher { Name = "Denis", SurName = "Taktashkin", Age = 42, Experience = 15 };
                Teacher teacher2 = new Teacher { Name = "Vladimir", SurName = "Troyanskiya", Age = 61, Experience = 21 };
                Teacher teacher3 = new Teacher { Name = "Maria", SurName = "Orlova", Patronymic = "Petrovna", Age = 29, Experience = 3 };
                db.Teachers.AddRange(teacher1, teacher2, teacher3);

                Group group1 = new Group { Name = "5A" };
                Group group2 = new Group { Name = "6A", Teacher = teacher3 };
                Group group3 = new Group { Name = "7A" };
                db.Groups.AddRange(group1, group2, group3);
                db.SaveChanges();

                Student student1 = new Student { Name = "Maksim", SurName = "Levin", Patronymic = "Vyacheslavovich", Age = 19, Group = group1 };
                Student student2 = new Student { Name = "Vlad", SurName = "Kilyagin", Patronymic = "Sergeevich", Age = 22, Group = group1 };
                Student student3 = new Student { Name = "Anton", SurName = "Ivanov", Patronymic = "Ivanovich", Age = 14, Group = group3 };
                Student student4 = new Student { Name = "Kolya", SurName = "Potryankin", Patronymic = "Popovich", Age = 26, Group = group2 };
                Student student5 = new Student { Name = "Michel", SurName = "Black", Patronymic = "Vyacheslavovich", Age = 31, Group = group3 };
                Student student6 = new Student { Name = "Alex", SurName = "Melnikov", Age = 19, Group = group2 };
                db.Students.AddRange(student1, student2, student3, student4, student5, student6);
                db.SaveChanges();

                Subject subject1 = new Subject { Name = "math" };
                Subject subject2 = new Subject { Name = "Englich Language" };
                Subject subject3 = new Subject { Name = "physics" };
                Subject subject4 = new Subject { Name = "programming" };
                Subject subject5 = new Subject { Name = "Pravo" };
                db.Subjects.AddRange(subject1, subject2, subject3, subject4, subject5);

                teacher1.Subjects.Add(subject1);
                teacher1.Subjects.Add(subject4);
                teacher2.Subjects.Add(subject2);
                teacher3.Subjects.Add(subject3);
                teacher3.Subjects.Add(subject5);

                group1.Subjects.Add(subject1);
                group1.Subjects.Add(subject2);
                group1.Subjects.Add(subject3);
                group2.Subjects.Add(subject2);
                group2.Subjects.Add(subject3);
                group3.Subjects.Add(subject4);
                group3.Subjects.Add(subject5);

                db.SaveChanges();

                LessonTime lessonTime1 = new LessonTime { Number = 1, BeginTime = DateTime.Parse("08:00"), EndTime = DateTime.Parse("09:35") };
                LessonTime lessonTime2 = new LessonTime { Number = 2, BeginTime = DateTime.Parse("09:50"), EndTime = DateTime.Parse("11:25") };
                LessonTime lessonTime3 = new LessonTime { Number = 3, BeginTime = DateTime.Parse("11:40"), EndTime = DateTime.Parse("13:15") };
                LessonTime lessonTime4 = new LessonTime { Number = 4, BeginTime = DateTime.Parse("13:45"), EndTime = DateTime.Parse("15:15") };
                LessonTime lessonTime5 = new LessonTime { Number = 5, BeginTime = DateTime.Parse("15:35"), EndTime = DateTime.Parse("17:10") };
                LessonTime lessonTime6 = new LessonTime { Number = 6, BeginTime = DateTime.Parse("17:25"), EndTime = DateTime.Parse("18:50") };
                db.LessonTimes.AddRange(lessonTime1, lessonTime2, lessonTime3, lessonTime4, lessonTime5, lessonTime6);
                db.SaveChanges();

                Day day1 = new Day { Number = 1, DayName = "Ponedelnik" };
                Day day2 = new Day { Number = 2, DayName = "Vtornik" };
                Day day3 = new Day { Number = 3, DayName = "Sreda" };
                Day day4 = new Day { Number = 4, DayName = "Chetverg" };
                Day day5 = new Day { Number = 5, DayName = "Pytnica" };
                Day day6 = new Day { Number = 6, DayName = "Subbote" };
                Day day7 = new Day { Number = 7, DayName = "Voskresenie" };
                db.Days.AddRange(day1, day2, day3, day4, day5, day6, day7);
                db.SaveChanges();

                Schedule schedule1 = new Schedule { Day = day1, LessonTime = lessonTime1, Group = group1, Subject = subject1, Teacher = teacher1 };
                Schedule schedule2 = new Schedule { Day = day1, LessonTime = lessonTime2, Group = group1, Subject = subject4, Teacher = teacher1 };
                Schedule schedule3 = new Schedule { Day = day2, LessonTime = lessonTime3, Group = group3, Subject = subject3, Teacher = teacher3 };
                Schedule schedule4 = new Schedule { Day = day2, LessonTime = lessonTime5, Group = group2, Subject = subject2, Teacher = teacher2 };
                db.Schedules.AddRange(schedule1, schedule2, schedule3, schedule4);
                db.SaveChanges();

                Journal journal1 = new Journal { Group = group1, Student = student1, Teacher = teacher2, Subject = subject2, Date = DateTime.Now, HasAttended = true, Mark = 5 };
                Journal journal2 = new Journal { Group = group1, Student = student3, Teacher = teacher1, Subject = subject4, Date = DateTime.Now, HasAttended = false };
                Journal journal3 = new Journal { Group = group3, Student = student1, Teacher = teacher3, Subject = subject3, Date = DateTime.Now, HasAttended = true };
                Journal journal4 = new Journal { Group = group2, Student = student1, Teacher = teacher2, Subject = subject2, Date = DateTime.Now, HasAttended = true, Mark = 3 };
                db.Journals.AddRange(journal1, journal2, journal3, journal4);
                db.SaveChanges();
            }
        }
    }
}