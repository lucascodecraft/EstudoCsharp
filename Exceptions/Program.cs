using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestaDivisao(-1);
                 FazerAlgo();
            }
            catch (ArgumentException ex)
            {
                if(ex.ParamName == "numero")
                {
                    
                }

                Console.WriteLine(ex.Message);
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Exceção do tipo ArgumentException");
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo DivideByZeroException");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        private static void FazerAlgo()
        {
            ContaCorrente conta = new ContaCorrente(12,511);
            ContaCorrente conta2 = new ContaCorrente(1551, 254);

                conta2.Transferir(10, conta);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(10);
                Console.WriteLine(conta.Saldo);
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }
    }
}
