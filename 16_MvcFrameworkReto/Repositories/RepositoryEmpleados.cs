using _16_MvcFrameworkReto.Data;
using _16_MvcFrameworkReto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _16_MvcFrameworkReto.Repositories
{
    public class RepositoryEmpleados : IRepositoryEmpleado
    {
        private IEmpleadoContext icontext;

        public RepositoryEmpleados(IEmpleadoContext icontext)
        {
            this.icontext = icontext;
        }

        public List<Empleado> GetEmpleados()
        {
            return this.icontext.Empleados.ToList();
        }
    }
}