using System;
namespace Practica_5
	
{

	public class OrdenInicio : OrdenEnAula1
	{
		private Aula aula;
		
		public OrdenInicio(Aula aula)
		{
			this.aula = aula;
		}
		
		// Implemento interfaz
		public void ejecutar()
		{
			this.aula.comenzar();
		}
	}
}
