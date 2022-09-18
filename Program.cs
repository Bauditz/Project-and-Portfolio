using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Condicionais simples (if-else)

            /*

            int valor = 10;

            if (valor == 5)
            {
                Console.WriteLine("Condição verdadeira!");
            } else
            {
                Console.WriteLine("Condição falsa!");
            }

            Console.WriteLine();
            Console.ReadKey();

            */

            #endregion

            #region Estruturas condicionais encadeadas (if-else/else-if)

            /*

            int valor = 10;

            if (valor < 5)
            {
                Console.WriteLine("Condição verdadeira!");
            } 
            else if (valor >= 5 && valor < 10)
            {
                Console.WriteLine("Condição alternativa 1!");
            }
            else if (valor >= 10 && valor < 20)
            {
                Console.WriteLine("Condição alternativa 2!");
            } 
            else
            {
                Console.WriteLine("Condição final!");
            }

            Console.ReadKey();

            */

            #endregion

            #region Condicionais aninhadas

            /*
            
            int numero = 10;

            if (numero > 5 )
            {
                Console.Write("O número é maior que 5");

                if (numero % 2 == 0)
                {
                    Console.WriteLine(" e também é par!");
                } else { Console.WriteLine("e também é impar!"); }
            } 

            Console.ReadKey();

            */

            #endregion

            #region Operador ternário

            /*

            int numero = 10;
            string mensagem = "";

            // condição ? true :  false; \/

            mensagem = numero > 5 ? "maior que cinco!" : "menor que cinco!"; 

            //if (numero > 5)
            //{
            //    mensagem = "maior que cinco!";
            //}
            //else
            //{
            //    mensagem = "menor que cinco!";
            //} 

            Console.WriteLine(mensagem);
            Console.ReadKey();

            */

            #endregion

            #region Calcular IMC (Exercício)

            /*
            
            double peso;
            double altura;
            double ICM;

            Console.Write("Bem vindo! aqui você poderá calcular seu IMC. Pressione qualquer tecla para continuar.");
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Insira seu peso: ");
            peso = Double.Parse(Console.ReadLine());
            Console.WriteLine("Vamos continuar, pressione qualquer tecla novamente!");
            Console.Clear();

            Console.WriteLine("Insira sua altura: ");
            altura = Double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Agora vamos calcular o seu ICM!");
            Console.WriteLine("Pressione qualquer tecla para dar ínicio ao cálculo...");
            Console.ReadKey();
            Console.Clear();

            ICM = peso / (altura * altura);

            if (ICM < 18.5)
            {
                Console.WriteLine("Seu ICM está em " + ICM + ", classificado como magreza!");
            } 
            else if (ICM >= 18.6 && ICM < 24.9)
            {
                Console.WriteLine("Seu ICM está em " + ICM + ", classificado como normal!");
            } 
            else if (ICM >= 25 && ICM < 29.9)
            {
                Console.WriteLine("Seu ICM está em " + ICM + ", classificado como sobrepeso!");
            }
            else if (ICM > 30)
            {
                Console.WriteLine("Seu ICM está em " + ICM + ", classificado como obesidade!");
            }

            Console.WriteLine("Pressione qualquer tecla para finalizar o programa!");
            Console.ReadKey();

            */

            #endregion
        }
    }
}
