using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Data.DbModels;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EmployeeManagement.Data.Contracts
{
    public interface IEmployeeLeaveTypeRepository:IReposteryBase<EmployeeLeaveType>
    {
    }
}
