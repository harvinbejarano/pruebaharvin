using Repositories.Contract;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Utils
{
    public static class EmployeeFactory
    {

        public static Employee CreateEmpleyee(EmployeeContract e)
        {
            Employee employee = null; 

            if (e.ContractTypeName == "HourlySalaryEmployee")
                employee = CreateHourlySalaryEmployee(e);

            if (e.ContractTypeName == "MonthlySalaryEmployee")
                employee = CreateMonthtlySalaryEmployee(e);

            return employee;

        }

        private static MonthtlySalaryEmployee CreateMonthtlySalaryEmployee(EmployeeContract e)
        {
            return new MonthtlySalaryEmployee()
            {
                Id = e.Id,
                Name = e.Name,
                ContractTypeName = e.ContractTypeName,
                RoleId = e.RoleId,
                RoleName = e.RoleName,
                RoleDescription = e.RoleDescription,
                HourlySalary = e.HourlySalary,
                MonthlySalary = e.MonthlySalary
            };
        }

        private static HourlySalaryEmployee CreateHourlySalaryEmployee(EmployeeContract e)
        {
            return new HourlySalaryEmployee()
            {
                Id = e.Id,
                Name = e.Name,
                ContractTypeName = e.ContractTypeName,
                RoleId = e.RoleId,
                RoleName = e.RoleName,
                RoleDescription = e.RoleDescription,
                HourlySalary = e.HourlySalary,
                MonthlySalary = e.MonthlySalary
            };
        }


    }
}
