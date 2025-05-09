﻿using System;
using System.Collections.Generic;

namespace Practica_4
{

	public class Pila : Coleccionable
	{
	    private List<Comparable> elementosComparables;
	
	    public Pila()
	    {
	        this.elementosComparables = new List<Comparable>();
	    }
	
	    public void apilar(Comparable comp)
	    {
	        this.elementosComparables.Add(comp);
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
	
	}
	
}
