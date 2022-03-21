using ListaDeContatoASPNET.Models;
namespace ListaDeContatoASPNET.Repositorio
{
    public interface IContatoRepositiorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
