using Repositories.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories.Core
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeContract>> GetEmployeesAsync();
    }
}
