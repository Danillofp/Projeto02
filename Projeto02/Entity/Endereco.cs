using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto02.Entity
{
    public class Endereco
    {
        private string rua;
        private string cep;
        private string complemento;

        public string Rua { get => rua; set => rua = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Complemento { get => complemento; set => complemento = value; }
    }
}
