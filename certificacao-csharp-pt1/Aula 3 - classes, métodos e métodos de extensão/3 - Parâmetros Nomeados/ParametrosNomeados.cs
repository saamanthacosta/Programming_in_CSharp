using System;

namespace certificacao_csharp_roteiro
{
    class ParametrosNomeados : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial("Lucas");
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial = new ClienteEspecial();
            clienteEspecial.FazerPedido(1);
            clienteEspecial.FazerPedido(1, "Residencial");
            clienteEspecial.FazerPedido(quantidade: 3, produtoId: 1);

        }

        class ClienteEspecial
        {
            private readonly string nome;
            public ClienteEspecial(string nome = "Anônimo")
            {
                this.nome = nome;
            }

            public void FazerPedido(int produtoId, string endereco = "Residencial", int quantidade = 1)
            {
                Console.WriteLine("cliente {0}: produtoId: {1}, endereço: {2}, quantidade: {3}.", nome, produtoId, endereco, quantidade);
            }
        }
    }
}
