using System;

namespace Ejercicio_1
{
    /*1---> Crear una clase Persona que tenga como atributos el "cedula, nombre, apellido y la edad 
    (definir las propiedades para poder acceder a dichos atributos)". Definir como responsabilidad un método 
    para mostrar ó imprimir. Crear una segunda clase Profesor que herede de la clase Persona. Añadir un atributo sueldo 
    ( y su propiedad) y el método para imprimir su sueldo. Definir un objeto de la clase Persona y llamar a sus métodos 
    y propiedades. También crear un objeto de la clase Profesor y llamar a sus métodos y propiedades.*/
    class persona
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public int edad{ get; set; }
        public string apellido { get; set; }

        public void mostrar(string cedula, string nombre, string apellido, int edad)
        {
            mostrar(cedula,nombre,apellido, edad);
        }
    }
    class profesor: persona
    {
        public int sueldo { get; set; }
        public String mostrar(string M)
        {
            return M;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            persona P = new persona();
            profesor Prof = new profesor();
            P.cedula = "402-1859203-5";
            P.nombre = " Miguel";
            P.edad = 26;
            P.apellido = " Del Leon";

            Prof.sueldo = 45000;

            Console.WriteLine("\n Hola soy {0} {1} tengo {2} años y mi cedula es {3}. \n", P.nombre, P.apellido, P.edad, P.cedula);

            Prof.cedula = "402-1652204-3";
            Prof.nombre = " Jose";
            Prof.edad = 25;
            Prof.apellido = "Perez";
            Prof.sueldo = 48000;

            Console.WriteLine("Hola soy{0} {1} tengo {2} años y mi cedula es {3} y tengo un sueldo de {4} pesos.", Prof.nombre, Prof.apellido, Prof.edad, Prof.cedula, Prof.sueldo);
            Console.ReadKey();
        }
    }
}