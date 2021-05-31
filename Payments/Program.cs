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
}
