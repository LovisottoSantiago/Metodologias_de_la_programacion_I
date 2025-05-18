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
			int opcion = 2; 
			
			IAlumno proxy = new AlumnoProxy(nombre, opcion);

	        IAlumno decorado1 = new DecoradorLegajo(proxy);
		    IAlumno decorado2 = new DecoradorNotaLetras(decorado1);
	 	    IAlumno decorado3 = new DecoradorCondicion(decorado2);
		    IAlumno decorado4 = new DecoratorAsteriscos(decorado3);

        	return decorado4;
		}
		
		
		public override Comparable crearPorTeclado()
		{
		    string nombre = lector.stringPorTeclado();
		    int opcion = 2;
		    
		    IAlumno proxy = new AlumnoProxy(nombre, opcion);
		    
		    IAlumno decorado1 = new DecoradorLegajo(proxy);
		    IAlumno decorado2 = new DecoradorNotaLetras(decorado1);
		    IAlumno decorado3 = new DecoradorCondicion(decorado2);
		    IAlumno decorado4 = new DecoratorAsteriscos(decorado3);
		    
		    return decorado4;
		}
		
	}
}
