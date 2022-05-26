namespace TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos
{
    public class Produto
    {
        public Produto(int codigo,
                       string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        protected Produto()
        {
        }

        public int Codigo { get; private set; }

        public string Nome { get; private set; }
    }
}
