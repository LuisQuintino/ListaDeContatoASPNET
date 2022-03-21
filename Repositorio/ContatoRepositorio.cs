using ListaDeContatoASPNET.Data;
using ListaDeContatoASPNET.Models;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeContatoASPNET.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel home)
        {
            _bancoContext.Contatos.Add(home);
            _bancoContext.SaveChanges();    
            return home; 
        }

        public List<ContatoModel> GetContatoList()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault( b => b.id == id);
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.id);
            if (contatoDB == null) throw new System.Exception("Tivemos um erro na atualização do seu contato!");
            contatoDB.Nome = contato.Nome;
            contatoDB.sobrenome = contato.sobrenome;
            contatoDB.email = contato.email;
            contatoDB.observacao = contato.observacao;
            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();
            return contatoDB;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);

            if (contatoDB == null) throw new System.Exception("Houve um erro na hora de deletar o contato!");
            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
