using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados_core_CRUD.Models
{
    public class Empleados_Context:DbContext
    {
        public Empleados_Context(DbContextOptions<Empleados_Context> options):base(options)
        {
             
        }


        public DbSet<Empleado> Empleados { get; set; }
    }
}
