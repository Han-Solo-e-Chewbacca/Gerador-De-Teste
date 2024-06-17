using Gerador_De_Teste.ModuloDisciplinas;
using GeradorDeTeste.ConsoleApp.Compartilhado;
using GeradorDeTeste.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Gerador_De_Teste.ModuloMateria
{
    public class Materia : EntidadeBase
    {
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; }
        public string Serie { get; set; }

        [JsonConstructor]
        public Materia(string nome,Disciplina disciplina,string serie)
        {
            Nome = nome;
            Disciplina = disciplina;
            Serie = serie;

        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");
            if (string.IsNullOrEmpty(Serie))
                erros.Add("O campo \"série\" é obrigatório");
            if (Disciplina == null)
                erros.Add("O campo \"disciplina\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Materia atualizado = (Materia)novoRegistro;

            Nome = atualizado.Nome;
            Disciplina= atualizado.Disciplina;
            Serie= atualizado.Serie;

        }

        public override string ToString()
        {
            return Nome.ToTitleCase();
        }
    }
}
