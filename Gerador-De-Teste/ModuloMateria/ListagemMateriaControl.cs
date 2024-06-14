using Gerador_De_Teste.ModuloQuestoes;
using GeradorDeTestes2024.ModuloMateria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_De_Teste.ModuloMateria
{
    public partial class ListagemMateriaControl : UserControl
    {
        public ListagemMateriaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Materia> Materias)
        {
            listMaterias.Items.Clear();

            foreach (Materia materia in Materias)
                listMaterias.Items.Add(Materias);
        }



        public Materia ObterRegistroSelecionado()
        {
            if (listMaterias.SelectedItem == null)
                return null;

            return (Materia)listMaterias.SelectedItem;
        }
        private void listMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
