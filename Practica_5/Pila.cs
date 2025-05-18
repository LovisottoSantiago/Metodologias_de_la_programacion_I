using System;
using System.Collections.Generic;

namespace Practica_5
{

	public class Pila : Coleccionable, Ordenable
	{
	    private List<Comparable> elementosComparables;
	    private OrdenEnAula1 ordenInicio, ordenAulaLlena;
	    private OrdenEnAula2 ordenLlegaAlumno;
	
	    public Pila()
	    {
	        this.elementosComparables = new List<Comparable>();
	    }
	
	    public void apilar(Comparable comp)
	    {
	        this.elementosComparables.Add(comp);
	        
	        if (this.elementosComparables.Count == 1 && ordenInicio != null)
	        {
	        	ordenInicio.ejecutar();
	        }
	        
	        ordenLlegaAlumno.ejecutar(comp);
	        
	        if (this.elementosComparables.Count == 40)
	        {
	        	ordenAulaLlena.ejecutar();
	        }
	    }
	
	    public Comparable desapilar()
	    {
	        if (this.elementosComparables.Count == 0)
	        {
	            throw new Exception("La pila se encuentra vacía");
	        }
	
	        Comparable comp = this.elementosComparables[this.elementosComparables.Count - 1];
	        this.elementosComparables.RemoveAt(this.elementosComparables.Count - 1);
	
	        return comp;
	    }
	
	
	    // Modifico Pila para que implemente Iterable
	    public Comparable getElemento(int indice)
	    {
	        return this.elementosComparables[indice];
	    }
	
	
	    // Implementamos la interfaz Coleccionable
	    public int cuantos()
	    {
	        return elementosComparables.Count;
	    }
	
	    public Comparable minimo()
	    {
	        if (elementosComparables.Count == 0)
	        {
	            throw new Exception("La lista se encuentra vacia");
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
	            throw new Exception("La lista se encuentra vacia");
	        }
	
	        Comparable maximo = this.elementosComparables[0];
	        
	        for (int i = 1; i < this.cuantos(); i++)
	        {
	            if (this.elementosComparables[i].sosMayor(maximo)){
	                maximo = this.elementosComparables[i];
	            }
	        }
	        return maximo;
	    }
	
	    public void agregar(Comparable comp)
	    {
	        this.apilar(comp);
	    }
	    
	    public bool contiene(Comparable comp)
	    {
	        for (int i = 0; i < this.cuantos(); i++)
	        {
	            if (this.elementosComparables[i].sosIgual(comp))
	            {
	                return true;
	            }
	        }
	        return false;
	    }
	
	
	    // Implemento Iterable
	
	    public Iterador crearIterador()
	    {
	        return new IteradorListaGeneral(this.elementosComparables);
	    }	    	  
	    
	    
	    // Implemento Ordenable
	    public void setOrdenInicio(OrdenEnAula1 o)
	    {
	    	this.ordenInicio = o;
	    }
	    
		public void setOrdenLlegaAlumno(OrdenEnAula2 o)
		{
			this.ordenLlegaAlumno = o;
		}
		
		public void setOrdenAulaLlena(OrdenEnAula1 o)
		{
			this.ordenAulaLlena = o;
		}
	
		
	}
	
}
