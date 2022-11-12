using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CrudNomina.Modals
{
    public class Empleados
    {
        //Constructor
        public Empleados() { }
        [Key]
        public int id { get; set; }
        public string nombre_Empleado { get; set; }
        public string apellido_Empleado { get; set; }
        public string direccion_Empleado { get; set; }
        public string telefono_Empleado { get; set; }
        public string fecha_Empleado { get; set; } 
        [ForeignKey("id_area")]
        public int id_Area { get; set; }

    }
}
