using ListaDeContatoASPNET.Data;
using ListaDeContatoASPNET.Models;

namespace ListaDeContatoASPNET.Repositorio
{
    public class ContatosRepositorio : IContatoRepositiorio
    {
        private readonly BancoContext _bancoContext;
        public ContatosRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }


    }
}
