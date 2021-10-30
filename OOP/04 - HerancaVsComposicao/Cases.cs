using System;
using OOP._02___Pilares_OOP;

namespace OOP._04___HerancaVsComposicao
{
    #region Caso 1

    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }

    public class PessoaFisica2
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }

    public class TesteHerancaComposicao
    {
        public TesteHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica()
            {
                Nome = "Fillipe",
                DataNascimento = DateTime.Now,
                Cpf = "12345"
            };

            var pessoaComposicao = new PessoaFisica2()
            {
                Pessoa = new Pessoa()
                {
                    Nome = "Fillipe",
                    DataNascimento = DateTime.Now
                },
                Cpf = "12345"
            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }
    }

    #endregion

    #region Caso 2

    public interface IRepositorio<T>
    {
        void Adicionar(T obj);

        void Excluir(T obj);
    }

    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa obj);
    }

    public class Repositorio<T> : IRepositorio<T>
    {
        public void Adicionar(T obj)
        {
            
        }

        public void Excluir(T obj)
        {
            
        }
    }

    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {
        
    }

    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {
        private readonly IRepositorio<Pessoa> _repositorioPessoa;

        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }

        public void Adicionar(Pessoa obj)
        {
            _repositorioPessoa.Adicionar(obj);
        }
    }

    public class TestesHerancaComposicao2
    {
        public TestesHerancaComposicao2()
        {
            var repoHeranca = new RepositorioHerancaPessoa();
            repoHeranca.Adicionar(new Pessoa());
            repoHeranca.Excluir(new Pessoa());

            var repoComposicao = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());
            repoComposicao.Adicionar(new Pessoa());
        }
    }

    #endregion
    
}