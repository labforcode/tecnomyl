using System;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Municipios;

namespace TesteTecnomyl.Cadastros.Dominios.Comandos.Clientes
{
    public class ClienteComando : IClienteComando
    {
        private readonly IClienteRepositoryEf _clienteRepositoryEf;
        private readonly IMunicipioRepositoryEf _municipioRepositoryEf;

        public ClienteComando(IClienteRepositoryEf clienteRepositoryEf,
                              IMunicipioRepositoryEf municipioRepositoryEf)
        {
            _clienteRepositoryEf = clienteRepositoryEf;
            _municipioRepositoryEf = municipioRepositoryEf;
        }

        public void Adicionar(Cliente cliente)
        {
            var municipio = _municipioRepositoryEf.ObterPorId(cliente.Codigo);
            if (municipio == null) throw new Exception("Município não localizado.");

            cliente.VincularMunicipio(cliente.CodigoMunicipio);

            _clienteRepositoryEf.Add(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
