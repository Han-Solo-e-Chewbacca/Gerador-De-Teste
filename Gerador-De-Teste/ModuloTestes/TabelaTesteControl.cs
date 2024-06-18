using Gerador_De_Teste.ModuloDisciplinas;
using Gerador_De_Teste.ModuloQuestoes;
using GeradorDeTeste.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_De_Teste.ModuloTestes
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();
            InitializeComponent();
            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
            grid.Columns[0].Width = 40;
        }
        public void AtualizarRegistros(List<Teste> Testes)
        {
            grid.Rows.Clear();

            foreach (Teste c in Testes)
                grid.Rows.Add(c.Id, c.Titulo, c.Disciplina.Nome.ToTitleCase(), c.Materia.Nome, c.Recuperacao.ToString(), c.QuantidadeDeQuestoes);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id",  },
                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Título" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina",  },
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Matéria" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Recuperacao", HeaderText = "Recuperação",  },
                new DataGridViewTextBoxColumn { DataPropertyName = "QuantidadeDeQuestoes", HeaderText = "Quantidade de Questões" },

                        };
        }

    }
}
