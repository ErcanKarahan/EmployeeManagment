using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeLeaveTypeVM : BaseVM
    {
        [Required]
        public string NAme { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }

        // MVVM Create Employee
        public void SetEmployeeType(string name)
        {
            this.NAme = name;
        }
    }
}
