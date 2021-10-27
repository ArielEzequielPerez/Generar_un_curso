using System;
using System.Collections.Generic;
using System.Linq;

class Curso{
    string nombre;
    int cantidadDeAlumnos;
    Profesor profesorACargo;
    List<Alumno> alumnos=new List<Alumno>();

    public Curso(string nombre, int cantidadDeAlumnos, Profesor profesor){
        this.nombre=nombre;
        this.cantidadDeAlumnos=cantidadDeAlumnos;
        this.profesorACargo=profesor;
    }


    public void cargarAlumno(Alumno alumno)
    {
        if(this.alumnos.Count() <= this.cantidadDeAlumnos)
        {
            this.alumnos.Add(alumno);
        }else
        {
            Console.WriteLine("El curso esta lleno");
        }
    
    }

    public void mostrarDatos(){
        Console.WriteLine("Nombre: "+this.nombre);
        Console.WriteLine("Cantidad de alumnos: "+this.cantidadDeAlumnos);
        Console.WriteLine("Profesor: "+this.profesorACargo.getNombreApellido());
        Console.WriteLine("Alumnos: ");
        foreach(Alumno alumno in this.alumnos)
        {
            alumno.mostrarDatosAlumno();
        }
    }
}