﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity
{
    public class Module
    {
        public int ModuleId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Credits { get; set; }

    }
}
