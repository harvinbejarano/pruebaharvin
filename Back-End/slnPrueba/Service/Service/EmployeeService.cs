using Repositories.Contract;
using Repositories.Core;
using Service.Core;
using Service.DTO;
using Service.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _EmployeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _EmployeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            IEnumerable<Employee> employees = null;
            IEnumerable<EmployeeContract> employeeList = await _EmployeeRepository.GetEmployeesAsync();

            employees = employeeList.Select(e => EmployeeFactory.CreateEmpleyee(e));

            return employees.AsEnumerable();
        }
             

    }
}
