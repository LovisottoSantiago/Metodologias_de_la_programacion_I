public class IteradorListaGeneral : Iterador
{

    private List<Comparable> elementosComparables;
    private int indice;

    public IteradorListaGeneral(List<Comparable> elementosComparables)
    {
        this.elementosComparables = elementosComparables;
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
        return indice >= elementosComparables.Count;
    }

    public Comparable actual()
    {
        return elementosComparables[indice];
    }

}