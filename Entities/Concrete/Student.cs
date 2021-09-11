﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Student:IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string GsmNumber { get; set; }

    }
}
