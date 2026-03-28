using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Modelos.Ejercicio4
{
    public class Vehiculo
    {
        string Modelo { get; set; }
        int Capacidad_tanque { get; set; }
        int Rendimiento { get; set; }

        public Vehiculo(string modelo, int capacidad_tanque, int rendimiento)
        {
            this.Modelo = modelo;
            this.Capacidad_tanque = capacidad_tanque;
            this.Rendimiento = rendimiento;
        }

        public double CalcularAutonomia()
        {
            return (Capacidad_tanque * Rendimiento);
        }

        public void NecesitaCombustible(double distancia)
        {
            double autonomia = CalcularAutonomia();
            if (distancia <= autonomia)
            {
                Console.WriteLine($"El vehiculo {Modelo} puede hacer el viaje de {distancia} km con total seguridad");
            }
            else
            {
                Console.WriteLine($"El vehiculo {Modelo} NO puede hacer el viaje de {distancia} km, proceda bajo su responsabilidad!");
            }

        }
    }
}
