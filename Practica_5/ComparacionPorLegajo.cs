﻿using System;

namespace Practica_5
{

	public class ComparacionPorLegajo : EstrategiaDeComparacion
	{
	    public bool sosIgual(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getLegajo().sosIgual(alumnoB.getLegajo());
	    }
	
	    public bool sosMenor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getLegajo().sosMayor(alumnoB.getLegajo());
	    }
	
	    public bool sosMayor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getLegajo().sosMayor(alumnoB.getLegajo());
	    }
	
	}
	
}
