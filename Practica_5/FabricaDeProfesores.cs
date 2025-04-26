using System;

namespace Practica_5
{

	public class FabricaDeProfesores : FabricaDeComparables
	{		
		
		
		// Implemento metodos abstractos
		public override Comparable crearAleatorio()
		{
			return new Profesor(gen.nombreAleatorio(), new Numero(gen.numeroAleatorio(10000000)), gen.numeroAleatorio(35));
		}
		
		
		public override Comparable crearPorTeclado()
		{
			return new Profesor(lector.stringPorTeclado(), new Numero(lector.numeroPorTeclado()), lector.numeroPorTeclado());
		}
		
	}
}
