﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.BaseEntity
{
    public abstract class Base
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }

    }
}
  