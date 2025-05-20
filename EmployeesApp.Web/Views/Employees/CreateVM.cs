using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Views.Employees
{
    public class CreateVM
    {
        public required string Name { get; set; }
        [Required(ErrorMessage = "Enter an email")]
        [Display(Name = "Name", Prompt = "Name")]
        public required string  Email { get; set; }
        [Range(4, 4, ErrorMessage = "Wrong number")]
        [Display(Name = "Name", Prompt = "What is 2 + 2?")]
        public int BotCheck { get; set; } 

        
    }
}
