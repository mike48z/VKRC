using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DiplomMisha.Model
{
    public class Student
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public int GroupOfStudentId { get; set; }
        public string Mail { get; set; }
        //public GroupOfStudent GroupOfStudent { get; set; }

        public Student() { }
        //public Student(string name, int groupID)
        //{
        //    Name = name;
        //    GroupOfStudentId = groupID;
        //}
        public Student(string name, string mail, string groupName)
        {
            Name = name;
            Mail = mail;
            ApplicationContext db = ApplicationContext.GetDbConnectionHandler();

            GroupOfStudent group = db.GroupOfStudents.FirstOrDefault(p => p.Name == groupName);

            GroupOfStudentId = group.Id;
        }

        //public Student(string name, GroupOfStudent group)
        //{
        //    Name = name;
        //    GroupOfStudent = group;
        //}
    }
}
