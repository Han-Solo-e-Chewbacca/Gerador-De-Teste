using GeradorDeTeste.ConsoleApp.Compartilhado;
using GeradorDeTeste.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Gerador_De_Teste.ModuloDisciplinas
{
    public class Disciplina : EntidadeBase
    {
        public string Nome { get; set; }


        [JsonConstructor] 
        public Disciplina(string nome)
        {
            Nome = nome;
            
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");
            

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina atualizado = (Disciplina)novoRegistro;

            Nome = atualizado.Nome;
        }

        public override string ToString()
        {
            return Nome.ToTitleCase();
        }
    }
}
