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
                value.Alternativas.Add(checkBoxAlternativaA);
                value.Alternativas.Add(checkBoxAlternativaB);
                value.Alternativas.Add(checkBoxAlternativaC);
                value.Alternativas.Add(checkBoxAlternativaD);
            }
            get
            {
                return questao;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtResposta.Text.Length < 0) 
            txtResposta.Enabled = false;

            switch(cbAlternativCorreta.Text)
            {
                case "A":
                    txtA.Text = "(A)-> "+txtResposta.Text;
                    txtA.Enabled = false;
                    break;
                case "B":
                    txtB.Text = "(B)-> "+txtResposta.Text;
                    txtB.Enabled = false;
                    break;
                case "C":
                    txtC.Text = "(C)-> "+txtResposta.Text;
                    txtC.Enabled = false;
                    break;
                case "D":
                    txtD.Text = "(D)-> "+txtResposta.Text;
                    txtD.Enabled = false;
                    break;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            checkBoxAlternativaA.Text= txtA.Text;
            checkBoxAlternativaB.Text= txtB.Text;
            checkBoxAlternativaC.Text= txtC.Text;
            checkBoxAlternativaD.Text= txtD.Text;

            Materia materia = (Materia)cbmMateria.SelectedItem;
            string enunciado = txtEnunciado.Text;
            string resposta = txtResposta.Text;
            List<CheckBox> Alternativas = null;
            Alternativas.Add(checkBoxAlternativaA);
            Alternativas.Add((checkBoxAlternativaB));
            Alternativas.Add((checkBoxAlternativaC));
            Alternativas.Add((checkBoxAlternativaD));

            questao = new Questao(materia, enunciado, resposta, Alternativas);

            List<string> erros = questao.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
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
    }
}
