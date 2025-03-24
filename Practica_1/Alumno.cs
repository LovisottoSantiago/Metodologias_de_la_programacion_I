public class Alumno : Persona
{
    private Numero legajo;
    private Numero promedio;

    public Alumno(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni)
    {
        this.legajo = legajo;
        this.promedio = promedio;
    }

    public Numero getLegajo()
    {
        return this.legajo;
    }

    public Numero getPromedio()
    {
        return this.promedio;
    }

    public override bool sosIgual(Comparable comp)
    {
        if(comp.GetType() == typeof(Numero))
        {            
            return this.legajo.sosIgual(comp); // return base.sosIgual(comp); Ejercicio 14
        }
        else
        {
            Alumno otroAlumno = (Alumno) comp;
            return this.dni.sosIgual(otroAlumno.getLegajo()); // return this.dni.sosIgual(otroAlumno.getDNI());  
        }
    }

    public override bool sosMenor(Comparable comp)
    {
        if(comp.GetType() == typeof(Numero))
        {
            return this.legajo.sosMenor(comp);
        }
        else
        {
            Alumno otroAlumno = (Alumno) comp;
            return this.dni.sosMenor(otroAlumno.getLegajo());
        }
    }

    public override bool sosMayor(Comparable comp)
    {
        if(comp.GetType() == typeof(Numero))
        {
            return this.legajo.sosMayor(comp);
        }
        else
        {
            Alumno otroAlumno = (Alumno) comp;
            return this.dni.sosMayor(otroAlumno.getLegajo());
        }
    }

    public override string ToString()
    {
        return base.ToString() + " - Legajo: " + legajo.ToString() + " - Promedio: " + promedio.ToString();
    }
}
