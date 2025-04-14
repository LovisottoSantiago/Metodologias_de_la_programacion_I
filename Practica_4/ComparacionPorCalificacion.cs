using System;

namespace Practica_4
{

	public class ComparacionPorCalificacion : EstrategiaDeComparacion
	{
	    public bool sosIgual(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getCalificacion() == alumnoB.getCalificacion();
	    }
	
	    public bool sosMenor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getCalificacion() < alumnoB.getCalificacion();
	    }
	
	    public bool sosMayor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getCalificacion() > alumnoB.getCalificacion();
	    }
	
	}
	
}