using Gerador_De_Teste.ModuloDisciplinas;
using Gerador_De_Teste.ModuloMateria;
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
    public partial class TelaQuestaoForm : Form
    {
        public TelaQuestaoForm()
        {
            InitializeComponent();
        }

        private Questao questao;
        public Questao Questao
        {
            set
            {
                txtId.Text = value.Id.ToString();
                cbmMateria.SelectedItem = value.Materia;
                txtEnunciado.Text = value.Enunciado;
                txtResposta.Text = value.Resposta;
                value.Alternativas.Add(checkBoxAlternativaA.Text);
                value.Alternativas.Add(checkBoxAlternativaB.Text);
                value.Alternativas.Add(checkBoxAlternativaC.Text);
                value.Alternativas.Add(checkBoxAlternativaD.Text);
            }
            get
            {
                return questao;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool continuar = false;
            if (cbAlternativCorreta.Text == "A" || cbAlternativCorreta.Text == "B" || cbAlternativCorreta.Text == "C"
                  || cbAlternativCorreta.Text == "D")
            {  continuar = true; }

                if (!continuar) {
                
                
                    MessageBox.Show(
                        "Não é possível realizar esta ação sem uma alternativa selecionada.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                
                    return;
                
            }
            else if (txtResposta.Text.Length > 0)
            {
                txtResposta.Enabled = false;
                btnAdicionar.Enabled = false;
                cbAlternativCorreta.Enabled = false;
            }


            switch (cbAlternativCorreta.Text)
            {
                case "A":
                    txtA.Text = txtResposta.Text;
                    txtA.Enabled = false;
                    break;
                case "B":
                    txtB.Text =txtResposta.Text;
                    txtB.Enabled = false;
                    break;
                case "C":
                    txtC.Text =txtResposta.Text;
                    txtC.Enabled = false;
                    break;
                case "D":
                    txtD.Text =txtResposta.Text;
                    txtD.Enabled = false;
                    break;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            checkBoxAlternativaA.Text = "(A)-> " + txtA.Text;
            checkBoxAlternativaB.Text = "(B)-> " + txtB.Text;
            checkBoxAlternativaC.Text = "(C)-> " + txtC.Text;
            checkBoxAlternativaD.Text = "(D)-> " + txtD.Text;

            Materia materia = (Materia)cbmMateria.SelectedItem;
            string enunciado = txtEnunciado.Text;
            string resposta = txtResposta.Text;
            List<string> Alternativas = new List<string>();
            Alternativas.Add(checkBoxAlternativaA.Text);
            Alternativas.Add((checkBoxAlternativaB.Text));
            Alternativas.Add((checkBoxAlternativaC.Text));
            Alternativas.Add((checkBoxAlternativaD.Text));

            questao = new Questao(materia, enunciado, resposta, Alternativas);

            List<string> erros = questao.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
        public void CarregarMaterias(List<Materia> Materias)
        {
            cbmMateria.Items.Clear();

            foreach (Materia c in Materias)
                cbmMateria.Items.Add(c);
        }
        private void checkBoxAlternativaA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbmMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaQuestaoForm_Load(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
