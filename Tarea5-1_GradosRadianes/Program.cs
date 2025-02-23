using System;

namespace Tarea5_1_GradosRadianes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradosAr;

            Console.Write("Dame los grados a convertir: ");
            gradosAr = Convert.ToDouble(Console.ReadLine());

            GradosARadianes(gradosAr);
        }

        static void GradosARadianes(double gradosParam)
        {
            const double contanteConversíon = Math.PI / 180;
            double radianes;

            radianes = gradosParam * contanteConversíon;

            Console.WriteLine("{0} grados equivale a {1} radianes.", gradosParam, radianes);
        }
    }
}
