using System;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.UoW;

namespace TesteTecnomyl.Cadastros.Dominios.Comandos.Clientes
{
    public class ClienteComando : IClienteComando
    {
        private readonly IUnitOfWork _uow;
        private readonly IClienteRepositoryEf _clienteRepositoryEf;
        private readonly IMunicipioRepositoryEf _municipioRepositoryEf;

        public ClienteComando(IUnitOfWork uow,
                              IClienteRepositoryEf clienteRepositoryEf,
                              IMunicipioRepositoryEf municipioRepositoryEf)
        {
            _uow = uow;
            _clienteRepositoryEf = clienteRepositoryEf;
            _municipioRepositoryEf = municipioRepositoryEf;
        }

        public void Adicionar(Cliente cliente)
        {
            var municipio = _municipioRepositoryEf.ObterPorId(cliente.CodigoMunicipio).Result;
            if (municipio == null) throw new Exception("Município não localizado.");

            var clienteExistente = _clienteRepositoryEf.ObterPorCpf(cliente.Cpf).Result;
            if (clienteExistente != null) throw new Exception("Cliente já cadastrado.");

            cliente.VincularMunicipio(cliente.CodigoMunicipio);

            _clienteRepositoryEf.Add(cliente);
            _uow.Commit();
        }

        public void Atualizar(Cliente cliente)
        {
            var clienteExistente = _clienteRepositoryEf.ObterPorId(cliente.Codigo).Result;
            if (clienteExistente == null) throw new Exception("Cliente não localizado.");

            _clienteRepositoryEf.Update(cliente);
            _uow.Commit();
        }

        public void Excluir(Cliente cliente)
        {
            _clienteRepositoryEf.Delete(cliente);
            _uow.Commit();
        }
    }
}
