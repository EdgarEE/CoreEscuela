using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {

            var escuela = new Escuela("cursoeee",2015,TiposEscuela.Primaria,
                                      pais: "Francia", ciudad: "Marce"
                                      );
            
            var curso1 = new Cursos()
            {
                Nombre="101"
            };

            var curso2 = new Cursos()
            {
                Nombre="201"
            };

            var curso3 = new Cursos()
            {
                Nombre="301"
            };
            Console.WriteLine(escuela);
            Console.WriteLine("------------------");
            Console.WriteLine(curso1.Nombre + ", "+ curso1.UniqueId);
            Console.WriteLine($"{curso2.Nombre},{curso2.UniqueId}");
            Console.WriteLine($"{curso3.Nombre},{curso3.UniqueId}");
        }
    }
}
