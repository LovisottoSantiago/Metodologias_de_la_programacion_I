public class Conjunto : Coleccionable
{
    private List<Comparable> elementos;

    public Conjunto()
    {
        this.elementos = new List<Comparable> ();
    }


    public void agregar(Comparable elemento)
    {
        if (!pertenece(elemento))
        {
            elementos.Add(elemento);
        }
    }

    public bool pertenece(Comparable elemento)
    {
        for (int i = 0; i < this.cuantos(); i++)
        {
            if (this.elementos[i].sosIgual(elemento))
            {
                return true;
            }
        }
        return false;
    }


    // Implemento Coleccionable
    public int cuantos()
    {
        return elementos.Count;
    }

    public Comparable minimo()
    {
        if (elementos.Count == 0)
        {
            throw new Exception("El conjunto está vacio");
        }
        
        Comparable minimo = this.elementos[0];
        
        for (int i = 1; i < this.cuantos(); i++)
        {
            if (this.elementos[i].sosMenor(minimo))
            {
                minimo = this.elementos[i];
            }
        }
        return minimo;
    }

    public Comparable maximo()
    {
        if (elementos.Count == 0)
        {
            throw new Exception("El conjunto está vacio");
        }
        
        Comparable maximo = this.elementos[0];

        for (int i = 1; i < this.cuantos(); i++)
        {
            if (this.elementos[i].sosMayor(maximo))
            {
                maximo = this.elementos[i];
            }
        }
        return maximo;
    }


    public bool contiene(Comparable comp)
    {
        return pertenece(comp);
    }

}