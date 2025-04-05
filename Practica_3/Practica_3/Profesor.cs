using System;

namespace Practica_3
{

	public class Profesor, Persona
	{
		private int antiguedad;
		
		public Profesor(string nombre, int dni, int antiguedad):base(nombre,dni)
		{
			this.antiguedad=antiguedad;			
		}
		
		public int getAntiguedad()
		{
			return this.antiguedad;
		}
		
		public void hablarEnClase()
		{
			Console.WriteLine("Hablando de algún tema");
		}
		
		public void escribirEnElPizarron()
		{
			Console.WriteLine("Escribiendo en el pizarrón");
		}
		
		
		// Metodos de Comparable
		public override bool SosIgual(Comparable comp)
		{
			return this.antiguedad.SosIgual(comp);
		}
		
		public override bool SosMenor(Comparable comp)
		{
			Profesor profe = (Profesor)comp;
			return this.antiguedad.SosMenor(profe.getAntiguedad());
		}
		
		public override bool SosMayor(Comparable comp)
		{
			Profesor profe = (Profesor)comp;
			return this.antiguedad.SosMayor(profe.getAntiguedad());
		}
	}
}
