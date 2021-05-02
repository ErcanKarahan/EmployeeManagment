using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementBusinessEngine.Contracts;

namespace EmployeeManagement.UI.Controllers
{
    public class EmployeeLeaveTypes : Controller
    {
        private readonly IEmployeeLeaveTypeBusinessEngine _employeeLeaveTypeBusinessEngine;

        public EmployeeLeaveTypes(IEmployeeLeaveTypeBusinessEngine employeeLeaveTypeBusinessEngine)
        {
            _employeeLeaveTypeBusinessEngine = employeeLeaveTypeBusinessEngine;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
