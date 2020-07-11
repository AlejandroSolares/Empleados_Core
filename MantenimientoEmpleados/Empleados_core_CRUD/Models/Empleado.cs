using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados_core_CRUD.Models
{
    public class Empleado
    {
        [Key]
        public int Empleado_ID { get; set; }//PK

        [Column(TypeName ="nvarchar(45)")]
        public string Empleado_Cod { get; set; }

        [Column(TypeName = "nvarchar(70)")]
        public string Empleado_Nomvre { get; set; }

        [Column(TypeName = "nvarchar(70)")]
        public string Empleado_Apellido { get; set; }

        [Column(TypeName = "nvarchar(45)")]
        public string Empleado_Correo { get; set; }

        
        public int Empleado_Departamento { get; set; }//FK
    }
}
