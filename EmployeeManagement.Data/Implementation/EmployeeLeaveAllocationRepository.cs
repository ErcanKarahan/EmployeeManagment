using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;

namespace EmployeeManagement.Data.Implementation
{
    public class EmployeeLeaveAllocationRepository : Repository<EmployeeLeaveAllocation>, IEmployeeLeaveAllocationRepository
    {
        private readonly EmployeeManagementContext _ctx;


        public EmployeeLeaveAllocationRepository(EmployeeManagementContext ctx) : base(ctx)
        {
            _ctx = ctx;

        }
    }
}

