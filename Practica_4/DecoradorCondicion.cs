using System;

namespace Practica_4
{

	public class DecoradorCondicion : AlumnoDecorator
	{
		public DecoradorCondicion(IAlumno alumno) : base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
		{	
			if (this.alumnoAdicional.getCalificacion() >= 7)
			{
				return base.mostrarCalificacion() + " (PROMOCIONADO)";
			}
			else if (this.alumnoAdicional.getCalificacion() >= 4)
			{
				return base.mostrarCalificacion() + " (APROBADO)";
			}
			else {
				return base.mostrarCalificacion() + " (DESAPROBADO)";
			}
		}
		
	}
}
