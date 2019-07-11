using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class MonthtlySalaryEmployee : Employee
    {
        public override decimal AnnualSalary()
        {
            return this.MonthlySalary * 12;
        }
    }
}
