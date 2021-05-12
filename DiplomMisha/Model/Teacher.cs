using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DiplomMisha.Model
{
    public class Teacher
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }

        public Teacher() { }
        public Teacher(string name, string mail)
        {
            Name = name;
            Mail = mail;
        }
    }
}
