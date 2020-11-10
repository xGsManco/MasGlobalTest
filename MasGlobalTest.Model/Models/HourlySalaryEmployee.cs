using MasGlobalTest.Model.Interfaces;

namespace MasGlobalTest.Model.Models
{
    public class HourlySalaryEmployee : Employee,  IEmployee
    {
        public void SetAnualSalary()
        {
            this.AnualSalary= 120 * HourlySalary * 12;
        }
    }
}
