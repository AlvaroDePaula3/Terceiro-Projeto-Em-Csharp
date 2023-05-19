using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terceiro_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selecao;
            do {
            Console.WriteLine("Aperte I para iniciar o programa, aperte S para sair do programa");
            selecao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (selecao == "i")
                {
                    Console.WriteLine("Digite aqui o seu nome completo:");
                    string nomeCompleto = Console.ReadLine();
                    Console.WriteLine("Digite a sua idade: ");
                    UInt32 idade = Convert.ToUInt32(Console.ReadLine());                    
                    Console.WriteLine("Digite o nome da sua rua: ");
                    string nomeDaRua = Console.ReadLine();
                    Console.WriteLine("Digite seu genero. M para masculino, F para feminino e  L para LGBT+: ");
                    char genero = Console.ReadKey(true).KeyChar;
                    Console.WriteLine("Digite a sua data de nascimento no formato de dd/mm/aaaa");
                    DateTime nascimento = Convert.ToDateTime(Console.ReadLine());

                    Console.Clear();
                }
                else if (selecao == "s")
                {
                    Console.WriteLine("O programa será fechado em breve");
                }
                else
                {
                    Console.WriteLine("Por favor, selecione uma das opções conhecidas");
                }
            } while ( selecao != "s");

            Console.WriteLine("Obrigado e volte sempre, pressione qualquer botão pra sair");

            Console.ReadKey();
        }
    }
}
