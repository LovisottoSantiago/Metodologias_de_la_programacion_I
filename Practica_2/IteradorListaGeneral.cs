using System;
using System.Collections.Generic;

namespace Practica_2
{

	public class IteradorListaGeneral : Iterador
	{
	
	    private List<Comparable> elementosComparables;
	    private int indice;
	
	    public IteradorListaGeneral(List<Comparable> elementosComparables)
	    {
	        this.elementosComparables = elementosComparables;
	        this.indice = 0;
	    }
	
	    // Implemento interfaz Iterador
	    public void primero()
	    {
	        indice = 0;
	    }
	
	    public void siguiente()
	    {
	        this.indice++;
	    }
	
	    public bool fin()
	    {
	        return indice >= elementosComparables.Count;
	    }
	
	    public Comparable actual()
	    {
	        return elementosComparables[indice];
	    }
	
	}
	
}
