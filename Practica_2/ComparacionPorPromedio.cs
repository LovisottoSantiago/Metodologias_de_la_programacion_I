public class ComparacionPorPromedio : EstrategiaDeComparacion
{
    public bool sosIgual(Comparable alumnoA, Comparable alumnoB)
    {
        return ((Alumno)alumnoA).getPromedio() == ((Alumno)alumnoB).getPromedio();
    }

    public bool sosMenor(Comparable alumnoA, Comparable alumnoB)
    {
        return ((Alumno)alumnoA).getPromedio().sosMenor(((Alumno)alumnoB).getPromedio());
    }

    public bool sosMayor(Comparable alumnoA, Comparable alumnoB)
    {
        return ((Alumno)alumnoA).getPromedio().sosMayor(((Alumno)alumnoB).getPromedio());
    }

}