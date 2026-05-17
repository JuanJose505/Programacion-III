using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaCar_S.A.Datos;
using RentaCar_S.A.Entidades;

namespace RentaCar_S.A.Logica
{
    public class VehiculoService
    {
        VehiculoDato dato = new VehiculoDato();

        public void AgregarVehiculo(Vehiculo v)
        {
            dato.AgregarVehiculo(v);
        }
         
        public List<Vehiculo> Listar()
        {
            return dato.ObtenerVehiculos();
        }

    }
}
