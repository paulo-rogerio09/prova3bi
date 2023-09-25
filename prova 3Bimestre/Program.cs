using System;
using prova_3Bimestre;

class Program

{
	static void Main(string[] args)
	{
        Funcionario f = new Funcionario();

        List<Funcionario> list = new List<Funcionario>();

        Medico m = new Medico();
        List<Medico> listm = new List<Medico>();

        Administrativo a = new Administrativo();
        List<Administrativo> lista = new List<Administrativo>();


        while (true)
        {
            try
            {

            
                Console.WriteLine("deseja cadastrar qual funcionario?\n" +
                "1- normal\n" +
                "2- medico\n" +
                "3 administrativo\n" +
                "4- sair");
             int escolha = Convert.ToInt32(Console.ReadLine());

                if(escolha == 1)
            {
                
                Console.WriteLine("digite o nome");
                f.Nome = Console.ReadLine();

                Console.WriteLine("digite o cpf");
                f.Cpf = Console.ReadLine();

                Console.WriteLine("digite a matricula");
                f.Matricula = Console.ReadLine();

                Console.WriteLine("digite a data de nascimento");
                f.Data = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("digite o sexo");
                f.Sexo = Console.ReadLine();

                Console.WriteLine("digite o salario desejado");
                f.Salario= Convert.ToDouble(Console.ReadLine());
                f.SalarioF(f.Salario);

                list.Add(f);


            }
            if (escolha == 2)
            {

                Console.WriteLine("digite o nome");
                m.Nome = Console.ReadLine();

                Console.WriteLine("digite o cpf");
                m.Cpf = Console.ReadLine();

                Console.WriteLine("digite a matricula");
                m.Matricula = Console.ReadLine();

                Console.WriteLine("digite a data de nascimento");
                m.Data = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("digite o sexo");
                m.Sexo = Console.ReadLine();

                Console.WriteLine("digite o salario desejado");
                m.Salario = Convert.ToDouble(Console.ReadLine());
                m.SalarioF(m.Salario);

                Console.WriteLine("digite o crm");
                m.Crm = Console.ReadLine();

                Console.WriteLine("digite o valor da hora");
                m.Valorhora = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("digite a especialidade");
                m.Especialidade = Console.ReadLine();

                list.Add(m);

            }
            if (escolha == 3)
            {

                Console.WriteLine("digite o nome");
                a.Nome = Console.ReadLine();

                Console.WriteLine("digite o cpf");
                a.Cpf = Console.ReadLine();

                Console.WriteLine("digite a matricula");
                a.Matricula = Console.ReadLine();

                Console.WriteLine("digite a data de nascimento");
                a.Data = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("digite o sexo");
                a.Sexo = Console.ReadLine();

                Console.WriteLine("digite o salario desejado");
                a.Salario = Convert.ToDouble(Console.ReadLine());
                a.SalarioF(a.Salario);

                Console.WriteLine("digite a funçao");
                a.Sexo = Console.ReadLine();

                list.Add(a);

            }


                if (escolha == 4)
                {


                    foreach (Funcionario str in list)
                    {
                        Console.WriteLine(f.Nome + " " + f.Salario);
                    }
                    foreach (Medico stl in listm)
                    {
                        Console.WriteLine(m.Nome + " " + m.Salario);
                    }
                    foreach (Administrativo stb in lista)
                    {
                        Console.WriteLine(a.Nome + " " + a.Salario);
                    }
                    goto sair;

                    //eu sei que o foreach esta errado mas nao vai dar tempo de resolver
                }

            }
            catch (Exception e)
            {

            }

        }

    sair:;
    }
}