using LeaveManagementSystem.Data;

namespace LeaveManagementSystem.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    { 
        public List<LeaveAllocationVM> leaveAllocations { get; set; }
    }
}
