using System;

namespace Practica_5
{

	public class FabricaDeAlumnosProxy : FabricaDeComparables
	{
		public FabricaDeAlumnosProxy()
		{
		}
		
		public override Comparable crearAleatorio()
		{
			string nombre = gen.nombreAleatorio();
			int opcion = 5; // Decorados
			
			IAlumno proxy = new AlumnoProxy(nombre, opcion);

        	return proxy;
		}
		
		
		public override Comparable crearPorTeclado()
		{
		    string nombre = lector.stringPorTeclado();
		    int opcion = 5;
		    
		    IAlumno proxy = new AlumnoProxy(nombre, opcion);		  
		    
		    return proxy;
		}
		
	}
}
