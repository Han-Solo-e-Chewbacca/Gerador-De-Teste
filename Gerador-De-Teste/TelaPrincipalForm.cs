using GeradorDeTeste.WinApp.Compartilhado;
using Gerador_De_Teste.ModuloDisciplinas;
using Gerador_De_Teste.ModuloQuestoes;
using Gerador_De_Teste.ModuloMateria;
using Gerador_De_Teste.ModuloTestes;
using System.Reflection.Metadata;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Gerador_De_Teste
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        ContextoDados contexto;

        IRepositorioDisciplina repositorioDisciplina;
        IRepositorioQuestao repositorioQuestao;
        IRepositorioMateria repositorioMateria;
        IRepositorioTeste repositorioTeste;

        public static TelaPrincipalForm Instancia { get; private set; }
        public TelaPrincipalForm()
        {
            InitializeComponent();

            contexto = new ContextoDados(carregarDados: true);

            repositorioDisciplina = new RepositorioDisciplinaEmArquivo(contexto);
            repositorioMateria = new RepositorioMateriaEmArquivo(contexto);
            repositorioQuestao = new RepositorioQuestaoEmArquivo(contexto);
            repositorioTeste = new RepositorioTesteEmArquivo(contexto);

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;



            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;


        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnGerarPDF.Enabled = false;
            controlador = new ControladorDisciplina(repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void matériasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnGerarPDF.Enabled = false;
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }

        private void questõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnGerarPDF.Enabled = false;
            controlador = new ControladorQuestao(repositorioQuestao, repositorioMateria);

            ConfigurarTelaPrincipal(controlador);
        }

        private void testesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnGerarPDF.Enabled = true;
            controlador = new ControladorTeste(repositorioTeste, repositorioMateria, repositorioDisciplina, repositorioQuestao);

            ConfigurarTelaPrincipal(controlador);
        }

        private void pnlRegistros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
           controlador.GerarPDF();
            
        }
    }
}
