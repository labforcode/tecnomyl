using System.Collections.Generic;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;

namespace TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios
{
    public class Municipio
    {
        public Municipio(int codigo,
                         string uf,
                         string nome)
        {
            Codigo = codigo;
            Uf = uf;
            Nome = nome;
        }

        protected Municipio()
        {
        }

        public int Codigo { get; private set; }

        public string Uf { get; private set; }

        public string Nome { get; private set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
