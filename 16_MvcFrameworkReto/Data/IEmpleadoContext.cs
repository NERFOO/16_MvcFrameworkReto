using _16_MvcFrameworkReto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_MvcFrameworkReto.Data
{
    public interface IEmpleadoContext
    {
        DbSet<Empleado> Empleados { get;  set; }
    }
}
