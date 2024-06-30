using Gerador_De_Teste.ModuloDisciplinas;
using Gerador_De_Teste.ModuloMateria;
using Gerador_De_Teste.ModuloQuestoes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_De_Teste.ModuloTestes
{
    public class RepositorioTesteEmSql : IRepositorioTeste
    {
        private string enderecoBanco;

        public RepositorioTesteEmSql()
        {
            enderecoBanco = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GeradorDeTestesDb;Integrated Security=True;Pooling=False";
        }

        //public string Titulo { get; set; }
        //public Disciplina Disciplina { get; set; }
        //public int QuantidadeDeQuestoes { get; set; }
        //public Materia Materia { get; set; }
        //public bool Recuperacao { get; set; }
        //public List<Questao> Questoes { get; set; }

        private const string sqlInserir =
            @"INSERT INTO [TBTESTE]
                (                  
                    [TITULO],
                    [DISCIPLINA_ID],       
                    [QUANTIDADEDEQUESTOES],                          
                    [MATERIA_ID],                           
                    [RECUPERACAO],                           
                    [QUESTAO_ID]                           
                )
                VALUES
                (                    
                    @TITULO,
                    @DISCIPLINA_ID,
                    @QUANTIDADEDEQUESTOES,            
                    @MATERIA_ID,            
                    @RECUPERACAO,            
                    @QUESTAO_ID            
                ); SELECT SCOPE_IDENTITY();";

        private const string sqlEditar =
          @"UPDATE [TBQUESTAO]
                SET 
                    [TITULO],
                    [DISCIPLINA_ID],       
                    [QUANTIDADEDEQUESTOES],                          
                    [MATERIA_ID],                           
                    [RECUPERACAO],                           
                    [QUESTAO_ID]      
                WHERE 
                    [ID] = @ID";

        private const string sqlExcluir =
            @"DELETE FROM [TBQUESTAO]
		        WHERE
			        [ID] = @ID";

        private const string sqlSelecionarPorId =
          @"SELECT
                TS.[ID]
                TS.[TITULO],
                TS.[DISCIPLINA_ID],       
                TS.[QUANTIDADEDEQUESTOES],                          
                TS.[MATERIA_ID],                           
                TS.[RECUPERACAO],                           
                TS.[QUESTAO_ID]  ,  
                MT.[NOME],  
                MT.[SERIE],
                DS.[NOME]
               
            FROM
                [TBTESTE] AS TS LEFT JOIN
                [TBDisciplina] AS DS
                [TBMATERIA] AS MT
            ON
                DS.ID = MT.DISCIPLINA_ID
            WHERE
                MT.[ID] = @ID;";

        private const string sqlSelecionarTodos =
           @"SELECT
                TS.[ID]
                TS.[TITULO],
                TS.[DISCIPLINA_ID],       
                TS.[QUANTIDADEDEQUESTOES],                          
                TS.[MATERIA_ID],                           
                TS.[RECUPERACAO],                           
                TS.[QUESTAO_ID]  ,  
                MT.[NOME],  
                MT.[SERIE],
                DS.[NOME]
               
            FROM
                [TBTESTE] AS TS LEFT JOIN
                [TBDisciplina] AS DS
                [TBMATERIA] AS MT
            ON
                DS.ID = MT.DISCIPLINA_ID;";



        public void Cadastrar(Teste novoTeste)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfigurarParametrosTeste(novoTeste, comandoInsercao);

            conexaoComBanco.Open();

            object id = comandoInsercao.ExecuteScalar();

            novoTeste.Id = Convert.ToInt32(id);

            conexaoComBanco.Close();
        }

        public bool Editar(int id, Teste testeEditado)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            testeEditado.Id = id;

            ConfigurarParametrosTeste(testeEditado, comandoEdicao);

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

        public Teste SelecionarPorId(int idSelecionado)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao =
                new SqlCommand(sqlSelecionarPorId, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("ID", idSelecionado);

            conexaoComBanco.Open();

            SqlDataReader leitor = comandoSelecao.ExecuteReader();

            Teste teste = null;

            if (leitor.Read())
                teste = ConverterParaTeste(leitor);

            conexaoComBanco.Close();

            return teste;
        }

        public List<Teste> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao =
                new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open();

            SqlDataReader leitorTeste = comandoSelecao.ExecuteReader();

            List<Teste> testes = new List<Teste>();

            while (leitorTeste.Read())
            {
                Teste teste = ConverterParaTeste(leitorTeste);

                testes.Add(teste);
            }

            conexaoComBanco.Close();

            return testes;
        }

        #region métodos extras

        private Teste ConverterParaTeste(SqlDataReader leitorTeste)
        {

            Teste teste = new Teste()
            {
                Id = Convert.ToInt32(leitorTeste["ID"]),
                Titulo = Convert.ToString(leitorTeste["TITULO"]),
                QuantidadeDeQuestoes = Convert.ToInt32(leitorTeste["QUANTIDADEDEQUESTOES"]),

            };


            teste.Disciplina = ConverterParaDisciplina(leitorTeste);
            teste.Materia = ConverterParaMateria(leitorTeste);
            //teste.Questoes.Add();

            return teste;
        }

        private Disciplina ConverterParaDisciplina(SqlDataReader leitor)
        {
            Disciplina disciplina = new Disciplina()
            {
                Id = Convert.ToInt32(leitor["DISCIPLINA_ID"]),
                Nome = Convert.ToString(leitor["NOME"]),

            };

            return disciplina;
        }

        private static void ConfigurarParametrosTeste(Teste novoTeste, SqlCommand comandoInsercao)
        {
            comandoInsercao.Parameters.AddWithValue("ID", novoTeste.Id);
            comandoInsercao.Parameters.AddWithValue("TITULO", novoTeste.Titulo);
            comandoInsercao.Parameters.AddWithValue("RECUPERACAO", novoTeste.Recuperacao);
            comandoInsercao.Parameters.AddWithValue("QUANTIDADEDEQUESTOES", novoTeste.QuantidadeDeQuestoes);
            
            object valorDaDisciplina =
                novoTeste.Disciplina == null ? DBNull.Value : novoTeste.Disciplina.Id;

            comandoInsercao.Parameters.AddWithValue("DISCIPLINA_ID", valorDaDisciplina);

            object valorDaMateria =
              novoTeste.Materia == null ? DBNull.Value : novoTeste.Materia.Id;

            comandoInsercao.Parameters.AddWithValue("MATERIA_ID", valorDaMateria);

            object valorDaDisciplina =
              novoTeste.Disciplina == null ? DBNull.Value : novoTeste.Disciplina.Id;

            comandoInsercao.Parameters.AddWithValue("DISCIPLINA_ID", valorDaDisciplina);
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
    }
}
#endregion
}
