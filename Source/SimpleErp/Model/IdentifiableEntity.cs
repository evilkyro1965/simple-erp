﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace simpleerp.model
{
    public abstract class IdentifiableEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
