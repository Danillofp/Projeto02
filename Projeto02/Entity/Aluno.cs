using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto02.Entity
{
    public class Aluno
    {
        private string nome;
        private int idade;
        private Turma turma;
        private string matricula;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public Turma Turma { get => turma; set => turma = value; }
        public string Matricula { get => matricula; set => matricula = value; }
    }
}
