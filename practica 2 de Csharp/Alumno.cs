using System;
class Alumno
{
    string nombre;
    string apellido;
    int dni;
    bool trabaja;

    DateTime fechaNacimiento;
    public void fechaDeNAcimiento(int dia, int mes, int anio){
        DateTime fechaDeNAcimiento = new DateTime(dia, mes, anio);; 
    }
    public Alumno(string nombre, string apellido, int dni, bool trabaja, int dia, int mes, int anio){
        this.nombre = nombre;
        this.apellido = apellido;
        this.dni = dni;
        this.trabaja = trabaja;
        this.fechaNacimiento = new DateTime(dia, mes, anio);
    }

    public void mostrarDatosAlumno(){
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Apellido: " + apellido);
        Console.WriteLine("DNI: " + dni);
        Console.WriteLine("Trabaja: " + trabaja);
        Console.WriteLine("Fecha de nacimiento: " + fechaNacimiento);
    }


}