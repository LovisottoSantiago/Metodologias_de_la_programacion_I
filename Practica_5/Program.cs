using MetodologíasDeProgramaciónI;
using System;

namespace Practica_5
{
	class Program
	{
		public static void Main(string[] args)
		{	
			/*
			// Ejercicio 2 Práctica 5
			Teacher teacher = new Teacher();
			
		 	// Crear 10 alumnos normales		
		    for (int i = 0; i < 10; i++)		
		    {		
				IAlumno proxy = (IAlumno)FabricaDeComparables.crearAleatorio(7); // proxy de alumno normal
				Student student = new AlumnoAdapter(proxy);
				teacher.goToClass(student);	
		    }				    
		    
		    // 10 alumnos muy estudiosos 
		    for (int i = 0; i < 10; i++)		
		    {		
				IAlumno proxy = (IAlumno)FabricaDeComparables.crearAleatorio(8); // proxy de alumno estudioso
				Student student = new AlumnoAdapter(proxy);
				teacher.goToClass(student);	
		    }
	
			teacher.teachingAClass();
			*/											
			
			
			// Ejercicio 10
			// ----- CON COLA -----
			Console.WriteLine("=== Usando Cola ===");

			Cola cola = new Cola();
			Aula aulaCola = new Aula();
			cola.setOrdenInicio(new OrdenInicio(aulaCola));
			cola.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aulaCola));
			cola.setOrdenAulaLlena(new OrdenAulaLlena(aulaCola));
			
			llenarAlumnos(cola, 5); // 20 alumnos decorados normales
			llenarAlumnos(cola, 6); // 20 alumnos decorados muy estudiosos

			Console.WriteLine("=== Fin con Cola ===\n");

			// ----- CON PILA -----
			Console.WriteLine("=== Usando Pila ===");

			Pila pila = new Pila();
			Aula aulaPila = new Aula();
			pila.setOrdenInicio(new OrdenInicio(aulaPila));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aulaPila));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aulaPila));
			
			llenarAlumnos(pila, 5);
			llenarAlumnos(pila, 6);

			Console.WriteLine("=== Fin con Pila ===");
		
			
			
			Console.ReadKey(true);
		}
		
		
		
	    public static void llenarAlumnos(Coleccionable coleccionable, int opcion)
	    {
	        
	    	for(int i = 0; i < 20; i++)
	        {
	    		Comparable elemento = FabricaDeComparables.crearAleatorio(opcion);
	    		coleccionable.agregar(elemento);
	        }
	    	
	    }
		
	}
}