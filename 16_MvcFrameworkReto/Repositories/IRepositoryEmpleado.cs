using _16_MvcFrameworkReto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_MvcFrameworkReto.Repositories
{
    public interface IRepositoryEmpleado
    {
        List<Empleado> GetEmpleados();
    }
}
