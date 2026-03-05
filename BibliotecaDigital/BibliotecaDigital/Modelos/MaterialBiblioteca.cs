using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDigital.Modelos
{
    public abstract class MaterialBiblioteca
    {
        int Id { get; set; }
        string Titulo { get; set; }
        string Autor { get; set; }
        int YearPublication { get; set; }
        string Categoria { get; set; }

        protected MaterialBiblioteca(int id, string titulo, string autor, int yearpublication, string categoria)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.YearPublication = yearpublication;
            this.Categoria = categoria;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("                    INFORMACION                      ");
            Console.WriteLine("=====================================================");
            Console.WriteLine($"Titulo : {Titulo}");
            Console.WriteLine($"Autor : {Autor}");
            Console.WriteLine($"Año de publicacion : {YearPublication}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Categoria : {Categoria}");
        }

        
    }
        

}
