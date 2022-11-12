using CrudNomina.Modals;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudNomina.Controllers
{
    public class ImprimirNominas
    {
        public static void Imprimir(List<Nominas_Empresa> Nomina)
        {
            //Instancia Control Empleados
            ControlNomina objNomina = new ControlNomina();
            foreach (var item in Nomina)
            {
                
                    Console.WriteLine("id " + item.id +
                        "\nFecha: " + item.fecha +
                        "\nId_Empleado: " + item.id_Empleado +
                        "\nSueldo Empleado: " + item.sueldoEmpleado +
                        "\nDias Laborados: " + item.dias +
                        "\nOtros Pagos:  " + item.otroPagos +
                        "\nTotal Basico: " + objNomina.totalBasico(item.sueldoEmpleado, item.dias) +
                         "\nTotal Devengado: " + objNomina.totalBevengados(item.sueldoEmpleado, item.dias, item.otroPagos) +
                         "\n"); 
                 
            }
        }
    }
}
