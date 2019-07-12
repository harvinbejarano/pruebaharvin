using Repositories.Core;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Repositories.DI
{
    public static class UnityConfig
    {

        public static void RegisterComponents(UnityContainer container)
        {
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
