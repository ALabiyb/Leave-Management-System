using LeaveManagementSystem.Data;
using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leavTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int Period);
        Task<EmployeeAllocationVM> GetEmployeeAllocation(string employeeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocations(int employeeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);

    }
}
