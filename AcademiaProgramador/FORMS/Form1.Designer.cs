
namespace AcademiaProgramador.FORMS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxFabricante = new System.Windows.Forms.TextBox();
            this.textBoxNumeroSerieEquipamento = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.dataGridEquipamento = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.textBoxPesquisaNome = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNomeEquipamento = new System.Windows.Forms.TextBox();
            this.textBoxFabricanteEquipamento = new System.Windows.Forms.TextBox();
            this.textBoxPrecoEquipamento = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxIdEquipamento = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDataFabricacao = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipamento";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(91, 181);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(193, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxFabricante
            // 
            this.textBoxFabricante.Location = new System.Drawing.Point(91, 244);
            this.textBoxFabricante.Name = "textBoxFabricante";
            this.textBoxFabricante.Size = new System.Drawing.Size(140, 22);
            this.textBoxFabricante.TabIndex = 2;
            // 
            // textBoxNumeroSerieEquipamento
            // 
            this.textBoxNumeroSerieEquipamento.Location = new System.Drawing.Point(515, 122);
            this.textBoxNumeroSerieEquipamento.Name = "textBoxNumeroSerieEquipamento";
            this.textBoxNumeroSerieEquipamento.Size = new System.Drawing.Size(142, 22);
            this.textBoxNumeroSerieEquipamento.TabIndex = 3;
            this.textBoxNumeroSerieEquipamento.TextChanged += new System.EventHandler(this.textBoxNumeroSerie_TextChanged);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(91, 303);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(140, 22);
            this.textBoxPreco.TabIndex = 5;
            // 
            // dataGridEquipamento
            // 
            this.dataGridEquipamento.AllowUserToAddRows = false;
            this.dataGridEquipamento.AllowUserToResizeColumns = false;
            this.dataGridEquipamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEquipamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEquipamento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridEquipamento.Location = new System.Drawing.Point(82, 389);
            this.dataGridEquipamento.MultiSelect = false;
            this.dataGridEquipamento.Name = "dataGridEquipamento";
            this.dataGridEquipamento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridEquipamento.RowTemplate.Height = 24;
            this.dataGridEquipamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEquipamento.Size = new System.Drawing.Size(640, 257);
            this.dataGridEquipamento.TabIndex = 6;
            this.dataGridEquipamento.DoubleClick += new System.EventHandler(this.dataGridEquipamento_DoubleClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(82, 673);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(127, 84);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(254, 673);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(127, 84);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(431, 673);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(127, 84);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(595, 673);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(127, 84);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // textBoxPesquisaNome
            // 
            this.textBoxPesquisaNome.Location = new System.Drawing.Point(82, 361);
            this.textBoxPesquisaNome.Name = "textBoxPesquisaNome";
            this.textBoxPesquisaNome.Size = new System.Drawing.Size(453, 22);
            this.textBoxPesquisaNome.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(541, 357);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(172, 31);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(91, 122);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(140, 22);
            this.textBoxId.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "lD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fabricante";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nº de Serie";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Preço";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Data Fabricação";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(29, 364);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(45, 17);
            this.Nome.TabIndex = 20;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(275, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "Equipamento";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxNomeEquipamento
            // 
            this.textBoxNomeEquipamento.Location = new System.Drawing.Point(91, 181);
            this.textBoxNomeEquipamento.Name = "textBoxNomeEquipamento";
            this.textBoxNomeEquipamento.Size = new System.Drawing.Size(193, 22);
            this.textBoxNomeEquipamento.TabIndex = 1;
            this.textBoxNomeEquipamento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxFabricanteEquipamento
            // 
            this.textBoxFabricanteEquipamento.Location = new System.Drawing.Point(91, 244);
            this.textBoxFabricanteEquipamento.Name = "textBoxFabricanteEquipamento";
            this.textBoxFabricanteEquipamento.Size = new System.Drawing.Size(140, 22);
            this.textBoxFabricanteEquipamento.TabIndex = 2;
            this.textBoxFabricanteEquipamento.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxPrecoEquipamento
            // 
            this.textBoxPrecoEquipamento.Location = new System.Drawing.Point(91, 303);
            this.textBoxPrecoEquipamento.Name = "textBoxPrecoEquipamento";
            this.textBoxPrecoEquipamento.Size = new System.Drawing.Size(140, 22);
            this.textBoxPrecoEquipamento.TabIndex = 5;
            this.textBoxPrecoEquipamento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 361);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(453, 22);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxIdEquipamento
            // 
            this.textBoxIdEquipamento.Enabled = false;
            this.textBoxIdEquipamento.Location = new System.Drawing.Point(91, 122);
            this.textBoxIdEquipamento.Name = "textBoxIdEquipamento";
            this.textBoxIdEquipamento.Size = new System.Drawing.Size(140, 22);
            this.textBoxIdEquipamento.TabIndex = 13;
            this.textBoxIdEquipamento.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // maskedTextBoxDataFabricacao
            // 
            this.maskedTextBoxDataFabricacao.Location = new System.Drawing.Point(515, 195);
            this.maskedTextBoxDataFabricacao.Mask = "00/00/0000";
            this.maskedTextBoxDataFabricacao.Name = "maskedTextBoxDataFabricacao";
            this.maskedTextBoxDataFabricacao.Size = new System.Drawing.Size(151, 22);
            this.maskedTextBoxDataFabricacao.TabIndex = 21;
            this.maskedTextBoxDataFabricacao.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(785, 762);
            this.Controls.Add(this.maskedTextBoxDataFabricacao);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdEquipamento);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxPesquisaNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridEquipamento);
            this.Controls.Add(this.textBoxPrecoEquipamento);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.textBoxNumeroSerieEquipamento);
            this.Controls.Add(this.textBoxFabricanteEquipamento);
            this.Controls.Add(this.textBoxFabricante);
            this.Controls.Add(this.textBoxNomeEquipamento);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Equipamentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxFabricante;
        private System.Windows.Forms.TextBox textBoxNumeroSerieEquipamento;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.DataGridView dataGridEquipamento;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox textBoxPesquisaNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNomeEquipamento;
        private System.Windows.Forms.TextBox textBoxFabricanteEquipamento;
        private System.Windows.Forms.TextBox textBoxPrecoEquipamento;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxIdEquipamento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataFabricacao;
    }
}