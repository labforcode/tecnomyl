using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Clientes
{
    public interface IClienteComando
    {
        void Adicionar(Cliente cliente);

        void Atualizar(Cliente cliente);

        void Excluir(Cliente cliente);
    }
}
