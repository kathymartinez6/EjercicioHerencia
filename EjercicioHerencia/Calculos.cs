

namespace EjercicioHerencia
{
    class Calculos : Opraciones
    {
        private double resultado;
        public void CalcularArea(double baseRect, double altura)
        {
            resultado = CalcularAreaRectangulo(baseRect, altura);
            Imprimir("Área del rectángulo");
        }
        public void CalcularVolumen(double radio, double altura)
        {
            resultado = CalcularVolumenCilindro(radio, altura);
            Imprimir("Volumen del cilindro");
        }
        public void CalcularLongitud(double radio)
        {
            resultado = CalcularLongitudCircunferencia(radio);
            Imprimir("Longitud de la circunferencia");
        }
        public void Imprimir(string operacion)
        {
            Console.WriteLine($"{operacion}: {resultado}");
        }
    }

}