using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProgramador.MODEL
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NSerie { get; set; }
        public string Fabricante { get; set; }
        public DateTime dataFabricacao { get; set; }
        public double preco { get; set; }

    }

    public class EquipamentoDAO
    {
        private DbProviderFactory factory;

        public EquipamentoDAO()
        {

        }

        public void CadastrarEquipamentos(string provider, string stringConexao, Equipamento equipamento)
        {
            factory = DbProviderFactories.GetFactory(provider);
            using (var conexao = factory.CreateConnection())
            {
                conexao.ConnectionString = stringConexao;
                using (var comando = factory.CreateCommand())
                {


                    comando.Connection = conexao;


                  

                    var nome = comando.CreateParameter();
                    nome.ParameterName = "@nome";
                    nome.Value = equipamento.Nome;
                    comando.Parameters.Add(nome);



                    var numeroSerie = comando.CreateParameter();
                    numeroSerie.ParameterName = "@numeroSerie";
                    numeroSerie.Value = equipamento.NSerie;
                    comando.Parameters.Add(numeroSerie);

                    var fabricante = comando.CreateParameter();
                    fabricante.ParameterName = "@fabricante";
                    fabricante.Value = equipamento.Fabricante;
                    comando.Parameters.Add(fabricante);


                    var dataFabricao = comando.CreateParameter();
                    dataFabricao.ParameterName = "@dataFabricacao";
                    dataFabricao.Value = equipamento.dataFabricacao;
                    comando.Parameters.Add(dataFabricao);


                    var preco = comando.CreateParameter();
                    preco.ParameterName = "@preco";
                    preco.Value = equipamento.preco;
                    comando.Parameters.Add(preco);

                    conexao.Open();
                    comando.CommandText = @"INSERT INTO tb_equipamento(nome, numeroSerie, fabricante, dataFabricacao, preco)
                    VALUES (@nome, @numeroSerie, @fabricante, @dataFabricacao, @preco)";

                    var linhas = comando.ExecuteNonQuery();
                }
            }
        }

        public DataTable ListarDados(string provider, string stringConexao, Equipamento equipamento)

        {
            factory = DbProviderFactories.GetFactory(provider);
            using (var conexao = factory.CreateConnection()) 
            {
                
                conexao.ConnectionString = stringConexao;
                using (var comando = factory.CreateCommand()) 
                {
                    comando.Connection = conexao; 
                    conexao.Open();
                    comando.CommandText = @" SELECT id AS id, nome AS Nome, numeroSerie AS NSerie, fabricante AS Fabricante FROM tb_equipamento ";

                    
                    var sdr = comando.ExecuteReader();
                    DataTable linhas = new DataTable();
                    linhas.Load(sdr);
                    return linhas;
                }
            } 
        }
        public DataTable SelecionarLinha(string provider, string stringConexao, Equipamento equipamento)
        {
            factory = DbProviderFactories.GetFactory(provider);
            using (var conexao = factory.CreateConnection()) 
            {
                conexao.ConnectionString = stringConexao;
                using (var comando = factory.CreateCommand()) 
                {
                    comando.Connection = conexao;
                    var idEquipamento = comando.CreateParameter();

                    idEquipamento.ParameterName = "@id";
                    idEquipamento.Value = equipamento.Id;
                    comando.Parameters.Add(idEquipamento);
                    conexao.Open();
                    
                    comando.CommandText = @"SELECT id AS Id, nome AS Nome, numeroSerie AS NSerie, fabricante AS Fabricante, dataFabricacao AS dataFabricacao, preco AS preco FROM tb_equipamento WHERE
                    Id = @id";

                    var sdr = comando.ExecuteReader();
                    DataTable linhas = new DataTable();
                    linhas.Load(sdr);
                    return linhas;
                }
            } 
        }

        public void EditarEquipamento(string provider, string stringConexao, Equipamento equipamento)
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
                    id.Value = equipamento.Id;
                    comando.Parameters.Add(id);

                    var nome = comando.CreateParameter();
                    nome.ParameterName = "@nome";
                    nome.Value = equipamento.Nome;
                    comando.Parameters.Add(nome);


                    var numeroSerie = comando.CreateParameter();
                    numeroSerie.ParameterName = "@numeroSerie";
                    numeroSerie.Value = equipamento.NSerie;
                    comando.Parameters.Add(numeroSerie);

                    var fabricante = comando.CreateParameter();
                    fabricante.ParameterName = "@fabricante";
                    fabricante.Value = equipamento.Fabricante;
                    comando.Parameters.Add(fabricante);


                    var dataFabricao = comando.CreateParameter();
                    dataFabricao.ParameterName = "@dataFabricacao";
                    dataFabricao.Value = equipamento.dataFabricacao;
                    comando.Parameters.Add(dataFabricao);


                    var preco = comando.CreateParameter();
                    preco.ParameterName = "@preco";
                    preco.Value = equipamento.preco;
                    comando.Parameters.Add(preco);
                    conexao.Open();
                    comando.CommandText = @"UPDATE tb_equipamento SET nome = @nome, numeroSerie = @numeroSerie, fabricante = @fabricante, dataFabricacao = @dataFabricacao, preco = @preco WHERE id = @id";

                    var linhas = comando.ExecuteNonQuery();
                }
            } 
        }
        public void ExcluirEquipamento(string provider, string stringConexao, Equipamento equipamento)
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
                    id.Value = equipamento.Id;
                    comando.Parameters.Add(id);

                    conexao.Open();
                    comando.CommandText = @"DELETE FROM tb_equipamento WHERE id = @id";

                    var linhas = comando.ExecuteNonQuery();
                }
            }
        }

        public DataTable PesquisaPorNome(string provider, string stringConexao, Equipamento equipamento)

        {
            factory = DbProviderFactories.GetFactory(provider);
            using (var conexao = factory.CreateConnection()) 
            {
                conexao.ConnectionString = stringConexao;
                using (var comando = factory.CreateCommand()) 
                {
                    
                    comando.Connection = conexao;
                    
                    var nome = comando.CreateParameter();
                    nome.ParameterName = "@nome";
                    nome.Value = "%" + equipamento.Nome + "%";
                    comando.Parameters.Add(nome);
                    conexao.Open();
                    comando.CommandText = @"SELECT id AS Id, nome AS Nome, numeroSerie AS NSerie, fabricante AS Fabricante, dataFabricacao AS dataFabricacao, preco AS preco FROM tb_equipamento WHERE
                    Nome like @nome";



                    var sdr = comando.ExecuteReader();
                    DataTable linhas = new DataTable();
                    linhas.Load(sdr);
                    return linhas;
                }
            } 
        }
    }
}

