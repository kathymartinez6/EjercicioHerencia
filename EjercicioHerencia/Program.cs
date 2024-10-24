namespace EjercicioHerencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Calculos calculos = new();
            const string Value = "Cálculo de operaciones:";
            Console.WriteLine(value: Value);

            
            calculos.CalcularArea(5, 10); 

            calculos.CalcularVolumen(3, 7); 

            Console.WriteLine("\nCálculo de volumen del cubo:");
        }
    }
}