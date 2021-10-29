using System;
class Persona{
    private string nombre;
    private string apellido;
    private int dni;
    private DateTime fechaNacimiento;

    public Persona(string nombre, string apellido, int dni, DateTime fechaNacimiento){
        this.nombre = nombre;
        this.apellido = apellido;
        this.dni = dni;
        this.fechaNacimiento = fechaNacimiento;
    }

    public string mostrarPersona(){
        return "Nombre: " + nombre + "\nApellido: " + apellido + "\nDNI: " + dni + "\nFecha de nacimiento: " + fechaNacimiento.ToString("dd/MM/yyyy");
    }

}