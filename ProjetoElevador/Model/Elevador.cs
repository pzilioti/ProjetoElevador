using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model {

    //classe abstrata para o elevador
    abstract class Elevador {

        public int andarAtual;
        public int totalAndares;
        public int capacidade;
        public int qtdPessoas;

        public abstract void Inicializar(int capacidade, int totalAndares);
        public abstract void Entrar();
        public abstract void Sair();
        public abstract void Subir();
        public abstract void Descer();

    }
}
