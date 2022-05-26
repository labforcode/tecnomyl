using System.Collections.Generic;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;

namespace TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes
{
    public class Cliente
    {
        public Cliente(int codigo,
                       string cpf,
                       string nome,
                       int codigoMunicipio)
        {
            Codigo = codigo;
            Cpf = cpf;
            Nome = nome;
            CodigoMunicipio = codigoMunicipio;
        }

        protected Cliente()
        {

        }

        public int Codigo { get; private set; }

        public string Cpf { get; private set; }

        public string Nome { get; private set; }

        public int CodigoMunicipio { get; private set; }

        public virtual Municipio Municipio { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public void VincularMunicipio(int codigoMunicipio) => CodigoMunicipio = codigoMunicipio;

    }
}
