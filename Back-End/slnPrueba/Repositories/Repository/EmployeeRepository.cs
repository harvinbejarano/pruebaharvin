using Newtonsoft.Json;
using Repositories.Contract;
using Repositories.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        public async Task<IEnumerable<EmployeeContract>> GetEmployeesAsync()
        {
            IEnumerable<EmployeeContract> employees = null;

            using (HttpClient client = new HttpClient())
            {
                string baseURL = ConfigurationManager.AppSettings["BaseEndpoint"];

                HttpResponseMessage response = await client.GetAsync(baseURL + "api/Employees");
                string employeesJson = await response.Content.ReadAsStringAsync();
                employees =
                    JsonConvert.DeserializeObject<IEnumerable<EmployeeContract>>(employeesJson);
            }

            return employees;
        }
    }
}
