using System;
namespace Practica_5
	
{

	public class OrdenAulaLlena : OrdenEnAula1
	{
		private Aula aula;
		public OrdenAulaLlena(Aula aula)
		{
			this.aula = aula;
		}
		
		// Implemento interfaz
		public void ejecutar()
		{
			this.aula.claseLista();
		}
		
	}
}
