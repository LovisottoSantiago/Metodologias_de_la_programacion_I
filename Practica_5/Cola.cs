using System;
using System.Collections.Generic;

namespace Practica_5
	
{

	public class Cola : Coleccionable, Ordenable
	{
	    private List<Comparable> elementosComparables;
	    private OrdenEnAula1 ordenInicio, ordenAulaLlena;
	    private OrdenEnAula2 ordenLlegaAlumno;
	
	    public Cola()
	    {
	        this.elementosComparables = new List<Comparable>();
	    }
	
	    public void encolar(Comparable comp)
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
	
	    public Comparable desencolar()
	    {
	        if (elementosComparables.Count == 0)
	        {
	            throw new Exception("La cola se encuentra vacía");
	        }
	        
	        Comparable primerElemento = this.elementosComparables[0];
	        this.elementosComparables.RemoveAt(0);
	
	        return primerElemento;
	    }
	
	
	    // Implementamos la interfaz Coleccionable
	    public int cuantos()
	    {
	        return this.elementosComparables.Count;
	    }
	
	    public Comparable minimo()
	    {
	        if (elementosComparables.Count == 0)
	        {
	            throw new Exception("La lista se encuentra vacia");
	        }
	
	        Comparable minimo = this.elementosComparables[0];
	
	        for(int i = 1; i < this.cuantos(); i++)
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
	
	        for(int i = 1; i < this.cuantos(); i++)
	        {
	            if (this.elementosComparables[i].sosMayor(maximo))
	            {
	                maximo = this.elementosComparables[i];
	            }
	        }
	
	        return maximo;
	    }
	
	    public void agregar(Comparable comp)
	    {
	        encolar(comp);
	    }
	
	    public bool contiene(Comparable comp)
	    {
	        for(int i = 0; i < this.cuantos(); i++)
	        {
	            if (this.elementosComparables[i].sosIgual(comp))
	            {
	                return true;
	            }
	        }
	        return false;
	    }
	
	
	    // Implemento interfaz Iterable
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
