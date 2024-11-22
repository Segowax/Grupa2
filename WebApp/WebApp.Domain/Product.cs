﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
