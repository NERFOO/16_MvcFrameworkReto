using _16_MvcFrameworkReto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace _16_MvcFrameworkReto.Data
{
    public class EmpleadoContext : DbContext, IEmpleadoContext
    {
        public EmpleadoContext() :base("name=sqlServer") { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}