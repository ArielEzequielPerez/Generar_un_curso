using System;


namespace practica_2_de_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

             
            Profesor unProfesor =new Profesor("martin", "Comparetto", 2332156, new DateTime(1986,11, 6), 10);
            Curso desarroloAppWeb = new Curso("desarrollo de aplicaciones web", 23, unProfesor);

            Alumno juan = new Alumno("juan", "Martinez", 32123132 ,new DateTime(1995, 11, 19), true);
            Alumno jorge = new Alumno("jorge", "Perez", 8798999,new DateTime(2004, 6, 14), true);
            Alumno ariel = new Alumno("ariel", "Perez", 8789, new DateTime(1993, 11, 23), true);

            desarroloAppWeb.cargarAlumno(juan);
            desarroloAppWeb.cargarAlumno(jorge);
            desarroloAppWeb.cargarAlumno(ariel);

            
            desarroloAppWeb.mostrarDatos();
            
        }
    }
}
