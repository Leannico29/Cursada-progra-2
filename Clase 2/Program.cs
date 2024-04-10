using System.Text;

namespace Clase_2
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                bool estado = true;

                while (estado)
                { 
                Console.Write("Ingrese un número entero: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    string tablaMultiplicar = ObtenerTablaMultiplicar(numero);
                    Console.WriteLine(tablaMultiplicar);
                    estado = false;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Debe ingresar un número entero.");
                } 
                }
            }

            static string ObtenerTablaMultiplicar(int numero)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Tabla de multiplicar del número {numero}:");
                for (int i = 1; i <= 10; i++)
                {
                    sb.AppendLine($"{numero} x {i} = {numero * i}");
                }
                return sb.ToString();
            }
        
    }
}
