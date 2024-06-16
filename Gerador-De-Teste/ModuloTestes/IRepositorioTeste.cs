using Gerador_De_Teste.ModuloQuestoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_De_Teste.ModuloTestes
{
    public interface IRepositorioTeste
    {
        void Cadastrar(Teste novoTeste);
        bool Editar(int id, Teste TesteEditado);
        bool Excluir(int id);
        Teste SelecionarPorId(int idSelecionado);
        List<Teste> SelecionarTodos();
    }
}
