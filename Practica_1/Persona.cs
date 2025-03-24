public abstract class Persona : Comparable
{
    private string nombre;
    private Numero dni;

    public Persona(String nombre, Numero dni)
    {
        this.nombre = nombre;
        this.dni = dni;
    }

    public string getNombre()
    {
        return this.nombre;
    }

    public Numero getDni()
    {
        return this.dni;
    }


    // Implementamos la Interfaz Comparable
    public bool sosIgual(Comparable comp)
    {
        return this.dni.sosIgual(((Persona)comp).dni); // me aseguro de que comp sea una Persona
    }

    public bool sosMenor(Comparable comp)
    {
        return this.dni.sosMenor(((Persona)comp).dni);
    }

    public bool sosMayor(Comparable comp)
    {
        return this.dni.sosMayor(((Persona)comp).dni);
    }
    

}