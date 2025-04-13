using System;

namespace Practica_4
{
	
	public interface EstrategiaDeComparacion
	{
	    bool sosIgual(Comparable A, Comparable B);
	    bool sosMenor(Comparable A, Comparable B);
	    bool sosMayor(Comparable A, Comparable B);
	}
	
}
