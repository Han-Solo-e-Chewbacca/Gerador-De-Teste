using GeradorDeTeste.ConsoleApp.Compartilhado;
using GeradorDeTeste.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerador_De_Teste.ModuloMateria;

namespace Gerador_De_Teste.ModuloQuestoes
{
    public class Questao : EntidadeBase
    {
        public Materia Materia { get; set; }
        public string Enunciado { get; set; }
        public string Resposta { get; set; }
        public List<string> Alternativas { get; set; }


        public Questao(Materia materia,string enunciado,string resposta,List<string> alternativas)
        {
            Materia = materia;
            Enunciado = enunciado;
            Resposta = resposta;
            Alternativas = alternativas;
            
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            //if (string.IsNullOrEmpty(Materia.Trim()))
            //    erros.Add("O campo \"nome\" é obrigatório");
            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"enunciado\" é obrigatório");
            if (string.IsNullOrEmpty(Resposta.Trim()))
                erros.Add("O campo \"resposta\" é obrigatório");
            if (Alternativas.Count<0)
                erros.Add("O campo \"alternativas\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao atualizado = (Questao)novoRegistro;

            Materia = atualizado.Materia;
            Enunciado = atualizado.Enunciado;
            Resposta= atualizado.Resposta;
            Alternativas=atualizado.Alternativas;
        }

        public override string ToString()
        {
            return Enunciado.ToTitleCase();
        }
    }
}
