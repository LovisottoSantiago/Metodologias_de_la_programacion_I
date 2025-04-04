using System;

namespace Practica_1
{

	public abstract class Persona : Comparable
	{
	    protected string nombre;
	    protected Numero dni;
	
	    public Persona(string nombre, Numero dni)
	    {
	        this.nombre = nombre;
	        this.dni = dni;
	    }
	
	    public string getNombre()
	    {
	        return this.nombre;
	    }
	
	    public Numero getDNI()
	    {
	        return this.dni;
	    }
	
	    // Implementación de Interfaz Comparable
	    // En Persona se asume que comp es de tipo Numero.
	    public virtual bool sosIgual(Comparable comp)
	    {
	        return this.dni.sosIgual((Numero)comp);
	    }
	
	    public virtual bool sosMenor(Comparable comp)
	    {
	        return this.dni.sosMenor((Numero)comp);
	    }
	
	    public virtual bool sosMayor(Comparable comp)
	    {
	        return this.dni.sosMayor((Numero)comp);
	    }
	
	    public override string ToString()
	    {
	        return this.nombre + " - DNI: " + this.dni.ToString();
	    }
	}
	
}
