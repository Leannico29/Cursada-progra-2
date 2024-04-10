namespace Clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero;
            string datoIngresado;
            bool estado;
            double numeroCuadrado;
            double numeroCubo;
            string mensaje = "Ingrese un numero: ";
            string mensajeError = "Error ingrese un numero";

            Console.Write(mensaje);
            datoIngresado = Console.ReadLine();
            estado = float.TryParse(datoIngresado, out numero);

            while (!estado)
            {
             Console.WriteLine(mensajeError);
             Console.Write(mensaje);
             datoIngresado = Console.ReadLine();
             estado = float.TryParse(datoIngresado, out numero);

            }

            if (estado && numero > 0)
            {
                numeroCuadrado = Math.Pow(numero, 2);
                numeroCubo = Math.Pow(numero, 3);
                Console.WriteLine(numeroCuadrado);
                Console.WriteLine(numeroCubo);
            }
            
          
        }
    }
}
