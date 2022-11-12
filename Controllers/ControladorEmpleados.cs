using CrudNomina.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudNomina.Controllers
{
    public class ControladorEmpleados
    {

        #region Constructor
        //Constructor de la clase
        public ControladorEmpleados()
        {
            //Creacion de la listta
            _Empleados = new List<Empleados>();
        }
        private List<Empleados> _Empleados;
        public List<Empleados> Empleados { get { return _Empleados; } }
        #endregion Constructor

        #region Llenar datos
        //Crear un empleado
        public void llenarEmpleado()
        {
            Empleados.Clear();
            Empleados.Add(new Empleados()
            {
                id = 1,
                nombre_Empleado = "Miguel",
                apellido_Empleado = "Vidal",
                direccion_Empleado = "34fcra",
                telefono_Empleado = "635464",
                fecha_Empleado = "2022/11/11",
                id_Area = 123

            });
            Empleados.Add(new Empleados()
            {
                id = 2,
                nombre_Empleado = "Ricardo",
                apellido_Empleado = "Zabaleta",
                direccion_Empleado = "99fcFa",
                telefono_Empleado = "72635",
                fecha_Empleado = "2022/11/11",
                id_Area = 1234

            });
        }
        #endregion Llenar empleado

        #region Metodos get
        //Metodo Para obtener todos los Empleados de la lista
        public void get()
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados select o);
            ImprimirEmpleados.Imprimir(lista);
        }

        //Traer empleados por Id
        public void getbyId(int id)
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados where o.id == id select o);
            ImprimirEmpleados.Imprimir(lista);
        }
        #endregion Metodos get
        #region Ingresar Empleados
        //Ingresar Empleados
        public void postEmpleados(int id, string nombre_Empleado, string apellido_Empleado, string direccion_Empleado,
            string telefono_Empleado, string fecha_Empleado, int id_Area)
        {
            var verificarId = Empleados.Any(i => i.id == id);
            if (!verificarId)
            {
                Empleados.Add(new Empleados()
                {
                    id = id,
                    nombre_Empleado = nombre_Empleado,
                    apellido_Empleado = apellido_Empleado,
                    direccion_Empleado = direccion_Empleado,
                    telefono_Empleado = telefono_Empleado,
                    fecha_Empleado = fecha_Empleado,
                    id_Area = id_Area
                });
                Console.WriteLine("201 : CREADO ");
            }
            else
            {
                Console.WriteLine("409 : CONFLICTO \n" +
                    "El ID Ya Existe!");
            }
        }

        #endregion Ingresar Empleados

        #region Actualizar
        //put
        public void update(int id, string nombre_Empleado, string apellido_Empleado, string direccion_Empleado,
            string telefono_Empleado, string fecha_Empleado, int id_Area)
        {
            var ReplaceEmpleado = new Empleados
            {
                id = id,
                nombre_Empleado = nombre_Empleado,
                apellido_Empleado = apellido_Empleado,
                direccion_Empleado = direccion_Empleado,
                telefono_Empleado = telefono_Empleado,
                fecha_Empleado = fecha_Empleado,
                id_Area = id_Area
            };
            var element = Empleados.FirstOrDefault(i => i.id == ReplaceEmpleado.id);
            Empleados.Remove(element);
            Empleados.Add(ReplaceEmpleado);
        }
        #endregion Actualizar

        #region Borrar por Id
        //Delete por Id
        public void DeletexId(int id)
        {
            var element = Empleados.FirstOrDefault(i => i.id == id);
            Empleados.Remove(element);
        }
        #endregion Borrar por Id


    }
}
