using System;

namespace Practica_1
{
	class Program 
	{
	    // Random
	    private static Random random = new Random();
	
	    public static void Main(string[] args)
	    {
	        Pila pila = new Pila();
	        Cola cola = new Cola();
	        ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
	
	        //llenar(pila);
	        //llenar(cola);
	
	        llenarAlumnos(pila);
	        llenarAlumnos(cola);
	
	        //Console.WriteLine("Informe Pila: ");
	        //informar(pila);
	        //Console.WriteLine("Informe Cola: ");
	        //informar(cola);
	        //Console.WriteLine("Informe Colección múltiple: ");
	
	        informar(multiple);
	        
	        Console.ReadKey();
	    }
	
	    // Funciones
	    public static void llenar(Coleccionable coleccionable)
	    {
	        for (int i = 0; i < 20; i++){
	            Comparable comparable = new Numero(random.Next(1, 51)); // Aleatorio del 1 al 50
	            coleccionable.agregar(comparable);
	        }
	    }
	
	    public static void informar(Coleccionable coleccionable)
	    {
	        Console.WriteLine("Cantidad: " + coleccionable.cuantos().ToString());
	        Console.WriteLine("Mínimo: " + coleccionable.minimo().ToString());
	        Console.WriteLine("Máximo: " + coleccionable.maximo().ToString());
	        Console.Write("Ingresar número: ");
	        
	        try {
	            
	            int valorBuscado = int.Parse(Console.ReadLine());
	            Numero comparableBuscado = new Numero(valorBuscado);
	
	            if (coleccionable.contiene(comparableBuscado))
	            {
	                Console.WriteLine("El elemento está en la colección");
	            }
	            else 
	            {
	                Console.WriteLine("El elemento leído no está en la colección");
	            }
	        }
	        catch (FormatException)
	        {
	            Console.WriteLine("El valor ingresado no es un número válido.");
	        }
	    }
	
	
	    public static void llenarAlumnos(Coleccionable coleccionable)
	    {
	        for(int i = 0; i < 20; i++)
	        {
	            string nombre = generarNombre(); // Funcion extra para generar nombres aleatorios.
	            Numero dni = new Numero(random.Next(10000000, 99999999));
	            Numero legajo = new Numero(random.Next(10000, 99999));
	            Numero promedio = new Numero(random.Next(1, 11));
	
	            Comparable alumno = new Alumno(nombre, dni, legajo, promedio);
	            coleccionable.agregar(alumno);
	        }
	    }
	
	    public static String generarNombre() // Esto lo hice para generar nombres reales en vez de Alumno1, Alumno2, etc.
	    {
	        string[] nombres = { "Santiago", "Maria", "Pedro", "Ana", "Luis", "Carla", "Jorge", "Laura", "Carlos", "Sofia" };
	        string[] apellidos = { "Lovisotto", "Perez", "Lopez", "Martinez", "Fernandez", "Rodriguez", "Garcia", "Sanchez", "Diaz", "Morales" };
	
	                return nombres[random.Next(0 , nombres.Length)] + " " + apellidos[random.Next(0, apellidos.Length)];
	    }
	
	
	
	
	    /* Sector de preguntas para reflexionar.
	
	    Ejercicio 10
	        Para reflexionar. Además de la creación de la nueva clase ColeccionMultiple y la adaptación del
	        módulo main, responda ¿qué tuvo que modificar de lo realizado en los primeros seis ejercicios?
	
	         Algo que se tuvo que modificar fue el método predeterminado ToString(). Si no se sobreescribe, 
	        este método devuelve el nombre de la clase y la referencia en memoria y lo que buscabamos en 
	        este caso era mostrar el valor en concreto.
	
	    Ejercicio 14
	        ¿Fue necesario decir explícitamente que Alumno tiene que implementar
	        la interface Comparable? ¿Cuál fue el criterio por el cual se comparó a los alumnos? ¿Por qué?
	
	         Al principio intenté usarlo sin sobreescribir la clase Alumno pero no funcionó, me tiraba una excepción 
	         "Unhandled exception. System.InvalidCastException: Unable to cast object of type 'Numero' to type 'Alumno'."
	        Noté que no tenía problemas al comparar si eran iguales (DNI) pero sí al intentar comparar si era mayor o menor.
	        Por lo que tuve que hacer un override en sosMayor, sosMenor, creando una instancia de Alumno como
	        comparable y usando eso para la lógica.
	        Sin embargo, en el ejercicio 15 tuve que sobreescribir sosIgual para decirle que se compare por legajo en vez
	        de DNI.
	
	    Ejercicio 16
	        Para reflexionar. Responda ¿Podría haber hecho esto mismo sin interfaces? ¿A qué costo?        
	
	         En este caso se podría haber reemplazado Numero con simplemente un entero y usar comparaciones con < o >. Sin
	        embargo, considero que quedó armada una estructura súper modificable a futuro, lo cual no habría sido posible
	        sin el uso de interfaces. Esto nos va a permitir seguir agregando cosas a la interfaz Número en el futuro 
	        por ejemplo, validaciones, formateos, etc. El código queda mucho más legible y tener todo separado es 
	        bastante más prolijo. Lo que más me gustó de usar interfaces es su reutilización.
	    */
	
	}
}
