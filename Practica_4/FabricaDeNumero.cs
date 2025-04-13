using System;

namespace Practica_4
{

	public class FabricaDeNumero : FabricaDeComparables
	{		
		
		
		// Implemento metodos abstractos
		public override Comparable crearAleatorio()
		{
			return new Numero(gen.numeroAleatorio(1000));
		}
		
		
		public override Comparable crearPorTeclado()
		{
			return new Numero(lector.numeroPorTeclado());
		}
		
	}
}
