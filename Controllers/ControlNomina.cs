using CrudNomina.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudNomina.Controllers
{
    public class ControlNomina:Nominas_Empresa
    {
        public ControlNomina() 
        {
            _Nomina = new List<Nominas_Empresa>();
        }

        private List<Nominas_Empresa> _Nomina;
        public List<Nominas_Empresa> Nomina { get { return _Nomina; } }

       
        public void getNominas()
        {
            List<Nominas_Empresa> lista = new List<Nominas_Empresa>();
            lista.AddRange(from o in Nomina select o);
            ImprimirNominas.Imprimir(lista);
        }

        
        #region Nominas_Llenas
        public void Llenar_Nomina()
        {
            Nomina.Clear();
            Nomina.Add(new Nominas_Empresa()
            {
                id = 1,
                fecha = DateTime.Now,
                id_Empleado = 1,
                sueldoEmpleado = 1200000,
                dias = 20,
                otroPagos = 1000000
            });
            Nomina.Add(new Nominas_Empresa()
            {
                id = 2,
                fecha = DateTime.Now,
                id_Empleado = 2,
                sueldoEmpleado = 1200000,
                dias = 30,
                otroPagos = 100000
            });
        }
        #endregion

        #region Buscar_Nomina_Por_Id
        public void getNominaPorId(int id)
        {
            List<Nominas_Empresa> lista = new List<Nominas_Empresa>();
            lista.AddRange(from o in Nomina where o.id == id select o);
            ImprimirNominas.Imprimir(lista);
        }
        #endregion Buscar_Nomina_Por_Id

        #region Llenar_nomina
        public void postNomina(int id, DateTime fecha, int id_E, double sueldo, double dias, double otros)
        {
            Nomina.Add(new Nominas_Empresa()
            {
               id = id,
               fecha = fecha,
               id_Empleado = id_E,
                sueldoEmpleado = sueldo,
               dias = dias,
               otroPagos = otros
            });
        }
        #endregion

        #region actualizar_Nomina
        public void updateNomina(int id, DateTime fecha, int id_Empleado, double sueldoEmpleado, int dias, double otroPagos)
        {
            var ReplaceItem = new Nominas_Empresa
            {
                id = id,
                fecha = fecha,
                id_Empleado = id_Empleado,
                sueldoEmpleado = sueldoEmpleado,
                dias = dias,
                otroPagos = otroPagos
            };
            var element = Nomina.FirstOrDefault(i => i.id == ReplaceItem.id);
            Nomina.Remove(element);
            Nomina.Add(ReplaceItem);
        }
        #endregion

        #region Eliminar_nomina
        public void DeletexId(int id)
        {
            var element = Nomina.FirstOrDefault(i => i.id == id);
            Nomina.Remove(element);
        }
        #endregion

        #region Calculo_Basico
        public double totalBasico(double suel, double dia)
        {
            sueldoEmpleado = suel;
            dias = dia;

            return sueldoEmpleado * (dias / 30);
        }
        #endregion

        #region Calculo_Devengados
        public double totalBevengados(double suel, double di, double otrosP)
        {
            double totalB;
            double totalD;
            sueldoEmpleado = suel;
            dias = di;
            otroPagos = otrosP;

            totalB = sueldoEmpleado * (dias / 30);

            totalD = totalB + otroPagos;

            return totalD;
        }
        #endregion
    }
}
