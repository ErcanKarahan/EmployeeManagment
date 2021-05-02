using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;

namespace EmployeeManagement.Data.Implementation
{
    public class EmployeeLeaveTypeRepository : Repository<EmployeeLeaveType>, IEmployeeLeaveTypeRepository
    {
        private readonly EmployeeManagementContext _ctx;

        public EmployeeLeaveTypeRepository(EmployeeManagementContext ctx):base(ctx)
        {
            _ctx = ctx;
        }
    }

}
