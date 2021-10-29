using System;
using System.Collections.Generic;
using System.Linq;

class Curso{
    public string nombreDelCurso {get; set;}
    public int cantidadDeAlumnos {get; set;}
    Profesor profesorACargo {get; set;}
    List<Alumno> alumnos=new List<Alumno>();

    public Curso(string nombre, int cantidadDeAlumnos, Profesor profesor){
        this.nombreDelCurso=nombre;
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
        Console.WriteLine("nombre del curso: " + this.nombreDelCurso);
        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
        profesorACargo.mostrarDatos();
        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
        Console.WriteLine("Datos de cada alumno: ");
        foreach(Alumno alumno in this.alumnos)
        {
            alumno.mostrarDatosAlumno();
            Console.WriteLine("####################################################");
        }
    }
}