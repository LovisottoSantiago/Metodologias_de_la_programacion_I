using System;

namespace Practica_1
{

	public class Alumno : Persona
	{
	    private Numero legajo;
	    private Numero promedio;
	
	    public Alumno(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni)
	    {
	        this.legajo = legajo;
	        this.promedio = promedio;
	    }
	
	    public Numero getLegajo()
	    {
	        return this.legajo;
	    }
	
	    public Numero getPromedio()
	    {
	        return this.promedio;
	    }
	
	    public override bool sosIgual(Comparable comp)
	    {
	        return this.legajo.sosIgual((Numero)comp);  
	    }
	
	    public override bool sosMenor(Comparable comp)
	    {
	        Alumno otroAlumno = (Alumno) comp;
	        return this.legajo.sosMenor(otroAlumno.getLegajo());        
	    }
	
	    public override bool sosMayor(Comparable comp)
	    {
	        Alumno otroAlumno = (Alumno) comp;
	        return this.legajo.sosMayor(otroAlumno.getLegajo());        
	    }
	
	    public override string ToString()
	    {
	        return base.ToString() + " - Legajo: " + legajo.ToString() + " - Promedio: " + promedio.ToString();
	    }
	}

}
