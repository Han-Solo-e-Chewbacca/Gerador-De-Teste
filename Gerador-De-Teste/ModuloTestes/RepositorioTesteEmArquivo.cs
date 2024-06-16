using Gerador_De_Teste.ModuloQuestoes;
using GeradorDeTeste.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_De_Teste.ModuloTestes
{
    public class RepositorioTesteEmArquivo : RepositorioBaseEmArquivo<Teste>, IRepositorioTeste
    {
        public RepositorioTesteEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Teste> ObterRegistros()
        {
            return contexto.Testes;
        }

    }
}
