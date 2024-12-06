﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.BaseEntity;

namespace WebApp.Domain
{
    public class Product : Base
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
