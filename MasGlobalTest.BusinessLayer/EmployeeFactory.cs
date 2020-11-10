using MasGlobalTest.Model.Enums;
using MasGlobalTest.Model.Interfaces;
using MasGlobalTest.Model.Models;

namespace MasGlobalTest.BusinessLayer
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public IEmployee GetEmployee(ContractTypeName contractTypeName)
        {
            switch (contractTypeName)
            {
                case ContractTypeName.HourlySalaryEmployee: return new HourlySalaryEmployee();
                case ContractTypeName.MonthlySalaryEmployee: return new MonthlySalaryEmployee();
                default: return null;
            }
        }
    }
}
