//Llamo a las librecia system
using System;

class DtosPer // Creo la classe Datos Personales
{
    public static void Main(string[] datospersonales)//Metodo Principal,nombre argumentos,

    {
        Console.WriteLine("Cual es tu nombre?");//Instruccion 
        String nombre; //Tipo Variable
        nombre = Console.ReadLine(); //Lee los datos ingresados ala variable
        Console.WriteLine("Tu nombre  es: " + nombre); //Retorna los datos

        Console.WriteLine("Cual es tu apellido?");
        String apellido;
        apellido = Console.ReadLine();
        Console.WriteLine("Tu apellido es: " + apellido);

        Console.WriteLine("Cual es tu direccion?");
        String direccion;
        direccion = Console.ReadLine();
        Console.WriteLine("Tu direccion es: " + direccion);

        int edad; //Tipo de varianble numerica
        Console.WriteLine("Cual es tu edad?");//La consola consulta la edad
        edad = int.Parse(Console.ReadLine());//Lee el valor ingresado a la variable y sea diferende de nulo
        Console.WriteLine("Tu edad es: " + edad);//La consola escribe la informacion de la variable

        int cedula;
        Console.WriteLine("Cual es tu cedula?");
        cedula = int.Parse(Console.ReadLine());
        Console.WriteLine("Tu cedula es: " + cedula);
        Console.ResetColor();


        Console.WriteLine("Que te parecio la clase?");
        String clase;
        clase = Console.ReadLine();
        Console.WriteLine("Segun tu opinion la clase te parecio:" + clase + "\n Gracias por tu comentario");


        Console.ReadKey();
        Console.Clear();
        Console.Beep();


    }





}