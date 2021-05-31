using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_e_objeto
{
    class Pagamento
    {
        // Propriedades --> variáveis
        public DateTime Vencimento;

        private DateTime _dataPagamento;
        public DateTime DataPagamento
        {
            get
            {
                Console.WriteLine("Lendo o valor");
                return _dataPagamento;
            }
            set
            {
                Console.WriteLine("Atribuindo o valor");
                _dataPagamento = value;
            }
        }


        // Métodos --> funções
        public virtual void Pagar() //Modificador virtual permite que o método seja sobrescrito
        {
        }
        // Private evita expor o método para fora da classe
        // private void ConsultarSaldoDoCartao() { }

    }

    class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto { get; set; }
    }

    /*
        Modificadores: private, protected, internal e public.

        private (padrão): O método só pode ser visualizado pelos itens que estão dentro da mes classe ou struct.
        protected: O método poderá ser visualizado pelas classes herdeiras (derivadas). Visível só para os filhos das classes.
        internal: A proteção é no assembly. Pode ser acessado por codigo no mesmo assembly, porém não por outros assemblies.
        public: Visível em qualquer lugar dentro do assembly ou dentro de asseblies que façam referência a ele
    */

    class PagamentoCartaoCredito : Pagamento
    {
        public PagamentoCartaoCredito()
        {
            Console.WriteLine("Construtor inicial");
        }
        public string NumeroDoCartao;

        //Sobrescreve a regra herdada.
        public override void Pagar()
        {
            Console.WriteLine("Pagar cartão");
            // Sempre que quiser acessar o método da classe pai utilizar o base
            base.Pagar();
        }
    }
}
