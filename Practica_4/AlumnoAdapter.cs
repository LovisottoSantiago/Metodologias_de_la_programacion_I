using System;
using MetodologíasDeProgramaciónI;

namespace Practica_4
{

	public class AlumnoAdapter : Student
	{
		protected Alumno alumno;
		
		public AlumnoAdapter(Alumno alumno)
		{
			this.alumno = alumno;
		}
		
		
		// Implemento los métodos de Student
		public string getName()
		{
			return alumno.getNombre();
		}
		
		public Alumno getAlumno()
		{
			return this.alumno;
		}
		
		public int yourAnswerIs(int question)
		{
			return alumno.responderPregunta(question);
		}
		
		public void setScore(int score)
		{
			alumno.setCalificacion(score);
		}
		
		public string showResult()
		{
			return alumno.mostrarCalificacion();
		}
		
		public bool equals(Student student)
		{
			Alumno stu = ((AlumnoAdapter)student).getAlumno();
			return alumno.sosIgual(stu);
		}
		
		public bool lessThan(Student student)
		{
			Alumno stu = ((AlumnoAdapter)student).getAlumno();
			return alumno.sosMenor(stu);
		}
		
		public bool greaterThan(Student student)
		{
			Alumno stu = ((AlumnoAdapter)student).getAlumno();
			return alumno.sosMayor(stu);
		}
		
	}
}
