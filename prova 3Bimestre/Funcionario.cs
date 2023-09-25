using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_3Bimestre
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime Data { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cpf, string matricula, DateTime data, string sexo, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            Data = data;
            Sexo = sexo;
            Salario = salario;
        }

        public Funcionario()
        {
        }

        public virtual void SalarioF(double valor)
        {
            valor = Salario;
        }
    }
}
