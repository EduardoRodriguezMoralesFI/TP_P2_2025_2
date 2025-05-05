
namespace SistemaGimnasio.Modelos
{
    public class Rutina
    {
        //Propiedades(se requiere al instanciar el objeto)
        public string Nombre {  get; set; }
        public int Duracion { get; set; }
        //variable de clase (se construye en el grupo del programa )
        private List<Ejercicio> ejercicios;

        //constructor
        public Rutina(string nombre, int duracion)
        {
            Nombre = nombre;
            Duracion = duracion;
        }

        //Metodos
        
        public void AgregarEjercicio(Ejercicio ejercicio)
        {
            ejercicios.Add(ejercicio);
        }
        

        
        public List<Ejercicio> ObtenerEjercicios()
        {
            return ejercicios;
        }
        
       
        public void BorrarEjercicio(Ejercicio ejercicio)
        {
            ejercicios.Remove(ejercicio);
        }
        


    }
}
