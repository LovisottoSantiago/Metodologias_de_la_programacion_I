using System;
class Program 
{

    public static void Main(string[] args)
    {
        Pila pila = new Pila();
        Cola cola = new Cola();
        ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

        llenar(pila);
        llenar(cola);

        Console.WriteLine("Informe Pila: ");
        informar(pila);
        Console.WriteLine("Informe Cola: ");
        informar(cola);
        Console.WriteLine("Informe Colección múltiple: ");
        informar(multiple);
    }

    // Funciones
    public static void llenar(Coleccionable coleccionable)
    {
        Random random = new Random();
        for (int i = 0; i < 20; i++){
            Comparable comparable = new Numero(random.Next(1, 51)); // Aleatorio del 1 al 50
            coleccionable.agregar(comparable);
        }
    }

    public static void informar(Coleccionable coleccionable)
    {
        Console.WriteLine("Cantidad: " + coleccionable.cuantos().ToString());
        Console.WriteLine("Mínimo: " + coleccionable.minimo());
        Console.WriteLine("Máximo: " + coleccionable.maximo());
        Console.Write("Ingresar número para verificar si existe en la lista: ");
        
        try {
            Comparable comparable = new Numero(Convert.ToInt32(Console.ReadLine()));
            if (coleccionable.contiene(comparable))
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


    /* Sector de preguntas para reflexionar.

    Ejercicio 10
        Para reflexionar. Además de la creación de la nueva clase ColeccionMultiple y la adaptación del
        módulo main, responda ¿qué tuvo que modificar de lo realizado en los primeros seis ejercicios?

        Algo que se tuvo que modificar fue el método predeterminado ToString(). Si no se sobreescribe, 
        este método devuelve el nombre de la clase y la referencia en memoria y lo que buscabamos en 
        este caso era mostrar el valor en concreto.

    
    */

}