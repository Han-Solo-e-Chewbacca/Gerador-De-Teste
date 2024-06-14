using Gerador_De_Teste.ModuloDisciplinas;
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
    public partial class TelaMateriaForm : Form
    {
        public TelaMateriaForm()
        {
            InitializeComponent();
        }
        IRepositorioMateria repositorioMateria;
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;
            string serie = (string)cbmSerie.SelectedItem;

            List<Materia> ds = repositorioMateria.SelecionarTodos();

            materia = new Materia(nome, serie,disciplina);

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
    }
}
