using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_3Bimestre
{
    internal class Administrativo : Funcionario
    {
        public string Funcao { get; set; }

        public Administrativo(string funcao,string nome, string cpf, string matricula, DateTime data, string sexo, double salario) : base( nome,  cpf,  matricula,  data, sexo, salario)
        {
            Funcao = funcao;
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            Data = data;
            Sexo = sexo;
            Salario = salario;

        }

        public Administrativo()
        {
        }

        public override void SalarioF(double valor)
        {
            valor = (Salario * 0.15) + 150;
        }
    }
}
