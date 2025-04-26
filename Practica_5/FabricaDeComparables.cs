using System;

namespace Practica_5
{

	public abstract class FabricaDeComparables
	{
		
		protected GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
		protected LectorDeDatos lector = new LectorDeDatos();
		
		// Metodos estaticos
		public static Comparable crearAleatorio(int opcion)
		{
			FabricaDeComparables fabrica = null;
			
			switch (opcion) {
				case 1: 
					fabrica = new FabricaDeNumero();
					break;
					
				case 2:
					fabrica = new FabricaDeAlumnos();
					break;
					
				case 3:
					fabrica = new FabricaDeProfesores();
					break;
					
				default:
					
					break;
			}
			
			return fabrica.crearAleatorio();
		}
		
		
		public static Comparable crearPorTeclado(int opcion)
		{
			FabricaDeComparables fabrica = null;
			
			switch (opcion) {
				case 1: 
					fabrica = new FabricaDeNumero();
					break;
					
				case 2: 
					fabrica = new FabricaDeAlumnos();
					break;
					
				case 3:
					fabrica = new FabricaDeProfesores();
					break;
					
				default:
					break;
					
			}
			
			return fabrica.crearPorTeclado();
		}
		
		
		
		// Metodos de instancia // sin parametros
		public abstract Comparable crearAleatorio();
		
		public abstract Comparable crearPorTeclado();
		
		
		
		
		
	}	
}





