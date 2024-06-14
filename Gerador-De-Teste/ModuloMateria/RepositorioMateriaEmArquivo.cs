using Gerador_De_Teste.ModuloQuestoes;
using GeradorDeTeste.WinApp.Compartilhado;
using Gerador_De_Teste.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_De_Teste.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioBaseEmArquivo<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Materia> ObterRegistros()
        {
            return contexto.Materias;
        }

    }
}
