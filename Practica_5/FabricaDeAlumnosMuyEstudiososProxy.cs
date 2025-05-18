using System;

namespace Practica_5
{

	public class FabricaDeAlumnosMuyEstudiososProxy : FabricaDeComparables
	{
		public FabricaDeAlumnosMuyEstudiososProxy()
		{
		}
		
		public override Comparable crearAleatorio()
		{
			string nombre = gen.nombreAleatorio();
			int opcion = 6; // Decorado
			
			IAlumno proxy = new AlumnoProxy(nombre, opcion);

        	return proxy;
		}
		
		public override Comparable crearPorTeclado()
		{
			string nombre = lector.stringPorTeclado();
			int opcion = 6; 
			
		    IAlumno proxy = new AlumnoProxy(nombre, opcion);
		    
		    return proxy;
		}
		
	}
}
