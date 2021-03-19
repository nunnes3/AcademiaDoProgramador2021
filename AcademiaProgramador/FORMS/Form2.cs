using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaProgramador.FORMS
{
    public partial class Form2 : Form
    {
        public MODEL.Equipamento equipamento;
        public MODEL.Chamados chamados;
        public readonly MODEL.ChamadosDAO chamadosDAO;

        public Form2()
        {
            equipamento = new MODEL.Equipamento();
            chamadosDAO = new MODEL.ChamadosDAO();
            InitializeComponent();

            AtualizarTabela();

        }

        public void LimpaCampos()
        {
            textBoxId.Text = "";
            textBoxTitulo.Text = "";
            textBoxDescricao.Text = "";
            comboBoxEquipamento.Text = "";
            maskedTextBoxAbertura.Text = "";
        }

        public void DesativarBotoes()
        {
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        public void AtivarBotoes()
        {
            btnEditar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = false;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            chamados = new MODEL.Chamados();


            chamados.titulo = textBoxTitulo.Text;
            chamados.descricao = textBoxDescricao.Text;
            chamados.equipamento = comboBoxEquipamento.Text;
            chamados.dataAbertura = Convert.ToDateTime(maskedTextBoxAbertura.Text);

            try
            {

                chamadosDAO.CadastrarChamados("MySql.Data.MySqlClient", "Server=localhost;port=3306;Database=academia_db;Uid=root;Pwd=teste;", chamados);
                MessageBox.Show("Dados inseridos com sucesso!");
                AtualizarTabela();
                LimpaCampos();
                DesativarBotoes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTabela()
        {
            chamados = new MODEL.Chamados();

            try
            {

                DataTable linhas = chamadosDAO.ListarDados("MySql.Data.MySqlClient", "Server=localhost;port=3306;Database=academia_db;Uid=root;Pwd=teste;", chamados);


                dataGridViewChamados.AutoGenerateColumns = true;
                dataGridViewChamados.DataSource = linhas;
                dataGridViewChamados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaSolo(int id)
        {
            chamados = new MODEL.Chamados();
            chamados.idChamado = id;
            try
            {

                DataTable linhas = chamadosDAO.SelecionarLinha("MySql.Data.MySqlClient", "Server=localhost;port=3306;Database=academia_db;Uid=root;Pwd=teste;", chamados);


                foreach (DataRow row in linhas.Rows)
                {
                    textBoxId.Text = row[0].ToString();
                    textBoxTitulo.Text = row[1].ToString();
                    textBoxDescricao.Text = row[2].ToString();
                    comboBoxEquipamento.Text = row[3].ToString();
                    maskedTextBoxAbertura.Text = row[4].ToString();
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBoxEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                {
                    try
                    {
                        MySqlConnection connection = new MySqlConnection("Server = localhost; port = 3306; Database = academia_db; Uid = root; Pwd = teste; ");

                        string selectQuery = "SELECT id, nome FROM tb_equipamento;";
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(selectQuery, connection);
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {

                        comboBoxEquipamento.Items.Add(reader.GetString("id") +" - " + reader.GetString("nome"));
                        
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        private void dataGridViewChamados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewChamados.SelectedCells.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridViewChamados.Rows[dataGridViewChamados.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizarTelaSolo(id);
                textBoxTitulo.Focus();
                btnNovo.Enabled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            chamados = new MODEL.Chamados
            {
                idChamado = Convert.ToInt32(textBoxId.Text),
                titulo = textBoxTitulo.Text,
                descricao = textBoxDescricao.Text,
                equipamento = comboBoxEquipamento.Text,
                dataAbertura = Convert.ToDateTime(maskedTextBoxAbertura.Text),

            };

            try
            {
                chamadosDAO.EditarChamados("MySql.Data.MySqlClient", "Server=localhost;port=3306;Database=academia_db;Uid=root;Pwd=teste;", chamados);

               

                MessageBox.Show(" Dados Editados com Sucesso !");

                AtualizarTabela();
                DesativarBotoes();
                LimpaCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                chamadosDAO.ExcluirChamados("MySql.Data.MySqlClient", "Server=localhost;port=3306;Database=academia_db;Uid=root;Pwd=teste;", chamados);

                MessageBox.Show(" Chamado Excluido com Sucesso !");

                AtualizarTabela();
                DesativarBotoes();
                LimpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            AtivarBotoes();
            LimpaCampos();
        }

        private void dataGridViewChamados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {

                chamados = new MODEL.Chamados
                {

                    titulo = textBoxTituloParaBusca.Text
                };
                try
                {

                    DataTable linhas = chamadosDAO.PesquisaPorNome("MySql.Data.MySqlClient", "Server=localhost;port=3306;Database=academia_db;Uid=root;Pwd=teste;", chamados); ;


                    dataGridViewChamados.AutoGenerateColumns = true;
                    dataGridViewChamados.DataSource = linhas;
                    dataGridViewChamados.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
  }


 

    
