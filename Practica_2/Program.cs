using System;
using System.Runtime.InteropServices;
class Program 
{

    public static void Main(string[] args)
    {

        Pila pila = new Pila();
        Cola cola = new Cola();

        ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

        llenarAlumnos(pila);
        llenarAlumnos(cola);

        informar(multiple);
        imprimirElementos(multiple);

    }

    // Funciones
    public static void llenar(Coleccionable coleccionable)
    {
        Random random = new Random();
        for (int i = 0; i < 20; i++){
            Comparable comparable = new Numero(random.Next(1, 51)); // Aleatorio del 1 al 50
            coleccionable.agregar(comparable);
        }
    }

    public static void informar(Coleccionable coleccionable)
    {
        Console.WriteLine("Cantidad: " + coleccionable.cuantos().ToString());
        Console.WriteLine("Se está comparando min y max por el DNI");
        Console.WriteLine("Mínimo: " + coleccionable.minimo().ToString());
        Console.WriteLine("Máximo: " + coleccionable.maximo().ToString());

    }

    public static void llenarAlumnos(Coleccionable coleccionable)
    {
        Random random = new Random();

        for(int i = 0; i < 20; i++)
        {
            string nombre = generarNombre();
            Numero dni = new Numero(random.Next(10000000, 99999999));
            Numero legajo = new Numero(random.Next(10000, 99999));
            Numero promedio = new Numero(random.Next(1, 11));

            Alumno alumno = new Alumno(nombre, dni, legajo, promedio);      
            alumno.setEstrategia(new ComparacionPorDNI());
            coleccionable.agregar(alumno); 
        }
    }

    public static String generarNombre() // Esto lo hice para generar nombres reales en vez de Alumno1, Alumno2, etc.
    {
        Random random = new Random();

        string[] nombres = { "Santiago", "Maria", "Pedro", "Ana", "Luis", "Carla", "Jorge", "Laura", "Carlos", "Sofia" };
        string[] apellidos = { "Lovisotto", "Perez", "Lopez", "Martinez", "Fernandez", "Rodriguez", "Garcia", "Sanchez", "Diaz", "Morales" };

        return nombres[random.Next(0 , nombres.Length)] + apellidos[random.Next(0, apellidos.Length)];
    }

    public static void imprimirElementos(Coleccionable coleccionable)
    {
        Iterador iteradorColeccionable = coleccionable.crearIterador();
        
        for (iteradorColeccionable.primero(); !iteradorColeccionable.fin(); iteradorColeccionable.siguiente())
        {
            Console.WriteLine(iteradorColeccionable.actual());
        }
        
    }


}