using System;

namespace CoreEscuela.Entidades
{
    public class Cursos
    {
        public string UniqueId{get; set;}
        public string Nombre{get;set;}
        public TiposJornada Jornada{get; set;}

        public Cursos()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}