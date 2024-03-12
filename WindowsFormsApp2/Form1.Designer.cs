namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.labelMedico = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPaciente = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-8, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.buttonSair);
            this.tabPage1.Controls.Add(this.buttonLimpar);
            this.tabPage1.Controls.Add(this.buttonAdicionar);
            this.tabPage1.Controls.Add(this.textBoxPaciente);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelMedico);
            this.tabPage1.Controls.Add(this.labelPaciente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonApagar);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPaciente,
            this.ColumnMedico,
            this.ColumnAgendamento});
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnPaciente
            // 
            this.ColumnPaciente.HeaderText = "Paciente";
            this.ColumnPaciente.Name = "ColumnPaciente";
            this.ColumnPaciente.Width = 300;
            // 
            // ColumnMedico
            // 
            this.ColumnMedico.HeaderText = "Médico";
            this.ColumnMedico.Name = "ColumnMedico";
            this.ColumnMedico.Width = 300;
            // 
            // ColumnAgendamento
            // 
            this.ColumnAgendamento.HeaderText = "Agendamento";
            this.ColumnAgendamento.Name = "ColumnAgendamento";
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(67, 39);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(55, 13);
            this.labelPaciente.TabIndex = 0;
            this.labelPaciente.Text = "Paaciente";
            // 
            // labelMedico
            // 
            this.labelMedico.AutoSize = true;
            this.labelMedico.Location = new System.Drawing.Point(67, 103);
            this.labelMedico.Name = "labelMedico";
            this.labelMedico.Size = new System.Drawing.Size(42, 13);
            this.labelMedico.TabIndex = 1;
            this.labelMedico.Text = "Médico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // textBoxPaciente
            // 
            this.textBoxPaciente.Location = new System.Drawing.Point(166, 32);
            this.textBoxPaciente.Name = "textBoxPaciente";
            this.textBoxPaciente.Size = new System.Drawing.Size(181, 20);
            this.textBoxPaciente.TabIndex = 3;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(122, 328);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 4;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(383, 328);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 5;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(626, 328);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(449, 320);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dra. Ana Julia",
            "Dr. Luiz Alberto"});
            this.comboBox1.Location = new System.Drawing.Point(166, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAgendamento;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.TextBox textBoxPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMedico;
        private System.Windows.Forms.Label labelPaciente;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

