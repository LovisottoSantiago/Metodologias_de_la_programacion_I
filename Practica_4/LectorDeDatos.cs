using System;

namespace Practica_4
{

	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
		
		public int numeroPorTeclado()
		{
			Console.Write("Ingrese un numero entero: ");
			return int.Parse(Console.ReadLine());
		}
		
		public double doublePorTeclado()
		{
			Console.Write("Ingrese un numero float: ");
			return double.Parse(Console.ReadLine());
		}
		
		public string stringPorTeclado()
		{
			Console.Write("Ingrese un string: ");
			return Console.ReadLine();
		}
	}
}
