using CrudNomina.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudNomina.Controllers
{
    public class ControlAreas
    {
        //Constructor
        public ControlAreas()
        {
            _Areas = new List<Areas>();
        }
        private List<Areas> _Areas;
        public List<Areas> Areas { get { return _Areas; } }


        #region Llenar_Areas
        public void Llenar_Areas()
        {
            Areas.Clear();
            Areas.Add(new Areas() 
            {
                id = 1,
                nombre_Area = "Investigacion y desarrollo"
            });
            
            Areas.Add(new Areas()
            {
                id = 2,
                nombre_Area = "Nomina"
            });
        }
        #endregion Llenar_Areas

        #region Mostrar_Areas
        public void getAreas()
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas select o);
            ImprimirAreas.Imprimir(lista);
        }
        #endregion Mostrar_Areas

        #region mostrar_Area_por_ID
        public void getAreaPorId(int id)
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas where o.id == id select o);
            ImprimirAreas.Imprimir(lista);
        }
        #endregion mostrar_Area_por_ID

        #region Llenar_Areas
        public void postAreas(int id, string nombre)
        {
            var verificarId = Areas.Any(i => i.id == id);
            if (!verificarId)
            {
                Areas.Add(new Areas()
                {
                    id = id,
                    nombre_Area = nombre
                });
                Console.WriteLine("201 : CREADO ");
            }
            else
            {
                Console.WriteLine("409 : CONFLICTO \n" +
                    "El ID Ya Existe!");
            }

        }
        #endregion Llenar_Areas

        #region Actualizar_Area
        public void update(int id, string nombre)
        {
            var ReplaceItem = new Areas
            {
                id = id,
                nombre_Area = nombre,
            };
            var element = Areas.FirstOrDefault(i => i.id == ReplaceItem.id);
            Areas.Remove(element);
            Areas.Add(ReplaceItem);
        }
        #endregion Actualizar_Area

        #region Eliminar_Area
        public void DeletexId(int id)
        {
            //var EliminarItem = new Productos { Id = id };
            var element = Areas.FirstOrDefault(i => i.id == id);
            Areas.Remove(element);
        }
        #endregion Eliminar_Area
    }
}
