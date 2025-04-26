using System;

namespace Practica_5
{

	public class DecoradorLegajo : AlumnoDecorator
	{
		public DecoradorLegajo(IAlumno alumno) : base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
		{
			string legajo = " (" + this.alumnoAdicional.getLegajo().ToString() + ")";
			string resultadoBase = base.mostrarCalificacion();
			
			int espacioIndex = resultadoBase.IndexOf(',');
			string resultadoConLegajo = resultadoBase.Insert(espacioIndex, legajo);
			
			return resultadoConLegajo;
		}
		
	}
}
