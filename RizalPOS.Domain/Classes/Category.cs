﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RizalPOS.Domain.Classes
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category ParentCategory { get; set; }

    }
}
