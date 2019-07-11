using Repositories.Contract;
using Repositories.Core;
using Service.Core;
using Service.DTO;
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
          IEnumerable<EmployeeContract> employees =   await _EmployeeRepository.GetEmployeesAsync();

            return GetDtos(employees);
        }


        private IEnumerable<Employee> GetDtos(IEnumerable<EmployeeContract> employees)
        {
            throw new NotImplementedException();
        }

    }
}
