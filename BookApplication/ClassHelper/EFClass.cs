﻿using BookApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplication.ClassHelper
{
    public class EFClass
    {
        public static Entities context { get; set; } = new Entities();
    }
}
