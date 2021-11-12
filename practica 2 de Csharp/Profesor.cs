using System;

class Profesor : Persona{
  
    int aniosExperiencia;

    public Profesor(string nombre, string apellido, int dni, DateTime fechaNacimiento, int aniosExperiencia) : base(nombre, apellido, dni, fechaNacimiento){
        this.aniosExperiencia = aniosExperiencia;
    }


    public void mostrarProfesor(){
        Console.WriteLine(this.mostrarPersona());
        Console.WriteLine("Años de experiencia: " + aniosExperiencia);
    }
}