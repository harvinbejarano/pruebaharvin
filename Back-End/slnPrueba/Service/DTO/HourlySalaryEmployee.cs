using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class HourlySalaryEmployee : Employee
    {
        public override decimal AnnualSalary
        {
            get
            {
                return 120 * this.HourlySalary * 12;
            }
        }

       
    }
}
