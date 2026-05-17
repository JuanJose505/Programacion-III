using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaLasañas
{
    internal class ClienteController
    {


        public string ValidarCliente(Cliente cliente)
        {
            if (cliente.Nombre == "")
            {
                return "Ingrese un nombre para un cliente";
            }
            if (cliente.Diadeentrega == "")
            {
                return "Ingrese un dia de entrega";
            }
            if (cliente.Horadeentrega == "")
            {
                return "Ingrese una hora de entrega";
            }
            if (cliente.Cantidadvendida.ToString() == "")
            {
                return "Ingrese una cantidad";
            }

            return "Cliente validado con exito";
        }
        
        public List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();

            if (!File.Exists("clientes.csv"))
            {
                return null;
            }
            var lineas = File.ReadLines("clientes.csv");
            foreach (var linea in lineas)
            {
                var campo = linea.Split(';');
                Cliente cliente = new Cliente();
                cliente.Nombre = campo[0];
                cliente.Diadeentrega = campo[1];
                cliente.Horadeentrega = campo[2];
                cliente.Cantidadvendida = int.Parse(campo[3]);
                clientes.Add(cliente);
            }

            
            return clientes;
        }

        public void AgregarCliente(Cliente cliente)
        {
            string linea = $"{cliente.Nombre};{cliente.Diadeentrega};{cliente.Horadeentrega};{cliente.Cantidadvendida}";
            File.AppendAllText("clientes.csv",linea + Environment.NewLine);
        }

        public void GuardarLista(List<Cliente> lista)
        {
            List<string> lineas = new List<string>();

            foreach (var cliente in lista)
            {
                string linea = $"{cliente.Nombre};{cliente.Diadeentrega};{cliente.Horadeentrega};{cliente.Cantidadvendida}";
                lineas.Add(linea);
            }

            File.WriteAllLines("clientes.csv", lineas);
        }
    }
}
