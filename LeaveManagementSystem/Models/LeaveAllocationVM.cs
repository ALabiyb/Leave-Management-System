using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display (Name = "Number of Days")]
        [Range(1, 50, ErrorMessage = "Invalid Number Entered")]
        public int NumberofDays { get; set; }

        [Required]
        [Display(Name = "Allocation Period")]
        public int Period { get; set; }

        public LeaveTypeVM? LeaveType { get; set; }
    }
}