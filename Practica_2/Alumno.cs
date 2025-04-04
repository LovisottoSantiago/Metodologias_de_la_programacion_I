public class Alumno : Persona
{
    private Numero legajo;
    private Numero promedio;

    private EstrategiaDeComparacion estrategiaDeComparacion;

    public Alumno(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni)
    {
        this.legajo = legajo;
        this.promedio = promedio;
        this.estrategiaDeComparacion = new ComparacionPorLegajo();
    }

    public Numero getLegajo()
    {
        return this.legajo;
    }

    public Numero getPromedio()
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
}
