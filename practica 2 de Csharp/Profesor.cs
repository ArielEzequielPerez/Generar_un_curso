using System;

class Profesor{
    string nombre ;
    string apellido;
    int dni;
    int aniosExperiencia;
//    DateTime fechaDeNacimiento;
  

    public Profesor(string nombre, string apellido, int dni,int aniosExperiencia){
        this.nombre = nombre;
        this.apellido = apellido;
        this.dni = dni;
        this.aniosExperiencia = aniosExperiencia;
    }

    public void mostrarDatos(){
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Apellido: " + apellido);
        Console.WriteLine("DNI: " + dni);
        Console.WriteLine("Años de experiencia: " + aniosExperiencia);
    }

    public string getNombreApellido(){
        return nombre + " " + apellido;
    }





}