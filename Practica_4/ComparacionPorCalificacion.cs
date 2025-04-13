﻿using System;

namespace Practica_4
{

	public class ComparacionPorCalificacion : EstrategiaDeComparacion
	{
	    public bool sosIgual(Comparable alumnoA, Comparable alumnoB)
	    {
	        return ((Alumno)alumnoA).getCalificacion() == (((Alumno)alumnoB).getCalificacion());
	    }
	
	    public bool sosMenor(Comparable alumnoA, Comparable alumnoB)
	    {
	        return ((Alumno)alumnoA).getCalificacion() < (((Alumno)alumnoB).getCalificacion());
	    }
	
	    public bool sosMayor(Comparable alumnoA, Comparable alumnoB)
	    {
	        return ((Alumno)alumnoA).getCalificacion() > (((Alumno)alumnoB).getCalificacion());
	    }
	
	}
	
}