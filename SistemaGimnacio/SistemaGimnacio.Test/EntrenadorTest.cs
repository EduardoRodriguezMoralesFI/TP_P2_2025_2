using SistemaGimnasio.Modelos;
namespace SistemaGimnacio.Test
{
    public class EntrenadorTest
    {
        [Fact]

        public void AsignarUsuario_DebeAsignarUsuarioALista()
        {
            //Arrange
            var usuario = new Usuario("Juan", 27, "Resistencia");
            var entrenador = new Entrenador("Carlos","Fuerza" );

            //Act
            entrenador.AsignarUsuario(usuario);

            //Assert

            Assert.Contains(usuario, entrenador.ObtenerUsuarios());
        }

    }
}
