using MetodologíasDeProgramaciónI;
using System;

namespace Practica_5
{
	public class Aula
	{
		private Teacher teacher;
		
		
		public Aula()
		{
		}
		
		
		public void comenzar()
		{
			Console.WriteLine("Comienza la clase");
			this.teacher = new Teacher();
		}
		
		public void nuevoAlumno(IAlumno alumno)
		{
			this.teacher.goToClass(new AlumnoAdapter(alumno));
		}
		
		public void claseLista()
		{
			this.teacher.teachingAClass();
		}
		
	}
}
