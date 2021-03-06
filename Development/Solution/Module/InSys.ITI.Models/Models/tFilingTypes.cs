﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InSys.ITI.Models.Models
{
    [Table("tFilingTypes")]
    public class tFilingTypes
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class vFilingTypeCount { 
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
