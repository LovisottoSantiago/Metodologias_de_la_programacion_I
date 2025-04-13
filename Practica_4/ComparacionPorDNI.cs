using System;

namespace Practica_4
{
			
	public class ComparacionPorDNI : EstrategiaDeComparacion
	{
	    public bool sosIgual(Comparable alumnoA, Comparable alumnoB)
	    {
	        return ((Alumno)alumnoA).getDNI().sosIgual(((Alumno)alumnoB).getDNI());
	    }
	
	    public bool sosMenor(Comparable alumnoA, Comparable alumnoB)
	    {
	        return ((Alumno)alumnoA).getDNI().sosMenor(((Alumno)alumnoB).getDNI());
	    }
	
	    public bool sosMayor(Comparable alumnoA, Comparable alumnoB)
	    {
	        return ((Alumno)alumnoA).getDNI().sosMayor(((Alumno)alumnoB).getDNI());
	    }
	
	}
	
}
