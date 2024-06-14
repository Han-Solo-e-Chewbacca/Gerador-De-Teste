using Gerador_De_Teste.ModuloDisciplinas;
using Gerador_De_Teste.ModuloMateria;
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

namespace Gerador_De_Teste.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        public TelaMateriaForm()
        {
            InitializeComponent();
            cbDisciplina.Items.Clear();

        }
        IRepositorioMateria repositorioMateria;
        IRepositorioDisciplina repositorioDisciplina;
        private Materia materia;
        public Materia Materia
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                cbDisciplina.SelectedItem = value.Disciplina;
                cbmSerie.SelectedItem = value.Serie;
            }
            get
            {
                return materia;
            }
        }
        public void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cbDisciplina.Items.Clear();

            foreach (Disciplina c in disciplinas)
                cbDisciplina.Items.Add(c);
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;
            string serie = (string)cbmSerie.SelectedItem;

            

            materia = new Materia(nome, disciplina, serie);

            List<string> erros = materia.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TelaMateriaForm_Load(object sender, EventArgs e)
        {

        }

        private void cbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmSerie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
