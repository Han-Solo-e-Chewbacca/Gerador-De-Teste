using Gerador_De_Teste.ModuloQuestoes;
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
    public partial class ListagemTesteControl : UserControl
    {
        public ListagemTesteControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Teste> Testes)
        {
            listTestes.Items.Clear();

            foreach (Teste teste in Testes)
                listTestes.Items.Add(Testes);
        }



        public Teste ObterRegistroSelecionado()
        {
            if (listTestes.SelectedItem == null)
                return null;

            return (Teste)listTestes.SelectedItem;
        }

    }
}
