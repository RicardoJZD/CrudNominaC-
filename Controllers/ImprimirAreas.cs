using CrudNomina.Modals;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudNomina.Controllers
{
    public class ImprimirAreas
    {
        public static void Imprimir(List<Areas> Areas)
        {
            foreach (var item in Areas)
            {
                Console.WriteLine("Id {0} Nombre {1}", item.id,
                    item.nombre_Area);
            }
        }
    }
}

