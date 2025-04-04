using System;
using System.Runtime.InteropServices;

namespace Practica_2
{
	
	class Program 
	{
		// Random
		private static Random random = new Random();
	
	    public static void Main(string[] args)
	    {
	        
	        Pila pila = new Pila();
	        llenarAlumnos(pila);
	        cambiarEstrategia(pila, new ComparacionPorNombre());
	        Console.WriteLine("Comparando por nombre (alfabeticamente): ");
	        informar(pila);
	
	        cambiarEstrategia(pila, new ComparacionPorLegajo());
	        Console.WriteLine("\nComparando por legajo: ");
	        informar(pila);
	        
	
	        cambiarEstrategia(pila, new ComparacionPorPromedio());
	        Console.WriteLine("\nComparando por promedio: ");
	        informar(pila);
	        
	        cambiarEstrategia(pila, new ComparacionPorDNI());
	        Console.WriteLine("\nComparando por dni: ");
	        informar(pila);
	        
	                
	        /*  Ejercicio 7
	        Pila pila = new Pila();
	        Cola cola = new Cola();
	        Conjunto conjunto = new Conjunto();
	
	        llenarAlumnos(pila);
	        llenarAlumnos(cola);
	        llenarAlumnos(conjunto);
	
	        imprimirElementos(pila);
	        imprimirElementos(cola);
	        imprimirElementos(conjunto);
	        */
	       
	       Console.ReadKey();
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
	        Console.WriteLine("Mínimo: " + coleccionable.minimo().ToString());
	        Console.WriteLine("Máximo: " + coleccionable.maximo().ToString());
	
	    }
	
	    public static void llenarAlumnos(Coleccionable coleccionable)
	    {
	
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
	        string[] nombres = { "Santiago", "Maria", "Pedro", "Ana", "Luis", "Carla", "Jorge", "Laura", "Carlos", "Sofia" };
	        string[] apellidos = { "Lovisotto", "Perez", "Lopez", "Martinez", "Fernandez", "Rodriguez", "Garcia", "Sanchez", "Diaz", "Morales" };
	
	        return nombres[random.Next(0 , nombres.Length)] + " " + apellidos[random.Next(0, apellidos.Length)];
	    }
	
	    public static void imprimirElementos(Coleccionable coleccionable)
	    {
	        Iterador iteradorColeccionable = coleccionable.crearIterador();
	        
	        for (iteradorColeccionable.primero(); !iteradorColeccionable.fin(); iteradorColeccionable.siguiente())
	        {
	            Console.WriteLine(iteradorColeccionable.actual());
	        }
	        
	    }
	
	    public static void cambiarEstrategia(Coleccionable coleccionable, EstrategiaDeComparacion estrategiaDeComparacion)
	    {
	        Iterador iterador = coleccionable.crearIterador();
	        for (iterador.primero(); !iterador.fin(); iterador.siguiente())
	        {
	            Comparable comp = iterador.actual();
	            Alumno alumno = (Alumno)comp;
	            alumno.setEstrategia(estrategiaDeComparacion);
	        }
	    }
	
	}	
	
}