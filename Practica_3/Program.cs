using System;
using System.Runtime.InteropServices;

namespace Practica_3
{
	
	class Program 
	{
		
	    public static void Main(string[] args)
	    {	    	
	    	Profesor profe = (Profesor)new FabricaDeProfesores().crearAleatorio();
	    	
	    	Coleccionable col = new Pila();
	    	llenar(col, 2);	    
	    	
	    	Iterador iterador = col.crearIterador();
	    	
	    	for (iterador.primero(); !iterador.fin(); iterador.siguiente())
	        {
	    		profe.agregarObservador((Observador)iterador.actual());
	        }
	    	
	    	Console.WriteLine("Profesor: " + profe.getNombre());
	    	dictadoDeClase(profe); 
	       
	       Console.ReadKey();
	    }
	
	    // Funciones
	    public static void llenar(Coleccionable coleccionable, int opcion)
	    {
	        for (int i = 0; i < 20; i++){
	    		Comparable elemento = FabricaDeComparables.crearAleatorio(opcion);
	            coleccionable.agregar(elemento);
	            // Console.WriteLine("Agregado: " + elemento); 
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
	        	Console.WriteLine("El elemento leído está en la colección.");
	        }
	        else 
	        {
	        	Console.WriteLine("El elemento leído no está en la colección.");
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
	    		Console.WriteLine("");
	    		profe.hablarEnClase();
	    		Console.WriteLine("");
	    		profe.escribirEnElPizarron();
	    	}
	    }
	
	}	
	
}