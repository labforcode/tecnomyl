using System;
using System.Collections.Generic;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;

namespace TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos
{
    public class Pedido
    {
        public Pedido(int codigo,
                      int codigoCliente,
                      DateTime dataPedido,
                      List<ItemPedido> itens)
        {
            Codigo = codigo;
            CodigoCliente = codigoCliente;
            DataPedido = dataPedido;
            _itensPedido = itens;
        }

        protected Pedido()
        {
        }

        private List<ItemPedido> _itensPedido;

        public int Codigo { get; private set; }

        public int CodigoCliente { get; private set; }

        public DateTime DataPedido { get; private set; }

        public List<ItemPedido> ItensPedido { get; }

        public virtual Cliente Cliente { get; set; }

        public void AdicionarItensPedido(List<ItemPedido> itensPedido) => _itensPedido = itensPedido;

        public List<ItemPedido> ObterItensPedido() => _itensPedido;

        public void AdicionarDataPedido() => DataPedido = DateTime.Now;
    }
}
