# Core.net

## Introducción a la Programación Orientada a Objetos

Cuando creamos un nuevo proyecto lo primero que nos encontraremos es una clase con el método Main, por convención este es el primer método que se ejecuta en una aplicación por consola.

Para definir una clase tenemos que usar la palabra reservada “class” antes del nombre de la clase a definir, todos sus métodos y atributos se encontraran dentro de las llaves o curly brackets.

Para crear una nueva instancia de una clase debemos crear una variable y asignarle la palabra reservada “new” seguido del nombre de la clase.

Cada cosa definida dentro de una clase tiene un nivel de acceso, por defecto el nivel de acceso es privado o protegido y esto significa que no pueden modificar o acceder a ese atributo. Para poder acceder por fuera de la clase se debe asignar el nivel de acceso publico con la palabra reservada “public”.



```cs
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

```

