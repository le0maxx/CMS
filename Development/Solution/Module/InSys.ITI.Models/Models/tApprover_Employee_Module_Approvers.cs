﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InSys.ITI.Models.Models
{
    [Table("tApprover_Employee_Module_Approvers")]
    public class tApprover_Employee_Module_Approvers
    {
        public int ID { get; set; }
        public int? ID_Approver_Employee_Module { get; set; }
        public int ID_Employee { get; set; }
        public int? ID_Employee2 { get; set; }
        public int? ID_Employee3 { get; set; }
        public int ID_Level { get; set; }
        public bool IsPowerApprover { get; set; }
        public bool? IsActive { get; set; }
    }
    [NotMapped]
    public class vApprover_Employee_Module_Approvers
    {
        public int ID { get; set; }
        public int? ID_Approver_Employee_Module { get; set; }
        public int? ID_Employee { get; set; }
        public int? ID_Employee2 { get; set; }
        public int? ID_Employee3 { get; set; }
        public int ID_Level { get; set; }
        public bool IsPowerApprover { get; set; }
        public bool? IsActive { get; set; }
        public string Employee { get; set; }
        public string Employee2 { get; set; }
        public string Employee3 { get; set; }
        public string Image { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
    }
}
