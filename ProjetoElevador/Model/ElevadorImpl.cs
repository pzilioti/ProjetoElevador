using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model {

    //Implementação de um elevador
    internal class ElevadorImpl : Elevador {

        public override void Inicializar(int capacidade, int totalAndares) {
            this.andarAtual = 0;
            this.qtdPessoas = 0;
            this.capacidade = capacidade;
            this.totalAndares = totalAndares;
        }

        
        
        public override void Entrar() {
            //verifica se é possivel entrar mais uma pessoa
            if (qtdPessoas < capacidade) {
                qtdPessoas++;
            } else { //já está cheio, não faz a soma e avisa o usuário
                Console.WriteLine("Elevador cheio!!!");
            }
        }

        public override void Sair() {
            //verifica se é possivel sair mais uma pessoa
            if (qtdPessoas > 0) {
                qtdPessoas--;
            } else { //já está vazio, não faz a substração e avisa o usuário
                Console.WriteLine("Elevador já está vazio");
            }
        }

        public override void Subir() {
            //verifica se é possível subir mais um andar
            if(andarAtual < totalAndares) {
                andarAtual++;
            } else { // já está no topo, não sobe e avisa o usuário
                Console.WriteLine("Já estamos no ultimo andar");
            }
        }

        public override void Descer() {
            //verifica se é possível descer mais um andar
            if(andarAtual > 0) {
                andarAtual--;
            } else { //já está no terreo, não desce e avisa o usuário
                Console.WriteLine("Já estamos no térreo");
            }
        }
    }
}
