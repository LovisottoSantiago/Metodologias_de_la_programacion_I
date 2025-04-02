public class ComparacionPorNombre : EstrategiaDeComparacion
{
    public bool sosIgual(Comparable alumnoA, Comparable alumnoB)
    {
        return ((Alumno)alumnoA).getNombre() == ((Alumno)alumnoB).getNombre();
    }

    public bool sosMenor(Comparable alumnoA, Comparable alumnoB)
    {
        String nombreA = ((Alumno)alumnoA).getNombre();
        String nombreB = ((Alumno)alumnoB).getNombre();
        return nombreA.CompareTo(nombreB) < 0; 
        // Si nombreA es menor que nombreB, devuelve un numero negativo.
        // Si son iguales devuelve cero. Si es mayor devuelve positivo.
    }

    public bool sosMayor(Comparable alumnoA, Comparable alumnoB)
    {
        String nombreA = ((Alumno)alumnoA).getNombre();
        String nombreB = ((Alumno)alumnoB).getNombre();
        return nombreA.CompareTo(nombreB) > 0; 
    }

}