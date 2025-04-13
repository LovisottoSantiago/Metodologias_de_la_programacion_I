using System;

namespace Practica_4
{

	public class ComparacionPorLegajo : EstrategiaDeComparacion
	{
	    public bool sosIgual(Comparable alumnoA, Comparable alumnoB)
	    {
	        return ((Alumno)alumnoA).getLegajo().sosIgual(((Alumno)alumnoB).getLegajo());
	    }
	
	    public bool sosMenor(Comparable alumnoA, Comparable alumnoB)
	    {
	        return ((Alumno)alumnoA).getLegajo().sosMenor(((Alumno)alumnoB).getLegajo());
	    }
	
	    public bool sosMayor(Comparable alumnoA, Comparable alumnoB)
	    {
	        return ((Alumno)alumnoA).getLegajo().sosMayor(((Alumno)alumnoB).getLegajo());
	    }
	
	}
	
}
