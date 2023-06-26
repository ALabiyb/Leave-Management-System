using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Data
{
    public class LeaveType : BaseEntity
    {
        [Required (ErrorMessage = "Please enter Leave Type")]
        [Display (Name = "Leave Type Name")]
        public string Name { get; set; }
        [Display (Name = "Default Number of Days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please enter number between 1 and 25")]
        public int DefaultDays { get; set; }
    }
}
