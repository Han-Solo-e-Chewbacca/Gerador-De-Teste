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
using static System.Net.Mime.MediaTypeNames;

namespace Gerador_De_Teste.ModuloTestes
{
    public partial class TelaVisualizacaoTeste : Form
    {
        public TelaVisualizacaoTeste()
        {
            InitializeComponent();
           
        }

        private void TelaVisualizacaoTeste_Load(object sender, EventArgs e)
        {
            
        }

        public void ArrumarTelaVisualizar(Teste teste)
        {
            lblDisciplina.Text = teste.Disciplina.Nome;
            lblMateria.Text = teste.Materia.Nome;
            lblTitulo.Text = teste.Titulo;
            foreach (Questao q in teste.Questoes)
            {
                listQuestoes.Items.Add(q);
            }
        }
    }
}
