using System;

namespace Practica_1
{
	
	public class Numero : Comparable 
	{
	    
	    private int valor;
	
	    public Numero(int valor)
	    {
	        this.valor = valor;
	    }
	
	    public int getValor()
	    {
	        return this.valor;
	    }
	
	
	    // Implementamos interfaz Comparable
	    public bool sosIgual(Comparable unComparable)
	    {
	        return (this.valor == ((Numero)unComparable).valor);
	    }
	
	    public bool sosMenor(Comparable unComparable)
	    {        
	        return (this.valor < ((Numero)unComparable).valor);
	    }
	
	    public bool sosMayor(Comparable unComparable)
	    {
	        return (this.valor > ((Numero)unComparable).valor);
	    }
	
	    // @override
	    public override string ToString()
	    {
	        return this.valor.ToString();
	    }
	
	}
	
}
