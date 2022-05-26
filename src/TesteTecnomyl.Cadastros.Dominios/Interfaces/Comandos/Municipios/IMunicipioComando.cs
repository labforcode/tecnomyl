using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Municipios
{
    public interface IMunicipioComando
    {
        void Adicionar(Municipio municipio);

        void Atualizar(Municipio municipio);

        void Excluir(Municipio municipio);
    }
}
