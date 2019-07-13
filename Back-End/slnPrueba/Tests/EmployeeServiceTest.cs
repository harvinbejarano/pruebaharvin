using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Repositories.Contract;
using Repositories.Core;
using Service.DTO;
using Service.Service;

namespace Tests
{
    [TestClass]
    public class EmployeeServiceTest
    {
        private IEmployeeRepository EmployeeRepository;


        [TestInitialize]
        public void TestInitialize()
        {
            EmployeeRepository = Substitute.For<IEmployeeRepository>();
        }

        [TestMethod]
        public void GetEmployeesAsyncTest_ExpectedBehavior()
        {
            var employeeService = CreateService();
            EmployeeRepository.GetEmployeesAsync().Returns(
                new Task<IEnumerable<EmployeeContract>>(GetData)
                );


            var result = employeeService.GetEmployeesAsync();

            Assert.IsTrue(result != null);
        }

        private IEnumerable<EmployeeContract> GetData()
        {
            IEnumerable<EmployeeContract> list = new List<EmployeeContract>()
            {
                new EmployeeContract(){Id=1,Name="x", ContractTypeName= "HourlySalaryEmployee",RoleId=1,RoleName="xx",HourlySalary=60000,MonthlySalary=80000}
            };

            return list;
        }

        private EmployeeService CreateService()
        {
            return new EmployeeService(EmployeeRepository);
        }


    }
}
