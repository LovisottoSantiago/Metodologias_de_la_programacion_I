public class ColeccionMultiple : Coleccionable
{
    private Pila pila;
    private Cola cola;

    public ColeccionMultiple(Pila pila, Cola cola)
    {
        this.pila = pila;
        this.cola = cola;   
    }


    // Implementamos la interfaz Coleccionable
    public int cuantos()
    {
        return this.pila.cuantos() + this.cola.cuantos();
    }

    public Comparable minimo()
    {
         if (pila.cuantos() == 0 || cola.cuantos() == 0)
        {
            throw new Exception("Una o ambas colecciones están vacias, por favor revisar.");
        }

        Comparable minPila = this.pila.minimo();
        Comparable minCola = this.cola.minimo();

        if (minPila.sosMenor(minCola))
        {
            return minPila;
        }
        else
        {
            return minCola;
        }
    }

    public Comparable maximo()
    {
        if (pila.cuantos() == 0 || cola.cuantos() == 0)
        {
            throw new Exception("Una o ambas colecciones están vacias, por favor revisar.");
        }

        Comparable maxPila = this.pila.maximo();
        Comparable maxCola = this.cola.maximo();

        if (maxPila.sosMayor(maxCola))
        {
            return maxPila;
        }
        else
        {
            return maxCola;
        }
    }

    public void agregar(Comparable comp)
    {
        // Está implícito en la guía que el ejercicio agregar no debe hacer nada.
    }

    public bool contiene(Comparable comp)
    {
        return this.pila.contiene(comp) || this.cola.contiene(comp);
    }


    // Implemento interfaz Iterable
    public Iterador crearIterador()
    {
        List<Comparable> listaMultiple = new List<Comparable>();

        Iterador iterPila = this.pila.crearIterador();
        for (iterPila.primero(); !iterPila.fin(); iterPila.siguiente())
        {
            listaMultiple.Add(iterPila.actual());
        }

        Iterador iterCola = this.cola.crearIterador();
        for (iterCola.primero(); !iterCola.fin(); iterCola.siguiente())
        {
            listaMultiple.Add(iterCola.actual());
        }

        return new IteradorListaGeneral(listaMultiple);
    }

}