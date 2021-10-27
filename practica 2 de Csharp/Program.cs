using System;
using System.Collections.Generic;

namespace practica_2_de_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor martinComparetto =new Profesor("martin", "Comparetto", 2332156, 10);
//            martinComparetto.fechaNacimiento = new DateTime(1962, 3, 15);
            Alumno juan = new Alumno("ariel", "Perez", 32123132, true ,23, 11, 1995);
            Alumno jorge = new Alumno("ariel", "Perez", 8798999, true ,23, 11, 1996);
            Alumno ariel = new Alumno("ariel", "Perez", 8789, true ,23, 11, 1993);
            Alumno nahuel = new Alumno("ariel", "Perez", 321466, true ,23, 11, 1998);
            Alumno jose = new Alumno("ariel", "Perez", 779879, true ,23, 11, 1990);
            Curso desarroloAppWeb = new Curso("desarrollo de aplicaciones web", 23, martinComparetto);

            desarroloAppWeb.cargarAlumno(juan);
            desarroloAppWeb.cargarAlumno(jorge);
            desarroloAppWeb.cargarAlumno(ariel);
            desarroloAppWeb.cargarAlumno(nahuel);
            desarroloAppWeb.cargarAlumno(jose);

            desarroloAppWeb.mostrarDatos();

        }
    }
}
