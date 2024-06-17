using Gerador_De_Teste.ModuloDisciplinas;
using Gerador_De_Teste.ModuloMateria;
using Gerador_De_Teste.ModuloQuestoes;
using GeradorDeTeste.WinApp.Compartilhado;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Gerador_De_Teste.ModuloTestes
{
    public class ControladorTeste : ControladorBase
    {
        private IRepositorioTeste repositorioTeste;
        private TabelaTesteControl tabelaTeste;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioQuestao repositorioQuestao;


        public ControladorTeste(IRepositorioTeste repositorio, IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina, IRepositorioQuestao repositorioQuestao)
        {
            repositorioTeste = repositorio;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioQuestao = repositorioQuestao;
        }

        public override string TipoCadastro { get { return "Teste"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo teste"; } }

        public override string ToolTipEditar { get { return "Editar um teste existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um teste existente"; } }

        public override void Adicionar()
        {
            TelaTesteForm telaTeste = new TelaTesteForm();

            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            telaTeste.CarregarDisciplinas(disciplinasCadastradas);

            List<Materia> materiasCadastradas = repositorioMateria.SelecionarTodos();

            telaTeste.CarregarMaterias(materiasCadastradas);

            List<Questao> questoesCadastradas = repositorioQuestao.SelecionarTodos();

            telaTeste.CarregarQuestoes(questoesCadastradas);


            DialogResult resultado = telaTeste.ShowDialog();


            if (resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaTeste.Teste;

            repositorioTeste.Cadastrar(novoTeste);

            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O teste \"{novoTeste.Titulo}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaTesteForm telaTeste = new TelaTesteForm();

            List<Materia> materiasCadastradas = repositorioMateria.SelecionarTodos();

            telaTeste.CarregarMaterias(materiasCadastradas);

            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            telaTeste.CarregarDisciplinas(disciplinasCadastradas);

            List<Questao> questoesCadastradas = repositorioQuestao.SelecionarTodos();

            telaTeste.CarregarQuestoes(questoesCadastradas);



            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado =
                repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaTeste.Teste = testeSelecionado;
            

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste testeEditado = telaTeste.Teste;

            repositorioTeste.Editar(testeSelecionado.Id, testeEditado);

            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{testeEditado.Titulo}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado =
                repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{testeSelecionado.Titulo}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioTeste.Excluir(testeSelecionado.Id);

            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{testeSelecionado.Titulo}\" foi excluído com sucesso!");
        }

        private void CarregarTestes()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();

            tabelaTeste.AtualizarRegistros(testes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTeste == null)
                tabelaTeste = new TabelaTesteControl();

            CarregarTestes();

            return tabelaTeste;
        }
        public override void GerarPDF()
        {

            TelaPDFForm telaGerarPDF = new TelaPDFForm();

            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado =
                repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }


            DialogResult resultado = telaGerarPDF.ShowDialog();


            if (resultado != DialogResult.OK)
                return;

            string nomeDoArqivo = telaGerarPDF.nomeArquivo;


            string momeArquivo = $"C:\\temp\\DadosSobreGeradorDeTestesVersaoFinal\\" + @"\" + nomeDoArqivo + ".pdf";
            FileStream arquivoPDF = new FileStream(momeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            string dados = "";
            doc.Open();

            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14,
                (int)System.Drawing.FontStyle.Regular));

            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add(testeSelecionado.Titulo + "\n");
            paragrafo.Add(testeSelecionado.Disciplina.Nome + "\n");
            paragrafo.Add(testeSelecionado.Materia.Nome + "\n\n");





            paragrafo.Alignment = Element.ALIGN_LEFT;
            foreach (Questao q in testeSelecionado.Questoes)
            {
                paragrafo.Add(q.Enunciado + "\n");
                foreach (string s in q.Alternativas)
                {
                    paragrafo.Add(s + "\n");
                }
                

                if (telaGerarPDF.ComRespostas)
                {
                    paragrafo.Add("Resposta: " + q.Resposta);
                
                }

                paragrafo.Add("\n");
            }

            doc.Add(paragrafo);
            doc.Close();



            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O PDF foi criado com sucesso!");
        }

        public override void Visualizar()
        {
            TelaVisualizacaoTeste telaVisualizacaoTeste = new TelaVisualizacaoTeste();

            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado =
                repositorioTeste.SelecionarPorId(idSelecionado);

            telaVisualizacaoTeste.ArrumarTelaVisualizar(testeSelecionado);

            DialogResult resultado = telaVisualizacaoTeste.ShowDialog();


            if (resultado != DialogResult.OK)

                if (testeSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            
           
        }

        public override void DuplicarTeste()
        {

            TelaTesteForm telaTeste = new TelaTesteForm();

            List<Materia> materiasCadastradas = repositorioMateria.SelecionarTodos();

            telaTeste.CarregarMaterias(materiasCadastradas);

            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            telaTeste.CarregarDisciplinas(disciplinasCadastradas);

            List<Questao> questoesCadastradas = repositorioQuestao.SelecionarTodos();

            telaTeste.CarregarQuestoes(questoesCadastradas);



            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado =
                repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaTeste.Teste = testeSelecionado;

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste testeEditado = telaTeste.Teste;

            repositorioTeste.Cadastrar(testeEditado);

            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{testeEditado.Titulo}\" foi duplicado com sucesso!");














        }













    }
}
