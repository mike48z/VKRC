using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DiplomMisha.Model
{
    public class Lesson
    {
        [Key] public int Id { get; set; }
        public int TeacherId { get; set; }
        public int GroupId { get; set; }
        public int DisciplineId { get; set; }
        public int ClassRoomId { get; set; }
        public int DayOFWeek { get; set; }
        public int LessonTime { get; set; }

        public Lesson() { }
    }
}
