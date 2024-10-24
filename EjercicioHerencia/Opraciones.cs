
namespace EjercicioHerencia
{
    public class Opraciones
    {

        public virtual double CalcularAreaRectangulo(double baseRect, double altura)
        {
            return baseRect * altura;
        }

        // Método para calcular el volumen de un cilindro
        public virtual double CalcularVolumenCilindro(double radio, double altura)
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }

        // Método para calcular la longitud de una circunferencia
        public virtual double CalcularLongitudCircunferencia(double radio)
        {
            return 2 * Math.PI * radio;
        }
    }


}

