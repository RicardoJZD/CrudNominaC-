using CrudNomina.Modals;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudNomina.Controllers
{
    class Menu
    {
        static int menuPrincipal()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Principal \n" +
                    "1. AREAS \n" +
                    "2. EMPLEADOS \n" +
                    "3. NOMINA EMPRESA \n" +
                    "4. SALIR");
                opcion = Int32.Parse(Console.ReadLine());
            } while (opcion <= 0 || opcion > 4);
            return opcion;
        }

        static int menuAreas()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Areas \n" +
                    "1. AGREGAR \n" +
                    "2. VER \n" +
                    "3. BUSCAR POR ID \n" +
                    "4. ACTUALIZAR \n" +
                    "5. ELIMINAR \n " +
                    "6. SALIR \n");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion <= 0 || opcion > 7);
            return opcion;
        }

        static int menuEmpleados()

        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Empleados \n" +
                    "1. AGREGAR \n" +
                    "2. VER TODOS \n" +
                    "3. BUSCAR POR ID \n"+
                    "4. ACTUALIZAR \n" +
                    "5. ELIMINAR \n " +
                    "6. SALIR \n");
                opcion = Int32.Parse(Console.ReadLine());
            } while (opcion <= 0 || opcion > 7);
            return opcion;
        }

        static int menuNomina()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Nomina \n" +
                    "1. AGREGAR \n" +
                    "2. VER TODAS\n" +
                    "3. BUSCAR POR ID \n" +
                    "4. ACTUALIZAR \n" +
                    "5. ELIMINAR \n " +
                    "6. SALIR \n");
                opcion = Int32.Parse(Console.ReadLine());
            } while (opcion <= 0 || opcion > 7);
            return opcion;
        }

        public void mainMenu() 
        {
            //Instancias Areas
            ControlAreas objAreas = new ControlAreas();
            Areas objA = new Areas();
            //Instancias Nomina
            Nominas_Empresa objNomina = new Nominas_Empresa();
            ControlNomina obj = new ControlNomina();
            //INstancia Empleados
            ControladorEmpleados objEmpl = new ControladorEmpleados();
            //

            int opcion;
            opcion = menuPrincipal();
            do
            {
                switch (opcion)
                {
                    case 1:
                        int opcArea = 0;
                        do
                        {
                            opcArea = menuAreas();
                            switch (opcArea)
                            {
                                case 1:
                                    objAreas.Llenar_Areas();
                                    int i;
                                    string name;
                                    Console.WriteLine("Digita el ID");
                                    i = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Digita el Nuevo Nombre de Area:");
                                    name = Console.ReadLine();
                                    objAreas.postAreas(i, name);
                                    objAreas.getAreas();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Write("Las Areas Son \n");
                                    objAreas.Llenar_Areas();
                                    objAreas.getAreas();
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    int idBusqueda;
                                    Console.Write("Buscar Por ID");
                                    Console.WriteLine("Digita el ID a buscar");
                                    idBusqueda = Int32.Parse(Console.ReadLine());
                                    Console.Clear();
                                    objAreas.getAreaPorId(idBusqueda);
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    int ide;
                                    string nam;
                                    Console.WriteLine("Editar Empleados");
                                    Console.WriteLine("Digita el ID");
                                    ide = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Digita el Nuevo Nombre de Area:");
                                    nam = Console.ReadLine();
                                    objAreas.update(ide, nam);
                                    objAreas.getAreas();
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    int idElimnar;
                                    Console.WriteLine("Eliminar Areas: ");
                                    Console.Write("Introduzca Id: ");
                                    idElimnar = Convert.ToInt32(Console.ReadLine());
                                    objAreas.DeletexId(idElimnar);
                                    objAreas.getAreas();
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Presiona Enter para regresar al menú Principal");
                                    Console.ReadKey();
                                    opcion = menuPrincipal();
                                    break;

                            }
                        } while (opcArea != 6);
                        break;
                    case 2:
                        int opcEmpleados;
                        do
                        {
                            opcEmpleados = menuEmpleados();
                            switch (opcEmpleados)
                            {
                                case 1:
                                    objEmpl.llenarEmpleado();
                                    int i, iA;
                                    string nom, ape, dir, tel, fecha;
                                    Console.WriteLine("Digita el ID");
                                    i = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Digita el Nombre Del Empleado:");
                                    nom = Console.ReadLine();
                                    Console.WriteLine("Digita el Apellido del Empleado");
                                    ape = Console.ReadLine();
                                    Console.WriteLine("Digita La direccion del Empleado:");
                                    dir = Console.ReadLine();
                                    Console.WriteLine("Digita el telefono del Empleado:");
                                    tel = Console.ReadLine();
                                    Console.WriteLine("Digite la fecha del empleado");
                                    fecha = Console.ReadLine();
                                    Console.WriteLine("Digite el id del Area");
                                    iA = Convert.ToInt32(Console.ReadLine());
                                    objEmpl.postEmpleados(i, nom, ape, dir, tel, fecha, iA);
                                    objEmpl.get();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Write("Los Empleados Son \n");
                                    objEmpl.llenarEmpleado();
                                    objEmpl.get();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    int idBusqueda;
                                    Console.Write("Buscar Por ID");
                                    Console.WriteLine(" digita el ID a buscar");
                                    idBusqueda = Int32.Parse(Console.ReadLine());
                                    Console.Clear();
                                    objEmpl.getbyId(idBusqueda);
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.WriteLine("Editar Areas");
                                    int ide, iE;
                                    string no, ap, di, te, fec;
                                    Console.WriteLine("Digita el ID");
                                    ide = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Digita el Nombre Del Empleado:");
                                    no = Console.ReadLine();
                                    Console.WriteLine("Digita el Apellido del Empleado");
                                    ap = Console.ReadLine();
                                    Console.WriteLine("Digita La direccion del Empleado:");
                                    di = Console.ReadLine();
                                    Console.WriteLine("Digita el telefono del Empleado:");
                                    te = Console.ReadLine();
                                    Console.WriteLine("Digite la fecha del empleado");
                                    fec = Console.ReadLine();
                                    Console.WriteLine("Digite el id del Area");
                                    iE = Convert.ToInt32(Console.ReadLine());
                                    objEmpl.update(ide, no, ap, di, te, fec, iE);
                                    objEmpl.get();
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    int idElimnarE;
                                    Console.WriteLine("Eliminar Empleado: ");
                                    Console.Write("Introduzca Id: ");
                                    idElimnarE = Convert.ToInt32(Console.ReadLine());
                                    objEmpl.DeletexId(idElimnarE);
                                    objEmpl.get();
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Presiona Enter para regresar al menú Principal");
                                    Console.ReadKey(); 
                                    opcion = menuPrincipal();
                                    break;
                            }
                        } while (opcEmpleados != 6);
                        break;
                    case 3:
                        int opcNomina;
                        do
                        {
                            opcNomina = menuNomina();
                            switch (opcNomina)
                            {
                                case 1:
                                    obj.Llenar_Nomina();
                                    Console.WriteLine("Llenar Datos de Nomina");
                                    Console.Write("Introduzca Id: ");
                                    objNomina.id = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Fecha: ");
                                    objNomina.fecha = Convert.ToDateTime(Console.ReadLine());
                                    Console.Write("Introduzca id del empleado: ");
                                    objNomina.id_Empleado = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca sueldo: ");
                                    objNomina.sueldoEmpleado = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduzca dias laborados: ");
                                    objNomina.dias = Convert.ToInt32(Console.ReadLine());
                                    if (objNomina.dias > 30)
                                    {
                                        Console.WriteLine("Los dias no pueden ser mayor a 30");
                                        Console.Write("Introduzca dias laborados: ");
                                        objNomina.dias = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.Write("Introduzca otros pagos: ");
                                    objNomina.otroPagos = Convert.ToDouble(Console.ReadLine());
                                    obj.postNomina(objNomina.id, objNomina.fecha, objNomina.id_Empleado, objNomina.sueldoEmpleado, Convert.ToDouble(objNomina.dias), objNomina.otroPagos);
                                    obj.getNominas();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Write("Nominas Son \n");
                                    obj.Llenar_Nomina();
                                    obj.getNominas();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    int idBusqueda;
                                    Console.Write("Buscar Por ID");
                                    Console.WriteLine(" digita el ID a buscar");
                                    idBusqueda = Int32.Parse(Console.ReadLine());
                                    Console.Clear();
                                    obj.getNominaPorId(idBusqueda);
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    int idNuevo, id_EmpleadoNuevo,diasNuevos;
                                    DateTime fechaNueva;
                                    double sueldoEmpleadoNuevo, otroPagosNuevo;
                                    Console.WriteLine("Editar Nomina");
                                    Console.Write("Introduzca Id: ");
                                    idNuevo = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Fecha: ");
                                    fechaNueva = Convert.ToDateTime(Console.ReadLine());
                                    Console.Write("Introduzca id del empleado: ");
                                    id_EmpleadoNuevo = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca sueldo: ");
                                    sueldoEmpleadoNuevo = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduzca dias laborados: ");
                                    diasNuevos = Convert.ToInt32(Console.ReadLine());
                                    if (diasNuevos > 30)
                                    {
                                        Console.WriteLine("Los dias no pueden ser mayor a 30");
                                        Console.Write("Introduzca dias laborados: ");
                                        diasNuevos = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.Write("Introduzca otros pagos: ");
                                    otroPagosNuevo = Convert.ToDouble(Console.ReadLine());
                                    obj.updateNomina(idNuevo,fechaNueva,id_EmpleadoNuevo,sueldoEmpleadoNuevo,diasNuevos,otroPagosNuevo);
                                    obj.getNominas();
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    int idElimnarN;
                                    Console.WriteLine("Eliminar Nomina: ");
                                    Console.Write("Introduzca Id: ");
                                    idElimnarN = Convert.ToInt32(Console.ReadLine());
                                    obj.DeletexId(idElimnarN);
                                    obj.getNominas();
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Presiona Enter para regresar al menú Principal");
                                    opcion = menuPrincipal();
                                    Console.ReadKey();
                                    break;
                            }
                        } while (opcNomina != 6);
                        break;
                    default:
                        Console.WriteLine("Gracias Por Utilizar La App");
                        break;
                }
            } while (opcion != 4);
        }
    }
}
