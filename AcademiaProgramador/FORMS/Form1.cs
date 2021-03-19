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
    public partial class Form1 : Form
    {

        public MODEL.Equipamento equipamento;
        public readonly MODEL.EquipamentoDAO daoEquipamento;

        public Form1()
        {

            daoEquipamento = new MODEL.EquipamentoDAO();
            InitializeComponent();
            AtualizarTabela();
        }

        public void LimpaCampos()
        {
            textBoxIdEquipamento.Text = "";
            textBoxNomeEquipamento.Text = "";
            textBoxNumeroSerieEquipamento.Text = "";
            textBoxFabricanteEquipamento.Text = "";
            maskedTextBoxDataFabricacao.Text = "";
            textBoxPrecoEquipamento.Text = "";

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


        private void AtualizarTabela()
        {
            equipamento = new MODEL.Equipamento();

            try
            {
                
                DataTable linhas = daoEquipamento.ListarDados("MySql.Data.MySqlClient", "Server=localhost;port=3306;Database=academia_db;Uid=root;Pwd=teste;", equipamento);


                dataGridEquipamento.AutoGenerateColumns = true;
                dataGridEquipamento.DataSource = linhas;
                dataGridEquipamento.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaSolo(int id)
        {
            equipamento = new MODEL.Equipamento();
            equipamento.Id = id;
            try
            {
            
                DataTable linhas = daoEquipamento.SelecionarLinha("MySql.Data.MySqlClient", "Server=localhost;port=3306;Database=academia_db;Uid=root;Pwd=teste;", equipamento);


                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIdEquipamento.Text = row[0].ToString();
                    textBoxNomeEquipamento.Text = row[1].ToString();
                    textBoxNumeroSerieEquipamento.Text = row[2].ToString();
                    textBoxFabricanteEquipamento.Text = row[3].ToString();
                    maskedTextBoxDataFabricacao.Text = row[4].ToString();
                    textBoxPrecoEquipamento.Text = row[5].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            equipamento = new MODEL.Equipamento();

            if (textBoxNomeEquipamento.Text.Length > 5) 
            {
                

                equipamento.Nome = textBoxNomeEquipamento.Text;
                equipamento.NSerie = Convert.ToInt32(textBoxNumeroSerieEquipamento.Text);
                equipamento.Fabricante = textBoxFabricanteEquipamento.Text;
                equipamento.dataFabricacao.ToString("mm/dd/YYYY");
                equipamento.dataFabricacao = Convert.ToDateTime(maskedTextBoxDataFabricacao.Text);
                equipamento.preco = Convert.ToDouble(textBoxPrecoEquipamento.Text);

                try
                {
                    daoEquipamento.CadastrarEquipamentos("MySql.Data.MySqlClient", "Server=localhost;port=3306;Database=academia_db;Uid=root;Pwd=teste;", equipamento);
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
            else
            {
                
                MessageBox.Show("Informe pelo menos 6 caracteres");

            }
            
           

        }


        private void dataGridEquipamento_DoubleClick(object sender, EventArgs e)
        {
            
                if (dataGridEquipamento.SelectedCells.Count > 0)
                {
           
                    DataGridViewRow selectedRow = dataGridEquipamento.Rows[dataGridEquipamento.SelectedCells[0].RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    AtualizarTelaSolo(id);
                    textBoxNome.Focus();
                    btnNovo.Enabled = true;
                }
            
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            equipamento = new MODEL.Equipamento
            {
                Id = Convert.ToInt32(textBoxIdEquipamento.Text),
                Nome = textBoxNomeEquipamento.Text,
                NSerie = Convert.ToInt32(textBoxNumeroSerieEquipamento.Text),
                Fabricante = textBoxFabricanteEquipamento.Text,
                dataFabricacao = Convert.ToDateTime(maskedTextBoxDataFabricacao.Text),
                preco = Convert.ToDouble(textBoxPrecoEquipamento.Text)

            };

            try
            {
                daoEquipamento.EditarEquipamento("MySql.Data.MySqlClient", "Server=localhost;port=3306;Database=academia_db;Uid=root;Pwd=teste;", equipamento);

                AtualizarTabela();

                MessageBox.Show(" Dados Editados com Sucesso !");

                LimpaCampos();
                DesativarBotoes();
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
                daoEquipamento.ExcluirEquipamento("MySql.Data.MySqlClient", "Server=localhost;port=3306;Database=academia_db;Uid=root;Pwd=teste;", equipamento);

                AtualizarTabela();

                MessageBox.Show(" Equipamento Excluido com Sucesso !");

                LimpaCampos();
                DesativarBotoes();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                
                equipamento = new MODEL.Equipamento
                {
                    
                    Nome = textBoxPesquisaNome.Text
                };
                try
                {
                    
                    DataTable linhas = daoEquipamento.PesquisaPorNome("MySql.Data.MySqlClient", "Server=localhost;port=3306;Database=academia_db;Uid=root;Pwd=teste;", equipamento); ;


                    dataGridEquipamento.AutoGenerateColumns = true;
                    dataGridEquipamento.DataSource = linhas;
                    dataGridEquipamento.Refresh();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumeroSerie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDatafabricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }
    }
}
