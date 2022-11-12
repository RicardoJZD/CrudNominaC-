using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CrudNomina.Modals
{
    public class Nominas_Empresa
    {
        [Key]
        public int id { get; set; }
        public DateTime fecha { get; set; }
        [ForeignKey("id_Empleado")]
        public int id_Empleado { get; set; }
        public double sueldoEmpleado { get; set; }
        public double dias { get; set; } 
        public double otroPagos { get; set; } 
    }
}
