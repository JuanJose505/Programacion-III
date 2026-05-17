using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using RentaCar_S.A.Entidades;

namespace RentaCar_S.A.Datos
{
    public class VehiculoDato
    {
         string ruta = "vehiculos.txt";

        public void AgregarVehiculo(Vehiculo v)
        {
            string linea = $"{v.Id},{v.Placa},{v.Marca},{v.Modelo},{v.Year},{v.PrecioPorDia}";
            File.AppendAllText(ruta, linea);
        }

        public List<Vehiculo> ObtenerVehiculos()
        {
            var lista = new List<Vehiculo>();

            if (!File.Exists(ruta))
            {
                return lista;
            }
            

            var lineas = File.ReadAllLines(ruta);

            foreach (var linea in lineas)
            {
                var datos = linea.Split(',');

                Vehiculo v = new Vehiculo()
                {
                    Id = int.Parse(datos[0]),
                    Placa = datos[1],
                    Marca = datos[2],
                    Modelo = datos[3],
                    Year = int.Parse(datos[4]),
                    PrecioPorDia = double.Parse(datos[5])

                };

                lista.Add(v);
            }


            return lista;


            
        }
    }
}
