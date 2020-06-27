using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto02.Entity
{
    public class Professor: Funcionario
    {
        private string disciplina;

        public string Disciplina { get => disciplina; set => disciplina = value; }
    }
}
