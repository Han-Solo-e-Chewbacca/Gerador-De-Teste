using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_De_Teste.ModuloDisciplinas
{
    public partial class ListagemDisciplinaControl : UserControl
    {
        public ListagemDisciplinaControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Disciplina> Disciplinas)
        {
            listDisciplinas.Items.Clear();

            foreach (Disciplina disciplina in Disciplinas)
                listDisciplinas.Items.Add(Disciplinas);
        }

        

        public Disciplina ObterRegistroSelecionado()
        {
            if (listDisciplinas.SelectedItem == null)
                return null;

            return (Disciplina)listDisciplinas.SelectedItem;
        }
       
    }
}
