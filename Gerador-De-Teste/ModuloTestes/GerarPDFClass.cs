using Gerador_De_Teste.ModuloQuestoes;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Gerador_De_Teste.ModuloTestes
{
    public partial class ControladorTeste
    {
        public class GerarPDFClass
        {
            public  void GerarArquivoPDF(TelaPDFForm telaGerarPDF, Teste testeSelecionado)
            {
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
            }
        }
    }
}
