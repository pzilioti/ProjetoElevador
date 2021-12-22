using ProjetoElevador.Model;
using System;

namespace ProjetoElevador {
    internal class Program {
        static void Main(string[] args) {

            //eçevador é instanciado a partir da classe abstrata por polimorfismo
            Elevador elevador = new ElevadorImpl();

            //pergunta as variaveis de inicialização para o usuário
            Console.WriteLine("Bem vindo ao simulador de elevador.");
            Console.WriteLine("Quantos andares tem o prédio?");
            int totalAndares = pegarInfoDoUsuario();

            Console.WriteLine("Qual é a capacidade do elevador?");
            int capacidade = pegarInfoDoUsuario();

            //inicializa o elevador
            elevador.Inicializar(totalAndares, capacidade);


            while (true) {
                Console.Clear();
                //menu da simulação
                Console.WriteLine("#################################");
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("1 - Entrar uma pessoa");
                Console.WriteLine("2 - Sair uma pessoa");
                Console.WriteLine("3 - Subir um andar");
                Console.WriteLine("4 - Descer um andar");
                Console.WriteLine("5 - Finalizar simulador");
                Console.WriteLine("#################################");
                
                int opcao = pegarInfoDoUsuario();

                //aqui é melhor usar IF do que SWITCH pq dessa forma é possível dar um break direto no while caso o usuário escolha a opção 5
                if (opcao == 1) {
                    elevador.Entrar();
                } else if (opcao == 2) {
                    elevador.Sair();
                } else if (opcao == 3) {
                    elevador.Subir();
                } else if (opcao == 4) {
                    elevador.Descer();
                } else if (opcao == 5) {
                    break;
                } else { //caso default
                    Console.WriteLine("Opção inválida");
                }

                //imprime o status do elevador para o usuário
                imprimirStatusElevador(elevador);
                Console.WriteLine("#################################");
                Console.WriteLine();
                //para a informação ficar mais legivel para o usuário, é melhor colocar uma pausa aqui antes de ir para a proxima rodada
                Console.WriteLine("digite enter para continuar...");
                Console.ReadLine(); //readline só pra travar a tela
                
            }
            Console.WriteLine("Simulador finalizado!");
        }

        //função para tratar o input do usuário, só aceita int positivo, com os devidos tratamentos
        public static int pegarInfoDoUsuario() {
            int result = -1;
            while (true) {
                try {
                    result = int.Parse(Console.ReadLine());
                } catch (FormatException ex) { //exceção é gerada quando o usuário não digita numero
                    Console.WriteLine("Informar um número!");
                    //aqui é necessário um continue pq senão o código continua a rodar e imprime a msg dizendo que não pode número negativo, o que não faz sentido nesse caso
                    continue; 
                }
                if (result >= 0) return result;
                //se chegou até aqui é pq foi digitado um numero negativo
                else Console.WriteLine("Não pode número negativo");
            }
        }

        //função para imprimir o status do elevador
        public static void imprimirStatusElevador(Elevador elevador) {
            Console.WriteLine("Elevador está no andar " + elevador.andarAtual + " com um total de " + elevador.qtdPessoas + " pessoas");
        }
    }
}
