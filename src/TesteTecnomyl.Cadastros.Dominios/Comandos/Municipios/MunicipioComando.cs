using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.UoW;

namespace TesteTecnomyl.Cadastros.Dominios.Comandos.Municipios
{
    public class MunicipioComando : IMunicipioComando
    {
        private readonly IUnitOfWork _uow;
        private readonly IMunicipioRepositoryEf _municipioRepositoryEf;

        public MunicipioComando(IUnitOfWork uow,
                                IMunicipioRepositoryEf municipioRepositoryEf)
        {
            _uow = uow;
            _municipioRepositoryEf = municipioRepositoryEf;
        }

        public void Adicionar(Municipio municipio)
        {
            _municipioRepositoryEf.Add(municipio);
            _uow.Commit();
        }

        public void Atualizar(Municipio municipio)
        {
            _municipioRepositoryEf.Update(municipio);
            _uow.Commit();
        }

        public void Excluir(Municipio municipio)
        {
            _municipioRepositoryEf.Delete(municipio);
            _uow.Commit();
        }
    }
}
