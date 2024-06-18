using Gerador_De_Teste.ModuloDisciplinas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_De_Teste.ModuloQuestoes
{
    public partial class ListagemQuestaoControl : UserControl
    {
        public ListagemQuestaoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Questao> Questoes)
        {
            listQuestoes.Items.Clear();

            foreach (Questao questao in Questoes)
                listQuestoes.Items.Add(Questoes);
        }



        public Questao ObterRegistroSelecionado()
        {
            if (listQuestoes.SelectedItem == null)
                return null;

            return (Questao)listQuestoes.SelectedItem;
        }

    }
}
