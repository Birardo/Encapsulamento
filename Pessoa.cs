using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    internal class Pessoa
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Nome não pode ser vazio");
                }
                else
                {
                    _nome = value;
                }
            }
        }
    }
}