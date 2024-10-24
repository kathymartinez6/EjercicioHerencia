static void Main(string[] args)
{
    // Instancia de la clase Calculos
    Calculos calculos = new Calculos();

    // Realizando los cálculos
    Console.WriteLine("Cálculo de área del círculo:");
    calculos.CalcularAreaCirculo(5); // Ejemplo de radio = 5

    Console.WriteLine("\nCálculo de volumen del cubo:");
    calculos.CalcularVolumenCubo(3); // Ejemplo de lado = 3

    Console.WriteLine("\nCálculo de longitud de la circunferencia:");
    calculos.CalcularLongitudCircunferencia(7); // Ejemplo de radio = 7
}

