using SistemaGimnasio.Gestores;
using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

Console.WriteLine("======Sistema de Gestión de Gimnasio 'Program Power'");

//crear usuario

Console.WriteLine("Ingrese el nombre del usuario:");
string nombreUsuario = Console.ReadLine()??"";

Console.WriteLine("Ingrese la edad del usuario:");
int edadUsuario = int.Parse(Console.ReadLine()??"");

Console.WriteLine("Ingresa el objetivo del usuario(e.j. Fuerza, Resistencias, bajar peso )");
string objetivoUsuario = Console.ReadLine() ?? "";

Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

//crear entrenador

Console.WriteLine("Ingrese el nombre del entrenador:");
string nombreEntrenador = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la especialidad del entrenador");
string especialidadEntrenador = Console.ReadLine() ?? "";

Entrenador entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);

//crear rutina

Console.WriteLine("Ingrese el nombre de la rutina:");
string nombreRutina = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la duracion en minutos ");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

Rutina rutina = new Rutina(nombreRutina, duracionRutina);

//Agregar ejercicios a la rutina

Console.WriteLine("¿cuantos ejercicios tiene la rutina?");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");

for (int i = 1; i <= numEjercicios; i++)
{
    //crear ejercicio
    Console.WriteLine($"Ejercicio: {i}");
    Console.WriteLine("Ingrese el nombre del ejercicio:");
    string nombreEjercicio = Console.ReadLine() ?? "";
    Console.WriteLine("Numero de repeticiones de ejercicio:");
    int repeticiones = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Numero de series de ejercicio:");
    int series = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Tiempo de descanso en minutos de ejercicio:");
    int descanso = int.Parse(Console.ReadLine() ?? "");

    Ejercicio ejercicio = new Ejercicio(nombreEjercicio, repeticiones, series, descanso);

    rutina.AgregarEjercicio(ejercicio);
}


//asignar rutina y entrenador al usuario

AsignadorRutinas asignador = new AsignadorRutinas();
asignador.AsignarRutinaAUsuario(usuario, rutina);
asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

//mostar resumen 

Console.WriteLine("==========Resumen de asginacion por 'Program Power'");
Console.WriteLine($"Usuario: {usuario.Nombre}\n,Objetivo: {usuario.Objetivo}");
Console.WriteLine($"Rutina asignada: {usuario.RutinaAsignada.Nombre}");
Console.WriteLine($"Ejercicios a realizar: ");

foreach (var e in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.WriteLine($"{e.Nombre} | Repeticiones: {e.Repeticiones} | Series: {e.Series} | Descanso: {e.Descanso} min");
}

Console.WriteLine($"Entrenador asignado: {entrenador.Nombre} con especialidad: {entrenador.Especialidad}");