using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    internal class Carro
    {
        private int _velocidadeAtual;

        public void acelerar()
        {
            _velocidadeAtual += 10;
            Console.WriteLine("O carro está acelerando!!");
        }
        public void frear()
        {
            if (_velocidadeAtual > 0)
            {
                _velocidadeAtual -= 10;
                Console.WriteLine("O carro está freiando!!");
            }
            else
            {
                Console.WriteLine("O carro não pode frear mais!!");
            }
        }
        public int velocidadeAtual
        {
            get
            {
                return _velocidadeAtual;
            }
        }
    }
}