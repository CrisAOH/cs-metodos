using System;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            decimal r;
            decimal num1Ar, num2Ar; //ARGUMENTOS PARA ENVIAR UNA COPIA DE SU VALOR A LOS MÉTODOS

            (decimal num1, decimal num2, decimal resultado) numeros; 

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                Console.WriteLine("Selecciona una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while (opcion < 1 || opcion > 4);

            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    numeros = Restar();
                    Console.WriteLine("{0} - {1} = {2}", numeros.num1, numeros.num2, numeros.resultado);
                    break;
                case 3:
                    num1Ar = IngresarNumero("Dame el primer número: ");
                    num2Ar = IngresarNumero("Dame el segundo número: ");

                    Multiplicar(num1Ar, num2Ar);
                    break;
                case 4:
                    num1Ar = IngresarNumero("Dame el primer número: ");
                    num2Ar = IngresarNumero("Dame el segundo número: ");

                    r = Dividir(num1Ar, num2Ar);
                    Console.WriteLine("El resultado de la división es: {0}", r);
                    break;
            }
        }

        //MÉTODO SIN PARÁMETROS NI TIPO
        static void Sumar()
        {
            decimal num1, num2, resultado;

            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        }

        //MÉTODO QUE DEVUELVE UN TIPO
        static (decimal, decimal, decimal) Restar()
        {
            decimal num1, num2, resultado;

            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 - num2;

            return (num1, num2, resultado);
        }

        //MÉTODO QUE CONTIENE PARÁMETROS
        static void Multiplicar(decimal num1Param, decimal num2Param)
        {
            decimal resultado;

            resultado = num1Param * num2Param;

            Console.WriteLine("{0} * {1} = {2}", num1Param, num2Param, resultado);
        }

        //MÉTODO QUE CONTIENE PARÁMETROS Y DEVUELVE UN TIPO
        static decimal Dividir(decimal num1Param, decimal num2Param)
        {
            decimal resultado;

            if(num2Param != 0)
            {
                resultado = num1Param / num2Param;
            }
            else
            {
                Console.WriteLine("No es posible dividir entre 0.");
                resultado = 0;
            }

            return resultado;
        }

        //MÉTODO PARA SOLICITAR NÚMEROS
        static decimal IngresarNumero(string peticion)
        {
            decimal numero;

            Console.Write(peticion);
            numero = Convert.ToDecimal(Console.ReadLine());

            return numero;
        }
    }
}
