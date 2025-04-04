using System;

namespace Practica_2
	
{

	public interface Coleccionable : Iterable
	{
	
	    int cuantos();
	    Comparable minimo();
	    Comparable maximo();
	    void agregar(Comparable comp);
	    bool contiene(Comparable comp);
	    
	
	}
	
}
