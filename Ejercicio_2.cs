using System;

namespace Ejercicio_2
{
    /*2---> Crear una clase Contacto. Esta clase deberá tener los atributos "nombre, apellidos, telefono y direccion". 
    También deberá tener un método "SetContacto", de tipo void y con los parámetros string, que permita cambiar 
    el valor de los atributos. También tendrá un método "Saludar", que escribirá en pantalla "Hola, soy " seguido de 
    sus datos. Crear también una clase llamada ProbarContacto. Esta clase deberá contener sólo la función Main, que 
    creará dos objetos de tipo Contacto, les asignará los datos del contacto y les pedirá que saluden.*/
    
    public class Contacto
    {
        public string nombre;
        public string apellido;
        public string telefono;
        public string direccion;

        public void SetContacto () 
        {
            nombre = Console.ReadLine();
            apellido = Console.ReadLine();
            telefono = Console.ReadLine();
            direccion = Console.ReadLine();
        }
        public void Saludar () 
        {
            Console.WriteLine($"\nHola, soy {nombre} {apellido}, mi numero es {telefono} y vivo en {direccion}");
        }
    }

    class CallContact
    {
        static void Main(string[] args)
        {
            Contacto contact1 = new Contacto();
            Console.WriteLine("\nPor favor, introduce los datos del nuevo contacto en el siguiente orden: ´nombre, apellido, numero y direccion´\n");
            contact1.SetContacto();
            contact1.Saludar();

            Contacto contact2 = new Contacto();
            Console.WriteLine("\nPor favor, introduce los datos del nuevo contacto en el siguiente orden: ´nombre, apellido, numero y direccion´\n");
            contact2.SetContacto();
            contact2.Saludar();
        }
    }
}