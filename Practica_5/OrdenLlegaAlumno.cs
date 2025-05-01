using System;
namespace Practica_5
	
{

	public class OrdenLlegaAlumno : OrdenEnAula2
	{
		private Aula aula;
		public OrdenLlegaAlumno(Aula aula)
		{
			this.aula = aula;
		}
		
		// Implemento interfaz
		public void ejecutar(Comparable comp)
		{
			this.aula.nuevoAlumno((IAlumno)comp);
		}
		
	}
}
