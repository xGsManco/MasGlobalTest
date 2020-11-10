using MasGlobalTest.Model.Interfaces;

namespace MasGlobalTest.Model.Models
{
    public class MonthlySalaryEmployee : Employee, IEmployee
    {
        public void SetAnualSalary()
        {
            this.AnualSalary = MonthlySalary * 12;
        }
    }
}
