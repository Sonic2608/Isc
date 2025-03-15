using alumno_y_profe;
Profesor profesor = new Profesor();
Console.WriteLine("\nDatos del Profe:");
Console.WriteLine("Ingresa el Nombre del profesor");
profesor.Nombre_profesor = Console.ReadLine();

profesor.capturar_Datos_Alumno();
profesor.capturar_Materias();
profesor.capturar_Calificaciones();

Console.WriteLine($"El nombre del profesor es {profesor.Nombre_profesor}");
Console.WriteLine($"El Nombre de el alumno es{profesor.Alumno.Nombre_Alumno}");

Console.WriteLine("Materias:");
foreach (string materia in profesor.Alumno.Materias)
{
    Console.WriteLine($"- {materia}");
}

Console.WriteLine("Calificaciones");
foreach (int calificaciones in profesor.Alumno.Calificaciones)
{
    Console.WriteLine($"-{calificaciones}");
}
