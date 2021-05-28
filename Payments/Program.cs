using System;

namespace classe_e_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Objeto sempre vai ser um tipo de referência
            //Só armazena o endereço dos dados
            var customer = new Customer();
            customer.Name = "Teste";

            var pagamento = new PagamentoBoleto();
            pagamento.Vencimento = DateTime.Now;
            pagamento.NumeroBoleto = "123123132";

            Console.WriteLine(pagamento);

            pagamento.DataPagamento = DateTime.Now;
        }
    }

    class Customer
    {
        //A classe é um molde para o objeto
        public string Name { get; set; }

        //Sobrecarga de método: Posso ter um método várias vezes com o mesmo nome e parâmetros diferentes


    }

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
