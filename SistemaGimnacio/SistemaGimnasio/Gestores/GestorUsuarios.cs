using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Gestores
{
    public class GestorUsuarios
    {
        //Variables de clase
        private List<Usuario> usuarios;//solo aplica dentro de la clase

        //Constructor
        public GestorUsuarios()
        {
            usuarios = new List<Usuario>();
        }

        //Metodos
        public void RegistarUsuario(string nombre, int edad, string objetivo)
        {
            usuarios.Add(new Usuario(nombre, edad, objetivo));
        }

        public Usuario BuscarUsuario(string nombre)
        {
            return usuarios.FirstOrDefault(u => u.Nombre == nombre);
        }

    }
}
