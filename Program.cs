using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_FormasGeometricas_PauloAraujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerodafigura, basetriangulo, alturatriangulo, basemaior, basemenor, alturatrapezio, sair=0;
            string figura;
            double raio, areacirculo, areatriangulo, areatrapezio;

            do
            {
                Console.WriteLine("Escolha uma das figuras geométricas abaixo: \n" +
                    "1 - Círculo;\n" +
                    "2 - Triângulo;\n" +
                    "3 - Trapézio;");
                numerodafigura = Convert.ToInt32(Console.ReadLine());
                //O switch case abaixo ficou sem sentido no conjunto do código.
                switch (numerodafigura)
                {
                    case 1:
                        figura = "Círculo";
                        break;
                    case 2:
                        figura = "Triângulo";
                        break;
                    case 3:
                        figura = "Trapézio";
                        break;
                }

                if (numerodafigura == 1)
                {
                    Console.Write("Para descobrir a área do círculo, nós precisamos que você informe qual é a medida do raio:\n");
                    Console.WriteLine("Digite o raio (em centímetros): ");
                    raio = Convert.ToDouble(Console.ReadLine());

                    areacirculo = 3.14 * (raio * raio);

                    Console.WriteLine($"A área do círculo é de {areacirculo} cm²");
                }
                else if (numerodafigura == 2)
                {
                    Console.Write("Para descobrir a área do triângulo, nós precisamos que você informe qual é a medida da base e da altura do triângulo:\n");
                    Console.Write("Digite o valor da base (em centímetros) : ");
                    basetriangulo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o valor da altura (em centímetros): ");
                    alturatriangulo = Convert.ToInt32(Console.ReadLine());

                    areatriangulo = (basetriangulo * alturatriangulo) / 2;
                    Console.WriteLine($"A área do triângulo é de {areatriangulo} cm²");
                }
                else if (numerodafigura == 3)
                {
                    Console.Write("Para descobrir a área do trapézio, nós precisamos que você informe qual é a medida da base mior, da base menor e da altura do trapézio:\n");
                    Console.Write("Digite o valor da base maior (em centímetros): ");
                    basemaior = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o valor da base menor (em centímetros): ");
                    basemenor = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o valor da altura (em centímetros): ");
                    alturatrapezio = Convert.ToInt32(Console.ReadLine());

                    areatrapezio = ((basemaior + basemenor) * alturatrapezio) / 2;
                    Console.WriteLine($"A área do triângulo é de {areatrapezio} cm²");
                }
                else
                {
                    Console.WriteLine("ERRO: Digite um número válido");
                }
                Console.WriteLine("Digite 1 para CONTINUAR e 2 para SAIR");
                sair = Convert.ToInt32(Console.ReadLine());
            } while (sair != 2);
        }
    }
}
