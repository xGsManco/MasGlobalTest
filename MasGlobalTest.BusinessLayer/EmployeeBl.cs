using MasGlobalTest.DataAccessLayer;
using MasGlobalTest.Model.Interfaces;
using MasGlobalTest.Model.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasGlobalTest.BusinessLayer
{
    public class EmployeeBl
    {
        public static async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            IList<Employee> employeeList = new List<Employee>();
            var employees = await EmployeeDal.GetEmployeesAsync();
            if (employees != null && employees.Any())
            {
                IEmployeeFactory factory = new EmployeeFactory();

                foreach (var employee in employees)
                {
                    var newEmployee = factory.GetEmployee(employee.ContractTypeName) as Employee;
                    newEmployee.Id = employee.Id;
                    newEmployee.Name = employee.Name;
                    newEmployee.ContractTypeName = employee.ContractTypeName;
                    newEmployee.RoleId = employee.RoleId;
                    newEmployee.RoleName = employee.RoleName;
                    newEmployee.RoleDescription = employee.RoleDescription;
                    newEmployee.HourlySalary = employee.HourlySalary;
                    newEmployee.MonthlySalary = employee.MonthlySalary;
                    (newEmployee as IEmployee).SetAnualSalary();
                    employeeList.Add(newEmployee);
                }
                return employeeList;
            }
            return null;
        }

        public static async Task<IEnumerable<Employee>> GetEmployeesAsync(int id)
        {
            return (await GetEmployeesAsync()).Where(k => k.Id == id).ToList();
        }
    }
}
