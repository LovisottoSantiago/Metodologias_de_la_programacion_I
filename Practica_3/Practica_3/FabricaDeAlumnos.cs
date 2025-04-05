using System;

namespace Practica_3
{

	public class FabricaDeAlumnos : FabricaDeComparables
	{
				
		
		// Implemento metodos abstractos
		public override Comparable crearAleatorio()
		{
			return new Alumno(gen.stringAleatorio(), gen.numeroAleatorio(10000000), gen.numeroAleatorio(10000), (double)(gen.numeroAleatorio(10)));
		}
		
		
		public override Comparable crearPorTeclado()
		{
			return new Alumno(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), (double)(lector.numeroPorTeclado()));
		}
		
	}
}
