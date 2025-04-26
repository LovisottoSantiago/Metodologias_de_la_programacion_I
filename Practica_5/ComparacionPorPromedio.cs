using System;

namespace Practica_5
{

	public class ComparacionPorPromedio : EstrategiaDeComparacion
	{
	    public bool sosIgual(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getPromedio() == alumnoB.getPromedio();
	    }
	
	    public bool sosMenor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getPromedio() < alumnoB.getPromedio();
	    }
	
	    public bool sosMayor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getPromedio() > alumnoB.getPromedio();
	    }
	
	}
	
}
