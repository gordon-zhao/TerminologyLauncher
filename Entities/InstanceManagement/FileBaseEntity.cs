﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminologyLauncher.Entities.InstanceManagement
{
    public abstract class FileBaseEntity
    {
        public String Md5 { get; set; }
        public String LocalPath { get; set; }
    }
}