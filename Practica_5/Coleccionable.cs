using System;

namespace Practica_5
	
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
