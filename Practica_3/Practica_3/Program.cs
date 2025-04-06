using System;
using System.Runtime.InteropServices;

namespace Practica_3
{
	
	class Program 
	{
	    // Random
	    private static Random random = new Random();
	
	    public static void Main(string[] args)
	    {
	    	// Usar fabrica de profesores (falta eso)
	    	Profesor profe = new Profesor("Mauro", new Numero(123456), 4);
	    	
	    	Coleccionable col = new Pila();
	    	llenar(col, 2);	    	
	    	
	    	Iterador iterador = col.crearIterador();
	    	
	    	for (iterador.primero(); !iterador.fin(); iterador.siguiente())
	        {
	    		profe.agregarObservador((Observador)iterador.actual());
	        }
	    	
	    	dictadoDeClase(profe);
	       
	       Console.ReadKey();
	    }
	
	    // Funciones
	    public static void llenar(Coleccionable coleccionable, int opcion)
	    {
	        for (int i = 0; i < 20; i++){
	    		Comparable elemento = FabricaDeComparables.crearAleatorio(opcion);
	            coleccionable.agregar(elemento);
	        }
	    }
	
	    public static void informar(Coleccionable coleccionable, int opcion)
	    {        
	        Console.WriteLine("Cantidad: " + coleccionable.cuantos().ToString());
	        Console.WriteLine("Mínimo: " + coleccionable.minimo().ToString());
	        Console.WriteLine("Máximo: " + coleccionable.maximo().ToString());
	        
	        Comparable elemento = FabricaDeComparables.crearPorTeclado(opcion); // (1) Para Numero
	        
	        if(coleccionable.contiene(elemento))
	        {
	        	Console.WriteLine("Está");
	        }
	        else 
	        {
	        	Console.WriteLine("No está");
	        }
	
	    }
	
	    public static void llenarAlumnos(Coleccionable coleccionable)
	    {
	        
	    	for(int i = 0; i < 20; i++)
	        {
	    		Comparable elemento = FabricaDeComparables.crearAleatorio(2); // (2) Para crear Alumnos
	    		coleccionable.agregar(elemento);
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
	    
	    public static void dictadoDeClase(Profesor profe)
	    {
	    	for (int i= 0; i < 5; i++)
	    	{
	    		profe.hablarEnClase();
	    		profe.escribirEnElPizarron();
	    	}
	    }
	
	}	
	
}