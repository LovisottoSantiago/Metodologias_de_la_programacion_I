using System;

namespace Practica_4
{

	public class ComparacionPorPromedio : EstrategiaDeComparacion
	{
	    public bool sosIgual(Comparable alumnoA, Comparable alumnoB)
	    {
	        return ((Alumno)alumnoA).getPromedio() == ((Alumno)alumnoB).getPromedio();
	    }
	
	    public bool sosMenor(Comparable alumnoA, Comparable alumnoB)
	    {
	        return ((Alumno)alumnoA).getPromedio() < ((Alumno)alumnoB).getPromedio();
	    }
	
	    public bool sosMayor(Comparable alumnoA, Comparable alumnoB)
	    {
	        return ((Alumno)alumnoA).getPromedio() > ((Alumno)alumnoB).getPromedio();
	    }
	
	}
	
}
