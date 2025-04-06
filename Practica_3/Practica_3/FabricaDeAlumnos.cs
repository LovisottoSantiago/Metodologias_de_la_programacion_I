﻿using System;

namespace Practica_3
{

	public class FabricaDeAlumnos : FabricaDeComparables
	{
				
		
		// Implemento metodos abstractos
		public override Comparable crearAleatorio()
		{
			return new Alumno(gen.stringAleatorio(), new Numero(gen.numeroAleatorio(10000000)), new Numero(gen.numeroAleatorio(10000)), new Numero(gen.numeroAleatorio(10)));
		}
		
		
		public override Comparable crearPorTeclado()
		{
			return new Alumno(lector.stringPorTeclado(), new Numero(lector.numeroPorTeclado()), new Numero(lector.numeroPorTeclado()), new Numero(lector.numeroPorTeclado()));
		}
		
	}
}
