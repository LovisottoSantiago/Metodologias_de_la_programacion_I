using System;

namespace Practica_4
	
{
	public class Alumno : Persona, Observador
	{
	    private Numero legajo;
	    private double promedio;
	    private Numero calificacion;
	    private Random rdn = new Random();
	
	    private EstrategiaDeComparacion estrategiaDeComparacion;
	
	    public Alumno(string nombre, Numero dni, Numero legajo, double promedio, Numero calificacion) : base(nombre, dni)
	    {
	        this.legajo = legajo;
	        this.promedio = promedio;
	        this.estrategiaDeComparacion = new ComparacionPorLegajo();
	        this.calificacion = calificacion;
	    }
	
	    public Numero getLegajo()
	    {
	        return this.legajo;
	    }
	
	    public double getPromedio()
	    {
	        return this.promedio;
	    }
	    
	    public Numero getCalificacion()
	    {
	    	return this.calificacion;
	    }
	    
	    public void setCalificacion(Numero calificacion)
	    {
	    	this.calificacion = calificacion;
	    }
	    
	    public void setEstrategia (EstrategiaDeComparacion estrategia)
	    {
	        this.estrategiaDeComparacion = estrategia;
	    }    
	    
	    public override bool sosIgual(Comparable comp)
	    {
	        return this.estrategiaDeComparacion.sosIgual(this, (Alumno)comp);  
	    }
	
	    public override bool sosMenor(Comparable comp)
	    {
	        return this.estrategiaDeComparacion.sosMenor(this, (Alumno)comp);
	    }
	
	    public override bool sosMayor(Comparable comp)
	    {
	        return this.estrategiaDeComparacion.sosMayor(this, (Alumno)comp);
	    }
	
	    public override string ToString()
	    {
	        return base.ToString() + " - Legajo: " + legajo.ToString() + " - Promedio: " + promedio.ToString();
	    }
	    
	    
	    public void prestarAtencion()
	    {
	    	Console.WriteLine("Alumno:" + this.nombre + ", prestando atencion.");
	    }
	    
	    
	    public void distraerse()
	    {	    	
	    	string[] frases = new String[] {"Mirando el celular.", "Dibujando en el margen de la carpeta.", "Tirando aviones de papel."};
	    	Console.WriteLine("Alumno: " + this.nombre + ", "  + frases[rdn.Next(0, 2)]);
	    }
	    
	    
	    public void actualizar(Observado o)
	    {
	    	if(((Profesor)o).isHablando())
	    	{
	    		this.prestarAtencion();
	    	}
	    	else
	    	{
	    		this.distraerse();
	    	}
	    }
	    
	    
	    public int responderPregunta(int pregunta)
	    {
	    	return rdn.Next(1, 3);
	    }
	    
	    
	    public string mostrarCalificacion()
	    {
	    	return this.nombre + "\t" + this.calificacion;
	    }
	    
	    
	}

}
