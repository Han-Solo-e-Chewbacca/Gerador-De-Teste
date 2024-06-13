using Gerador_De_Teste.ModuloDisciplinas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_De_Teste.ModuloQuestoes
{
    public interface IRepositorioQuestao
    {
        void Cadastrar(Questao novaQuestao);
        bool Editar(int id, Questao QuestaoEditada);
        bool Excluir(int id);
        Questao SelecionarPorId(int idSelecionado);
        List<Questao> SelecionarTodos();
    }
}
