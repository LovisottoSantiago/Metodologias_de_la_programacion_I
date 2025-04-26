using System;
namespace Practica_5
	
{

	public class AlumnoProxy : IAlumno
	{
		
		private Alumno alumnoReal;
		private string nombreProxy;
		
		public AlumnoProxy(string nombre)
		{
			this.nombreProxy = nombre;
		}
		
		// Implemento interface IAlumno
		
		// Lo que puede resolver
		public string getNombre()
		{
			return this.nombreProxy;
		}
		
		
		// Lo que no puede resolver
		public Numero getLegajo()
		{
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.getLegajo();
		}
	    
	    public Numero getDNI()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.getDNI();	    	
	    }
	    
	    public double getPromedio()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.getPromedio();
	    }
	    
	    public int getCalificacion()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.getCalificacion();	    	
	    }
	    
	    public void setCalificacion(int calificacion)
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.setCalificacion(calificacion);	    	
	    }
	    
	    public void setEstrategia (EstrategiaDeComparacion estrategia);  
	    {
	    	if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

	    	return alumnoReal.setEstrategia(estrategia);
	    }
	    
	    public EstrategiaDeComparacion getEstrategia()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.getEstrategia();	    	
	    }
	    	    
	    public void prestarAtencion()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.prestarAtencion();	    	
	    }
	    	    
	    public void distraerse()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.distraerse();	    	
	    }
	    	    
	    public void actualizar(Observado o)
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.actualizar();	    	
	    }
	    	  
	    public int responderPregunta(int pregunta)
	    {
	    	if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

	    	return alumnoReal.responderPregunta(pregunta);
	    }
	    	    
	    public string mostrarCalificacion()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.mostrarCalificacion();	    	
	    }
	    
	    public bool sosIgual(Comparable comp)
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.sosIgual(comp);	   	    	
	    }
	    
	    public bool sosMenor(Comparable comp)
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.sosMenor(comp);	   	    	
	    }
	    	    
	    public bool sosMayor(Comparable comp)
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
	    	}

			return alumnoReal.sosMayor(comp);	   	    	
	    }	    	    	    
		
	}
}
