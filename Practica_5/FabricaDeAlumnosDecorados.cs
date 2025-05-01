using System;

namespace Practica_5
{

	public class FabricaAlumnosDecorados : FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			Alumno alumno = new Alumno(gen.nombreAleatorio(), new Numero(gen.numeroAleatorio(10000000)), new Numero(gen.numeroAleatorio(10000)), (double)(gen.doubleAleatorio(10)), (int)(gen.numeroAleatorio(10)));
			IAlumno decorado1 = new DecoradorLegajo(alumno);
		    IAlumno decorado2 = new DecoradorNotaLetras(decorado1);
	 	    IAlumno decorado3 = new DecoradorCondicion(decorado2);
		    IAlumno decorado4 = new DecoratorAsteriscos(decorado3);
		    return decorado4;
		}
		
		
		public override Comparable crearPorTeclado()
		{
			Alumno alumno = new Alumno(lector.stringPorTeclado(), new Numero(lector.numeroPorTeclado()), new Numero(lector.numeroPorTeclado()), (double)(lector.doublePorTeclado()), (int)(lector.numeroPorTeclado()));
		    IAlumno decorado1 = new DecoradorLegajo(alumno);
		    IAlumno decorado2 = new DecoradorNotaLetras(decorado1);
	 	    IAlumno decorado3 = new DecoradorCondicion(decorado2);
		    IAlumno decorado4 = new DecoratorAsteriscos(decorado3);
		    return decorado4;
		}
	}
}
