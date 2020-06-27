using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto02.Entity
{
    public class Funcionario
    {
        private string nome;
        private double salario;
        private Endereco endereco;

        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }
    }
}
