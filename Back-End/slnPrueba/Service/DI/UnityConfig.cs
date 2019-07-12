using Service.Core;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Service.DI
{
    public static class UnityConfig
    {

        public static void RegisterComponents(UnityContainer container)
        {
            Repositories.DI.UnityConfig.RegisterComponents(container);

            container.RegisterType<IEmployeeService, EmployeeService>();
        }
    }
}
