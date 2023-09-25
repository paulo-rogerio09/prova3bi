using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prova_3Bimestre;

namespace prova_3Bimestre
{
    internal class Medico : Funcionario
    {
        public string Crm { get; set; }
        public double Valorhora { get; set; }
        public string Especialidade{ get; set; }

        public Medico(string crm, double valorhora, string especialidade, string nome, string cpf, string matricula, DateTime data, string sexo,
            double salario) : base(nome, cpf,  matricula, data, sexo, salario)
        {
            Crm = crm;
            Valorhora = valorhora;
            Especialidade = especialidade;
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            Data = data;
            Sexo = sexo;
            Salario = salario;
        }


        public Medico()
        {
        }
        

        public override void SalarioF(double valor)
        {
            valor = Salario * 0.20;

        }
    }
}
