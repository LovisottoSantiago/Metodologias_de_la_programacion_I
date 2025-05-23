﻿using System;

namespace Practica_5
{

	public class FabricaDeAlumnos : FabricaDeComparables
	{
				
		
		// Implemento metodos abstractos
		public override Comparable crearAleatorio()
		{
			return new Alumno(gen.nombreAleatorio(), new Numero(gen.numeroAleatorio(10000000)), new Numero(gen.numeroAleatorio(10000)), (double)(gen.doubleAleatorio(10)), (int)(gen.numeroAleatorio(10)));
		}
		
		
		public override Comparable crearPorTeclado()
		{
			return new Alumno(lector.stringPorTeclado(), new Numero(lector.numeroPorTeclado()), new Numero(lector.numeroPorTeclado()), (double)(lector.doublePorTeclado()), (int)(lector.numeroPorTeclado()));
		}
		
	}
}
