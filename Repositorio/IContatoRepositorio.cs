using ListaDeContatoASPNET.Models;
using System;
using System.Collections.Generic;

namespace ListaDeContatoASPNET.Repositorio
{
    
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> GetContatoList();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);  
        bool Apagar(int id);
    }
}
