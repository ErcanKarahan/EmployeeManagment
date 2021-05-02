using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeVM
    {
        public string Id { get; set; }
        [Display(Name="Kullanıcı Adı")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
