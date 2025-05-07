
using SistemaGimnasio.Modelos;

namespace SistemaGimnacio.Test
{
    public class UsuarioTest
    {
        [Fact]
        public void AsignarRutina_DebeAsignarCorrectamente()
        {
            //Arrange
            var usuario = new Usuario("Carlos", 25, "Fuerza");
            var rutina = new Rutina("Rutina de Fuerza", 60);

            //Act

            usuario.AsignarRutina(rutina);

            //Assert
            Assert.Equal("Rutina de Fuerza", usuario.RutinaAsignada.Nombre);
        }
    }
}