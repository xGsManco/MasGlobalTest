using MasGlobalTest.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasGlobalTest.DataAccessLayer
{
    public static class EmployeeDal
    {
        public static async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
        {
            var SERVICES_URL = "http://masglobaltestapi.azurewebsites.net/api/Employees";

            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            try
            {
                var response = await client.GetAsync(SERVICES_URL);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var employees = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<EmployeeDto>>(result);
                    return employees;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return new List<EmployeeDto>();
        }
    }
}
