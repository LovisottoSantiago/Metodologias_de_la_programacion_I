using System;
using System.Collections.Generic;

namespace Practica_4
{

	public class Conjunto : Coleccionable
	{
	    private List<Comparable> elementosComparables;
	
	    public Conjunto()
	    {
	        this.elementosComparables = new List<Comparable> ();
	    }
	
	
	    public void agregar(Comparable elemento)
	    {
	        if (!pertenece(elemento))
	        {
	            elementosComparables.Add(elemento);
	        }
	    }
	
	    public bool pertenece(Comparable elemento)
	    {
	        for (int i = 0; i < this.cuantos(); i++)
	        {
	            if (this.elementosComparables[i].sosIgual(elemento))
	            {
	                return true;
	            }
	        }
	        return false;
	    }
	
	
	    // Implemento Coleccionable
	    public int cuantos()
	    {
	        return elementosComparables.Count;
	    }
	
	    public Comparable minimo()
	    {
	        if (elementosComparables.Count == 0)
	        {
	            throw new Exception("El conjunto está vacio");
	        }
	        
	        Comparable minimo = this.elementosComparables[0];
	        
	        for (int i = 1; i < this.cuantos(); i++)
	        {
	            if (this.elementosComparables[i].sosMenor(minimo))
	            {
	                minimo = this.elementosComparables[i];
	            }
	        }
	        return minimo;
	    }
	
	    public Comparable maximo()
	    {
	        if (elementosComparables.Count == 0)
	        {
	            throw new Exception("El conjunto está vacio");
	        }
	        
	        Comparable maximo = this.elementosComparables[0];
	
	        for (int i = 1; i < this.cuantos(); i++)
	        {
	            if (this.elementosComparables[i].sosMayor(maximo))
	            {
	                maximo = this.elementosComparables[i];
	            }
	        }
	        return maximo;
	    }
	
	
	    public bool contiene(Comparable comp)
	    {
	        return pertenece(comp);
	    }
	
	
	
	    // Implemento interfaz Iterable
	    public Iterador crearIterador()
	    {
	        return new IteradorListaGeneral(this.elementosComparables);
	    }
	
	
	}
	
}
