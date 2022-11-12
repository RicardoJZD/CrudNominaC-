using CrudNomina.Modals;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudNomina.Controllers
{
    class ImprimirEmpleados
    {
        public static void Imprimir(List<Empleados> Empleados)
        {
            foreach (var item in Empleados)
            {
                 Console.WriteLine("Id {0} Nombre {1} Apellido {2} Telefono {3} Direccion {4} Fecha {5} IdArea {6} ", 
                 item.id, item.nombre_Empleado, item.apellido_Empleado, item.telefono_Empleado, item.direccion_Empleado, item.fecha_Empleado, item.id_Area);
            }
        }
    }
}
