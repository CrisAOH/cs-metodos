using System;

namespace Tarea5_2_Areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("CÁLCULADORA DE ÁREAS");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Triángulo");

                Console.Write("Selecciona una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Por favor, selecciona una opción que se encuentre en el menú."); 
                }
            }
            while (opcion < 1 || opcion > 4);

            switch (opcion)
            {
                case 1:
                    CalcularAreaCirculo();
                    break;
                case 2:
                    CalcularAreaCuadrado();
                    break;
                case 3:
                    CalcularAreaTriangulo();
                    break;
            }
        }

        static void CalcularAreaCirculo()
        {
            double radio, area;

            Console.Write("Dame el radio del círculo: ");
            radio = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * (radio * radio);

            Console.WriteLine("{0} * ({1} ^ 2) = {2}", Math.PI, radio, area);
        }

        static void CalcularAreaCuadrado()
        {
            double lado, area;
            Console.Write("Dame el tamaño de un lado del cuadrado: ");
            lado = Convert.ToDouble(Console.ReadLine());

            area = lado * lado;

            Console.WriteLine("{0} ^ 2 = {1}", lado, area);
        }

        static void CalcularAreaTriangulo()
        {
            double baseT, altura, area;

            Console.Write("Dame el tamaño de base: ");
            baseT = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            area = (baseT * altura) / 2;

            Console.WriteLine("({0} * {1}) / 2 = {2}", baseT, altura, area); 
        }
    }
}
