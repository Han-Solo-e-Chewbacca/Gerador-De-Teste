using Gerador_De_Teste.ModuloDisciplinas;
using Gerador_De_Teste.ModuloMateria;
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
    public partial class TelaTesteForm : Form
    {
        public TelaTesteForm()
        {
            InitializeComponent();
        }
        private List<Questao> questoes = new List<Questao>();
        private List<Questao> questaosSelecionadas = new List<Questao>();
        private List<Materia> MateriasLista = new List<Materia>();
        private List<Questao> questoesDaMateria = new List<Questao>();
        private Teste teste;
        public Teste Teste
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo.ToString();
                cbmDisciplina.SelectedItem = value.Disciplina;
                numericQtdQuestoes.Value = value.QuantidadeDeQuestoes;
                cbmMateria.SelectedItem = value.Materia;
                cbRecuperacao.Checked = value.Recuperacao;
                questaosSelecionadas = value.Questoes;
            }
            get
            {
                return teste;
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TelaTesteForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //questoes.Clear();
            //questaosSelecionadas.Clear();

            string titulo = txtTitulo.Text;
            Disciplina disciplina = (Disciplina)cbmDisciplina.SelectedItem;
            int qtdQuestoes = Convert.ToInt32(numericQtdQuestoes.Value);
            Materia materia = (Materia)cbmMateria.SelectedItem;
            bool recupercao = cbRecuperacao.Checked;
            List<Questao> questao = questaosSelecionadas;


            teste = new Teste(titulo, disciplina, qtdQuestoes, materia, recupercao, questao);

            List<string> erros = teste.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
        public void CarregarDisciplinas(List<Disciplina> Disciplinas)
        {
            cbmDisciplina.Items.Clear();

            foreach (Disciplina c in Disciplinas)
                cbmDisciplina.Items.Add(c);
        }
        public void CarregarMaterias(List<Materia> Materias)
        {
            cbmMateria.Items.Clear();

            foreach (Materia c in Materias)
            {
                cbmMateria.Items.Add(c);
                MateriasLista.Add(c);
            }

        }
        public void CarregarQuestoes(List<Questao> Questoes)
        {
            listQuestoes.Items.Clear();
            questoes.Clear();

            foreach (Questao c in Questoes)
            {
                questoes.Add(c);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void numericQtdQuestoes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSortearQuestoes_Click(object sender, EventArgs e)
        {
            txtTitulo.Enabled = false;
            cbmMateria.Enabled = false;
            cbmDisciplina.Enabled = false;
            btnSortearQuestoes.Enabled = false;
            numericQtdQuestoes.Enabled = false;
            HashSet<int> numerosUsados = new HashSet<int>();
            Random rand = new Random();

            for (int i = 0; i < numericQtdQuestoes.Value; i++)
            {
                int random;
                do
                {
                    random = rand.Next(0, Convert.ToInt32(questoesDaMateria.Count));
                }
                while (!numerosUsados.Add(random)); // Tenta adicionar o número gerado ao HashSet, se já existir, gera um novo número

                questaosSelecionadas.Add(questoesDaMateria[random]);
            }

        }

        private void cbmMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmMateria.Text = "";
            cbmMateria.Enabled = true;
            cbmMateria.Items.Clear();
            Disciplina DisciplinaSelecionada = (Disciplina)cbmDisciplina.SelectedItem;
            foreach (Materia c in MateriasLista)
            {
                if (c.Disciplina.Id == DisciplinaSelecionada.Id)
                {
                    cbmMateria.Items.Add(c);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listQuestoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmMateria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listQuestoes.Items.Clear();
            

            Materia materia = (Materia)cbmMateria.SelectedItem;

            foreach (Questao c in questoes)
            {
                if (c.Materia.Nome == materia.Nome)
                {
                    listQuestoes.Items.Add(c);                    
                    questoesDaMateria.Add(c);
                }
            }
        }
    }
}
