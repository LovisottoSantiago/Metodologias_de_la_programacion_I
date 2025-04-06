using System;

namespace Practica_3
	
{
	public class Alumno : Persona, Observador
	{
	    private Numero legajo;
	    private double promedio;
	
	    private EstrategiaDeComparacion estrategiaDeComparacion;
	
	    public Alumno(string nombre, Numero dni, Numero legajo, double promedio) : base(nombre, dni)
	    {
	        this.legajo = legajo;
	        this.promedio = promedio;
	        this.estrategiaDeComparacion = new ComparacionPorLegajo();
	    }
	
	    public Numero getLegajo()
	    {
	        return this.legajo;
	    }
	
	    public double getPromedio()
	    {
	        return this.promedio;
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
	    
	    
	    // Para patron Observer	    
	    public void prestarAtencion()
	    {
	    	Console.WriteLine("Alumno:" + this.nombre + ", prestando atencion.");
	    }
	    
	    
	    public void distraerse()
	    {
	    	Random rdn = new Random();
	    	string[] frases = new String[] {"Mirando el celular.", "Dibujando en el margen de la carpeta.", "Tirando aviones de papel."};
	    	Console.WriteLine("Alumno: " + this.nombre + ", "  + frases[rdn.Next(0, 2)]);
	    }
	    
	    
	    // Implemento Observador
	    public void actualizar(Observado o)
	    {
	    	if(((Profesor)o).isHablando()) // Si esta hablando
	    	{
	    		this.prestarAtencion();
	    	}
	    	else
	    	{
	    		this.distraerse();
	    	}
	    }
	    
	}

}
