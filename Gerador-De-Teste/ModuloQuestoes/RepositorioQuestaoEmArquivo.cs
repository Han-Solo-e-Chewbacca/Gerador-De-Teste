using Gerador_De_Teste.ModuloDisciplinas;
using GeradorDeTeste.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_De_Teste.ModuloQuestoes
{
    public class RepositorioQuestaoEmArquivo : RepositorioBaseEmArquivo<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Questao> ObterRegistros()
        {
            return contexto.Questoes;
        }

    }
}
