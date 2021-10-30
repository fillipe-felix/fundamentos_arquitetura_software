using System;

namespace OOP._02___Pilares_OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario
            {
                Nome = "Fillipe",
                DataNascimento = Convert.ToDateTime("1993/07/18"),
                DataAdmissao = DateTime.Now,
                Registro = "12341234"
            };
        }
    }
}