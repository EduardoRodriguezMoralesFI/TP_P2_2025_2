namespace SistemaGimnasio.Modelos
{
    public class Entrenador
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        //Variable de clase
        private List<Usuario> usuariosAsignador;

        //Constructor
        public Entrenador(string nombre, string especialidad)
        {
            Nombre = nombre;
            Especialidad = especialidad;

        }

        //Metodos
        public void AsignarUsuario(Usuario usuario)
        {
            usuariosAsignador.Add(usuario);
        }
        public List<Usuario> ObtenerUsuarios()
        {
            return usuariosAsignador;
        }

    }
}
