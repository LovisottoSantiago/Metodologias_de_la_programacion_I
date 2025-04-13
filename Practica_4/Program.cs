using System;

namespace Practica_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			FabricaDeAlumnos fabricaDeAlumnos = new FabricaDeAlumnos();
			Alumno a = (Alumno)fabricaDeAlumnos.crearAleatorio();
			
			Console.WriteLine(a.mostrarCalificacion());
			
			
			
			
			Console.ReadKey(true);
		}
	}
}