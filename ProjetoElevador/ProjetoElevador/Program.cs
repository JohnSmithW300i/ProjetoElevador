using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicita ao usuário que informe a capacidade limite do elevador.
            Console.Write("Qual a capacidade limite do elevador? ");
            var capacidade = int.Parse(Console.ReadLine());

            //Solicita ao usuário que informe a quantidade de andares que o prédio possui além do térreo.
            Console.Write("Qual o total de andares no prédio? ");
            var andares = int.Parse(Console.ReadLine());

            //Inicializa o uso do elevador trazendo a capacidade e os andares definidos pelo usuário.
            Elevador elevador = new Elevador();
            elevador.Inicializar(capacidade, andares);

            //Define a mensagem de acordo com a ação solicitada.
            int acao;
            string mensagem = null;
            string mensagem1 = null;

            //Repete o código até seja solicitado o encerramento com a opção 5.
            do
            {
                //Limpa a tela das informações apresentadas anteriormente.
                Console.Clear();

                /*Apresenta ao usuário as informações anteriormente coletadas e as que devem ser atualizadas com
                o uso do elevador, como: Capacidade, Total de andares, Quantidade de pessoas no elevador e o andar atual.*/
                Console.WriteLine($"Capacidade limite do elevador: {capacidade}");
                Console.WriteLine($"Total de andares do prédio: {andares}");
                Console.WriteLine($"Quantidade atual de pessoas no elevador: {elevador.Pessoas()}");
                Console.WriteLine($"Andar atual: {elevador.Andar()}\n");

                //Apresenta ao usuário as opções para uso do elevador.
                Console.WriteLine("1 - Entrar");
                Console.WriteLine("2 - Sair");
                Console.WriteLine("3 - Subir");
                Console.WriteLine("4 - Descer");
                Console.WriteLine("5 - Fechar\n");

                //Caso a opção selecionada não possa ser executada, informa uma das mensagens de erro listadas abaixo para cada caso.
                if (mensagem != null)
                {
                    Console.WriteLine($"{mensagem}\n");
                    mensagem = null;
                }
                else
                    Console.WriteLine($"{mensagem1}\n");
                mensagem1 = null;

                //Mantém na tela a solicitação para que o usuário informe uma opção.
                Console.Write("Informe a ação desejada: ");

                //Verifica se o usuário informou um número inteiro.
                if (!int.TryParse(Console.ReadLine(), out acao))
                    acao = 0;

                //Apresenta as mensagens de acordo com cada resposta do menu, seja positiva ou negativa.
                switch (acao)
                {
                    //Verifica a resposta e apresenta uma mensagem positiva ou negativa.
                    case 1:
                        if (!elevador.Entrar())
                        {
                            mensagem = "O elevador está cheio. Por favor, aguarde.";
                        }
                        else 
                             mensagem1 = "Uma pessoa entrou no elevador.";
                        break;                   
                    case 2:
                        if (!elevador.Sair())
                        {
                            mensagem = "O elevador está vazio.";
                        }
                        else
                            mensagem1 = "Uma pessoa saiu do elevador.";
                        break;                    
                    case 3:
                        if (!elevador.Subir())
                        {
                            mensagem = "Este é o último andar.";
                        }
                        else
                            mensagem1 = "Subindo.";
                        break;                   
                    case 4:
                        if (!elevador.Descer())
                        {
                            mensagem = "Estamos no Térreo.";
                        }
                        else
                            mensagem1 = "Descendo.";
                        break;                    
                    case 5:
                        Console.WriteLine("Fechando o elevador...");
                        break;

                    //Mensagem padrão apresentada para qualquer opção fora do padrão solicitado.
                    default:
                        mensagem = "Opção inválida. Tente novamente";
                        break;
                }
            }             
            while (acao != 5);
        }
    }
}
