﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DiplomMisha.Model
{
    public class ClassRoom
    {
        [Key] public int Id {get; set;}
        public string Name { get; set; }
        public string Description { get; set; }

        public ClassRoom() { }
        public ClassRoom(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
