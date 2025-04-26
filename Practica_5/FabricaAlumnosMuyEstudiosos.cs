using System;

namespace Practica_5
{

	public class FabricaAlumnosMuyEstudiosos : FabricaDeComparables
	{
				
		
		// Implemento metodos abstractos
		public override Comparable crearAleatorio()
		{
			return new AlumnoMuyEstudioso(gen.nombreAleatorio(), new Numero(gen.numeroAleatorio(10000000)), new Numero(gen.numeroAleatorio(10000)), (double)(gen.doubleAleatorio(10)), (int)(gen.numeroAleatorio(10)));
		}
		
		
		public override Comparable crearPorTeclado()
		{
			return new AlumnoMuyEstudioso(lector.stringPorTeclado(), new Numero(lector.numeroPorTeclado()), new Numero(lector.numeroPorTeclado()), (double)(lector.doublePorTeclado()), (int)(lector.numeroPorTeclado()));
		}
		
	}
}
