using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace AcademiaProgramador.MODEL
{
    public class Chamados
    {

        public string equipamento { get; set; }
        public string titulo { get; set; }

        public string descricao { get; set; }

        public DateTime dataAbertura { get; set; }

        public int idChamado { get; set; }



    }

    public class ChamadosDAO
    {
        private DbProviderFactory factory;
        public ChamadosDAO()
        {

        }


        public void CadastrarChamados(string provider, string stringConexao, Chamados chamados)
        {
            factory = DbProviderFactories.GetFactory(provider);
            using (var conexao = factory.CreateConnection())
            {
                conexao.ConnectionString = stringConexao;
                using (var comando = factory.CreateCommand())
                {


                    comando.Connection = conexao;

                    var titulo = comando.CreateParameter();
                    titulo.ParameterName = "@titulo";
                    titulo.Value = chamados.titulo;
                    comando.Parameters.Add(titulo);

                    var descricao = comando.CreateParameter();
                    descricao.ParameterName = "@descricao";
                    descricao.Value = chamados.descricao;
                    comando.Parameters.Add(descricao);

                    var dataAbertura = comando.CreateParameter();
                    dataAbertura.ParameterName = "@dataAbertura";
                    dataAbertura.Value = chamados.dataAbertura;
                    comando.Parameters.Add(dataAbertura);

                    var equipamento = comando.CreateParameter();
                    equipamento.ParameterName = "@equipamento";
                    equipamento.Value = chamados.equipamento;
                    comando.Parameters.Add(equipamento);





                    conexao.Open();
                    comando.CommandText = @"INSERT INTO tb_chamados(titulo, descricao, equipamento, dataAbertura)
                    VALUES (@titulo, @descricao, @equipamento, @dataAbertura)";

                    var linhas = comando.ExecuteNonQuery();
                }
            }

        }
        public void EditarChamados(string provider, string stringConexao, Chamados chamados)
        {
            factory = DbProviderFactories.GetFactory(provider);
            using (var conexao = factory.CreateConnection())
            {
                conexao.ConnectionString = stringConexao;
                using (var comando = factory.CreateCommand())
                {
                    comando.Connection = conexao;

                    var id = comando.CreateParameter();
                    id.ParameterName = "@id";
                    id.Value = chamados.idChamado;
                    comando.Parameters.Add(id);

                    var titulo = comando.CreateParameter();
                    titulo.ParameterName = "@titulo";
                    titulo.Value = chamados.titulo;
                    comando.Parameters.Add(titulo);


                    var descricao = comando.CreateParameter();
                    descricao.ParameterName = "@descricao";
                    descricao.Value = chamados.descricao;
                    comando.Parameters.Add(descricao);

                    var equipamento = comando.CreateParameter();
                    equipamento.ParameterName = "@equipamento";
                    equipamento.Value = chamados.equipamento;
                    comando.Parameters.Add(equipamento);

                    var dataAbertura = comando.CreateParameter();
                    dataAbertura.ParameterName = "@dataAbertura";
                    dataAbertura.Value = chamados.dataAbertura;
                    comando.Parameters.Add(dataAbertura);


                    conexao.Open();
                    comando.CommandText = @"UPDATE tb_chamados SET titulo = @titulo, descricao = @descricao, equipamento = @equipamento, dataAbertura = @dataAbertura WHERE id = @id";

                    var linhas = comando.ExecuteNonQuery();
                }
            }
        }
        public DataTable ListarDados(string provider, string stringConexao, Chamados chamados)

        {
            factory = DbProviderFactories.GetFactory(provider);
            using (var conexao = factory.CreateConnection())
            {

                conexao.ConnectionString = stringConexao;
                using (var comando = factory.CreateCommand())
                {
                    comando.Connection = conexao;
                    conexao.Open();
                    comando.CommandText = @" SELECT Id AS id, titulo AS Titulo, equipamento AS Equipamento, dataAbertura AS DataAbertura, DATEDIFF ( NOW(), dataABertura)AS DiasAbertos from TB_CHAMADOS";


                    var sdr = comando.ExecuteReader();
                    DataTable linhas = new DataTable();
                    linhas.Load(sdr);
                    return linhas;
                }
            }
        }

        public DataTable SelecionarLinha(string provider, string stringConexao, Chamados chamados)
        {
            factory = DbProviderFactories.GetFactory(provider);
            using (var conexao = factory.CreateConnection())
            {
                conexao.ConnectionString = stringConexao;
                using (var comando = factory.CreateCommand())
                {
                    comando.Connection = conexao;
                    var idChamado = comando.CreateParameter();

                    idChamado.ParameterName = "@id";
                    idChamado.Value = chamados.idChamado;
                    comando.Parameters.Add(idChamado);
                    conexao.Open();

                    comando.CommandText = @"SELECT id AS Id, titulo AS Titulo, descricao AS Descricao, equipamento AS Equipamento, dataAbertura AS DataAbertura FROM tb_chamados WHERE
                    Id = @id";

                    var sdr = comando.ExecuteReader();
                    DataTable linhas = new DataTable();
                    linhas.Load(sdr);
                    return linhas;
                }
            }
        }

        public void ExcluirChamados(string provider, string stringConexao, Chamados chamado)
        {
            factory = DbProviderFactories.GetFactory(provider);
            using (var conexao = factory.CreateConnection())
            {
                conexao.ConnectionString = stringConexao;
                using (var comando = factory.CreateCommand())
                {
                    comando.Connection = conexao;

                    var id = comando.CreateParameter();
                    id.ParameterName = "@id";
                    id.Value = chamado.idChamado;
                    comando.Parameters.Add(id);

                    conexao.Open();
                    comando.CommandText = @"DELETE FROM tb_chamados WHERE id = @id";

                    var linhas = comando.ExecuteNonQuery();
                }
            }
        }
        public DataTable PesquisaPorNome(string provider, string stringConexao, Chamados chamados)

        {
            factory = DbProviderFactories.GetFactory(provider);
            using (var conexao = factory.CreateConnection())
            {
                conexao.ConnectionString = stringConexao;
                using (var comando = factory.CreateCommand())
                {

                    comando.Connection = conexao;

                    var nome = comando.CreateParameter();
                    nome.ParameterName = "@titulo";
                    nome.Value = "%" + chamados.titulo + "%";
                    comando.Parameters.Add(nome);
                    conexao.Open();
                    comando.CommandText = @"SELECT id AS Id, titulo AS Titulo, descricao AS Descricao, equipamento AS Equipamento, dataAbertura AS dataAbertura FROM tb_chamados WHERE
                    Titulo like @titulo";



                    var sdr = comando.ExecuteReader();
                    DataTable linhas = new DataTable();
                    linhas.Load(sdr);
                    return linhas;
                }
            }

        }
    }
}


    

