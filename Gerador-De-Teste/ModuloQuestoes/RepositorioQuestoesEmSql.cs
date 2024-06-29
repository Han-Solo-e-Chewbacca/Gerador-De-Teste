using Gerador_De_Teste.ModuloDisciplinas;
using Gerador_De_Teste.ModuloMateria;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_De_Teste.ModuloQuestoes
{
    public class RepositorioQuestaoEmSql : IRepositorioQuestao
    {
        private string enderecoBanco;

        public RepositorioQuestaoEmSql()
        {
            enderecoBanco = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GeradorDeTestesDb;Integrated Security=True;Pooling=False";
        }

        private const string sqlInserir =
            @"INSERT INTO [TBQUESTAO]
                (                  
                    [MATERIA_ID],
                    [ENUNCIADO],       
                    [RESPOSTA],
                    [ALTERNATIVAS1],
                    [ALTERNATIVAS2],
                    [ALTERNATIVAS3],
                    [ALTERNATIVAS4]
                )
                VALUES
                (                    
                    @MATERIA_ID,
                    @ENUNCIADO,
                    @RESPOSTA,
                    @ALTERNATIVAS1,
                    @ALTERNATIVAS2,
                    @ALTERNATIVAS3,
                    @ALTERNATIVAS4
                ); SELECT SCOPE_IDENTITY();";

        private const string sqlEditar =
          @"UPDATE [TBQUESTAO]
                SET 
                    [MATERIA_ID] = @MATERIA_ID ,
                    [ENUNCIADO] = @ENUNCIADO,       
                    [RESPOSTA] = @RESPOSTA,   
                    [ALTERNATIVAS1] = @ALTERNATIVAS1 ,  
                    [ALTERNATIVAS2] = @ALTERNATIVAS2  , 
                    [ALTERNATIVAS3] = @ALTERNATIVAS3  , 
                    [ALTERNATIVAS4] = @ALTERNATIVAS4   
                WHERE 
                    [ID] = @ID";

        private const string sqlExcluir =
            @"DELETE FROM [TBQUESTAO]
		        WHERE
			        [ID] = @ID";

        private const string sqlSelecionarPorId =
          @"SELECT
                QT.[ID],
                QT.[MATERIA_ID],
                QT.[ENUNCIADO],
                QT.[RESPOSTA],
                QT.[ALTERNATIVAS1],
                QT.[ALTERNATIVAS2],
                QT.[ALTERNATIVAS3],
                QT.[ALTERNATIVAS4],
                MT.[ID],
                MT.[NOME],  
                MT.[SERIE],
                MT.[DISCIPLINA_ID]
               
            FROM
                [TBQUESTAO] AS QT LEFT JOIN
                [TBMateria] AS MT
            ON
                MT.ID = QT.MATERIA_ID
            WHERE
                QT.[ID] = @ID;";

        private const string sqlSelecionarTodos =
            @"SELECT
                QT.[ID],
                QT.[MATERIA_ID],
                QT.[ENUNCIADO],
                QT.[RESPOSTA],
                QT.[ALTERNATIVAS1],
                QT.[ALTERNATIVAS2],
                QT.[ALTERNATIVAS3],
                QT.[ALTERNATIVAS4],
                MT.[ID],
                MT.[NOME],  
                MT.[SERIE],
                MT.[DISCIPLINA_ID]
               
               
            FROM
                [TBQUESTAO] AS QT LEFT JOIN
                [TBMateria] AS MT
            ON
                MT.ID = QT.MATERIA_ID;";



        public void Cadastrar(Questao novaQuestao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfigurarParametrosQuestao(novaQuestao, comandoInsercao);

            conexaoComBanco.Open();

            object id = comandoInsercao.ExecuteScalar();

            novaQuestao.Id = Convert.ToInt32(id);

            conexaoComBanco.Close();
        }

        public bool Editar(int id, Questao questaoEditada)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            questaoEditada.Id = id;

            ConfigurarParametrosQuestao(questaoEditada, comandoEdicao);

            conexaoComBanco.Open();

            int numeroRegistrosAfetados = comandoEdicao.ExecuteNonQuery();

            conexaoComBanco.Close();

            if (numeroRegistrosAfetados < 1)
                return false;

            return true;
        }

        public bool Excluir(int id)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("ID", id);

            conexaoComBanco.Open();

            int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

            conexaoComBanco.Close();

            if (numeroRegistrosExcluidos < 1)
                return false;

            return true;
        }

        public Questao SelecionarPorId(int idSelecionado)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao =
                new SqlCommand(sqlSelecionarPorId, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("ID", idSelecionado);

            conexaoComBanco.Open();

            SqlDataReader leitor = comandoSelecao.ExecuteReader();

            Questao questao = null;

            if (leitor.Read())
                questao = ConverterParaQuestao(leitor);

            conexaoComBanco.Close();

            return questao;
        }

        public List<Questao> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao =
                new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open();

            SqlDataReader leitorQuestao = comandoSelecao.ExecuteReader();

            List<Questao> questoes = new List<Questao>();

            while (leitorQuestao.Read())
            {
                Questao questao = ConverterParaQuestao(leitorQuestao);

                questoes.Add(questao);
            }

            conexaoComBanco.Close();

            return questoes;
        }

        #region métodos extras

        private Questao ConverterParaQuestao(SqlDataReader leitorMateria)
        {

            Questao questao = new Questao()
            {
                Id = Convert.ToInt32(leitorMateria["ID"]),
                Enunciado = Convert.ToString(leitorMateria["ENUNCIADO"]),
                Resposta = Convert.ToString(leitorMateria["RESPOSTA"]),

            };

        List<string> alternativas = new List<string>();
            alternativas.Add(Convert.ToString(leitorMateria["ALTERNATIVAS1"]));
            alternativas.Add(Convert.ToString(leitorMateria["ALTERNATIVAS2"]));
            alternativas.Add(Convert.ToString(leitorMateria["ALTERNATIVAS3"]));
            alternativas.Add(Convert.ToString(leitorMateria["ALTERNATIVAS4"]));
            
            
            
            questao.Alternativas = alternativas;
            questao.Materia = ConverterParaMateria(leitorMateria);

            return questao;
        }

        private Materia ConverterParaMateria(SqlDataReader leitor)
        {
            Materia materia = new Materia()
            {
                Id = Convert.ToInt32(leitor["Materia_ID"]),
                Nome = Convert.ToString(leitor["NOME"]),
                Serie = Convert.ToString(leitor["SERIE"]),

            };
            object valorDaDisciplina =
                materia.Disciplina == null ? DBNull.Value : materia.Disciplina.Id;

            return materia;
        }

        private static void ConfigurarParametrosQuestao(Questao novaQuestao, SqlCommand comandoInsercao)
        {
            comandoInsercao.Parameters.AddWithValue("ID", novaQuestao.Id);
            comandoInsercao.Parameters.AddWithValue("ENUNCIADO", novaQuestao.Enunciado);
            comandoInsercao.Parameters.AddWithValue("RESPOSTA", novaQuestao.Resposta);

            int contador = 1;
            foreach (String s in novaQuestao.Alternativas)
            {
                comandoInsercao.Parameters.AddWithValue("ALTERNATIVAS"+contador,s);
                contador++;
            }


            object valorDaMateria =
                novaQuestao.Materia == null ? DBNull.Value : novaQuestao.Materia.Id;

            comandoInsercao.Parameters.AddWithValue("MATERIA_ID", valorDaMateria);
        }
    }
}
#endregion

