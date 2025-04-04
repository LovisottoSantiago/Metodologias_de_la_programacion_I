public class IteradorDePila : Iterador
{

    private Pila pila;
    private int indice;

    public IteradorDePila(Pila pila)
    {
        this.pila = pila;
        this.indice = 0;
    }

    // Implemento interfaz Iterador
    public void primero()
    {
        indice = 0;
    }

    public void siguiente()
    {
        this.indice++;
    }

    public bool fin()
    {
        return this.indice >= this.pila.cuantos();
    }

    public Comparable actual()
    {
        return this.pila.getElemento(this.indice);
    }

}