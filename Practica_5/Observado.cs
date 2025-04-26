using System;

namespace Practica_5
{

	public interface Observado // El profesor
	{
		void agregarObservador(Observador o);
		void quitarObservador(Observador o);
		void notificar();
	}
}
