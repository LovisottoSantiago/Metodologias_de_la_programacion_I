using System;
namespace Practica_5
	
{
	// Ordenable = puede recibir ordenes
	public interface Ordenable
	{
		void setOrdenInicio(OrdenEnAula1 o);
		void setOrdenLlegaAlumno(OrdenEnAula2 o);
		void setOrdenAulaLlena(OrdenEnAula1 o);
	}
}
