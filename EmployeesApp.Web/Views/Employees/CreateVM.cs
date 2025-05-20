using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Views.Employees
{
    public class CreateVM
    {
        public required string Name { get; set; }
        [Required(ErrorMessage = "Invalid email")]
        [Display(Name = "E-mail", Prompt = "Enter e-mail")]
        public required string  Email { get; set; }
        [Range(4, 4, ErrorMessage = "Wrong number")]
        [Display(Name = "What is 2 + 2?", Prompt = "Bot check")]
        public int BotCheck { get; set; } 

        
    }
}
