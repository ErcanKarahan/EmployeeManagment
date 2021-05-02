using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EmployeeManagement.Data.DbModels
{
    public class EmployeeLeaveType : BaseEntity
    {
        public string NAme { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
