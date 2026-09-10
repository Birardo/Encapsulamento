using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    internal class Produto
    {
        private double _preco;

        public double preco
        {
            get { return _preco; }
            set
            {
                if(value < 0)
                {
                    _preco = 0;
                }
                else
                {
                    _preco = value;
                }
            }
        }
    }
}
