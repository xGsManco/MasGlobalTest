using MasGlobalTest.Model.Enums;

namespace MasGlobalTest.Model.Models
{
    public abstract class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ContractTypeName ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal AnualSalary { get; set; }
    }
}
