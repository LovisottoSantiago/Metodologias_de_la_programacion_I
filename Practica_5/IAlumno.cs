using System;

namespace Practica_5
{

	public interface IAlumno : Comparable
	{				
	
	    Numero getLegajo();

	    string getNombre();
	    
	    Numero getDNI();
	    
	    double getPromedio();
	    
	    int getCalificacion();
	    
	    void setCalificacion(int calificacion);
	    
	    void setEstrategia (EstrategiaDeComparacion estrategia);  	
	    
	    EstrategiaDeComparacion getEstrategia();
	    	    
	    void prestarAtencion();
	    	    
	    void distraerse();
	    	    
	    void actualizar(Observado o);
	    	  
	    int responderPregunta(int pregunta);
	    	    
	    string mostrarCalificacion();

		

	
	}
}
