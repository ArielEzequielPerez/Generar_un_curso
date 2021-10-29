using System;
class Alumno : Persona
{
    bool trabaja {get; set;} 
   
    public Alumno(string nombre, string apellido, int dni, DateTime fechaNacimiento, bool trabaja):base(nombre, apellido, dni, fechaNacimiento)
    {
        this.trabaja = trabaja;
    }

    public void mostrarDatosAlumno(){
        Console.Write(this.mostrarPersona());
        Console.WriteLine("Trabaja: " + trabaja);
    }


}