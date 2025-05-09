
using SistemaGimnasio.Modelos;
namespace SistemaGimnacio.Test
{
    public class RutinaTests
    {
        [Fact]

        public void AgregarEjercicio_DebeAgregarEjercicioALista()
        {
            //Arrange

            var rutina = new Rutina("Fabian Rutina", 20);
            var ejercicio1 = new Ejercicio("Sentallida hungara", 15,3,2);
            var ejercicio2 = new Ejercicio("Curl de biceps", 10, 4, 1);

            // Act

            rutina.AgregarEjercicio(ejercicio1);
            rutina.AgregarEjercicio(ejercicio2);

            // Assert

            Assert.NotEmpty(rutina.ObtenerEjercicios());

        }
    }
}
