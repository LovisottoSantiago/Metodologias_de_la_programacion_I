using System;

namespace Practica_4
{
			
	public class ComparacionPorDNI : EstrategiaDeComparacion
	{
	    public bool sosIgual(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getDNI().sosIgual(alumnoB.getDNI());
	    }
	
	    public bool sosMenor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getDNI().sosMenor(alumnoB.getDNI());
	    }
	
	    public bool sosMayor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getDNI().sosMayor(alumnoB.getDNI());
	    }
	
	}
	
}
