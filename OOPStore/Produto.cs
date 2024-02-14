using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStore
{
    internal class Produto
    {

        private string _nome;
        private double _preco;
        private int _quantidade;


        public Produto()
        {

        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }


        public Produto (string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            
        }




        public double TotalEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantity)
        {
            _quantidade += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            _quantidade -= quantity;
        }

        public override string ToString()
        {
            return _nome
                + " $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + TotalEstoque();
        }
    }
}
