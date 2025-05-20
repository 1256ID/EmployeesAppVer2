using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Views.Employees
{
    public class IndexVM
    {

        public required EmployeeItemVM[] EmployeeItems { get; set; }
        public class EmployeeItemVM
        {
            public required string Name { get; set; }
            public required int Id { get; set; }
            public bool ShowAsHighlighted { get => Email.StartsWith("admin"); }  
            public required string Email { get; set; }
        }

    }
}
