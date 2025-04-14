using System;
using MetodologíasDeProgramaciónI;

namespace Practica_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// EJERCICIO 8
			FabricaDeAlumnos fabricaAlumnos = new FabricaDeAlumnos();
			
			Teacher teacher = new Teacher();
			
		 	// Crear 10 alumnos normales		
		    for (int i = 0; i < 10; i++)		
		    {		
		        Alumno alumno = (Alumno)fabricaAlumnos.crearAleatorio();		
		        IAlumno decorado1 = new DecoradorLegajo(alumno);
		        IAlumno decorado2 = new DecoradorNotaLetras(decorado1);
		        IAlumno decorado3 = new DecoradorCondicion(decorado2);
		        IAlumno decorado4 = new DecoratorAsteriscos(decorado3);
		        
		        Student student = new AlumnoAdapter(decorado4);
		        teacher.goToClass(student);		
		    }				    
		    
		    // 10 alumnos muy estudiosos
		    FabricaAlumnosMuyEstudiosos f = new FabricaAlumnosMuyEstudiosos();		
		    for (int i = 0; i < 10; i++)		
		    {		
		    	AlumnoMuyEstudioso alumnoEstudioso = (AlumnoMuyEstudioso)f.crearAleatorio();
		    	IAlumno decorado1 = new DecoradorLegajo(alumnoEstudioso);
		        IAlumno decorado2 = new DecoradorNotaLetras(decorado1);
		        IAlumno decorado3 = new DecoradorCondicion(decorado2);
		        IAlumno decorado4 = new DecoratorAsteriscos(decorado3);
		        
		        Student student = new AlumnoAdapter(decorado4);		
		        teacher.goToClass(student);		
		    }
	
			teacher.teachingAClass();
			
			
			
			
			
			/* EJERCICIO 4
			FabricaDeAlumnos fabricaAlumnos = new FabricaDeAlumnos();
			
			Teacher teacher = new Teacher();
			
		 	// Crear 10 alumnos normales		
		    for (int i = 0; i < 10; i++)		
		    {		
		        Alumno alumno = (Alumno)fabricaAlumnos.crearAleatorio();		
		        Student student = new AlumnoAdapter(alumno);		
		        teacher.goToClass(student);		
		    }				    
		    FabricaAlumnosMuyEstudiosos f = new FabricaAlumnosMuyEstudiosos();
		    // Crear 10 alumnos muy estudiosos		
		    for (int i = 0; i < 10; i++)		
		    {		
		    	AlumnoMuyEstudioso alumnoEstudioso = (AlumnoMuyEstudioso)f.crearAleatorio();
		        Student student = new AlumnoAdapter(alumnoEstudioso);		
		        teacher.goToClass(student);		
		    }
			
			teacher.teachingAClass();
			
			*/
			
			
			
			Console.ReadKey(true);
		}
	}
}