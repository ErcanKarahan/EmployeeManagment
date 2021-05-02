using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Data.Contracts;
using EmployeeManagementBusinessEngine.Contracts;

namespace EmployeeManagementBusinessEngine.Implemantation
{
    public class EmployeeLeaveTypeBusinessEngine:IEmployeeLeaveTypeBusinessEngine
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeLeaveTypeBusinessEngine(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
