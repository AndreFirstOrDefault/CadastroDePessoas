namespace CadastroDePessoas
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNomeCompleto = new TextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxTipoEndereco = new ComboBox();
            label3 = new Label();
            textBoxLogradouro = new TextBox();
            textBoxNumeroEndereco = new TextBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            maskedTextBoxCep = new MaskedTextBox();
            textBoxBairro = new TextBox();
            textBoxCidade = new TextBox();
            comboBoxEstado = new ComboBox();
            label4 = new Label();
            maskedTextBoxTelefone = new MaskedTextBox();
            label6 = new Label();
            textBoxEmail = new TextBox();
            buttonSalvar = new Button();
            label7 = new Label();
            label8 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label9 = new Label();
            label10 = new Label();
            buttonConsultar = new Button();
            buttonDeletar = new Button();
            dataGridView1 = new DataGridView();
            labelBemVindo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxNomeCompleto
            // 
            textBoxNomeCompleto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNomeCompleto.Location = new Point(121, 12);
            textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            textBoxNomeCompleto.PlaceholderText = "Digite o nome completo";
            textBoxNomeCompleto.Size = new Size(370, 26);
            textBoxNomeCompleto.TabIndex = 0;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxCpf.Location = new Point(637, 12);
            maskedTextBoxCpf.Mask = "000,000,000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(193, 26);
            maskedTextBoxCpf.TabIndex = 1;
            maskedTextBoxCpf.TextMaskFormat = MaskFormat.IncludePrompt;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(519, 15);
            label1.Name = "label1";
            label1.Size = new Size(100, 18);
            label1.TabIndex = 2;
            label1.Text = "Digite o CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(117, 119);
            label2.Name = "label2";
            label2.Size = new Size(0, 18);
            label2.TabIndex = 3;
            // 
            // comboBoxTipoEndereco
            // 
            comboBoxTipoEndereco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTipoEndereco.FormattingEnabled = true;
            comboBoxTipoEndereco.Items.AddRange(new object[] { "Rua", "Avenida", "Travessa", "Praça", "Alameda", "Estrada" });
            comboBoxTipoEndereco.Location = new Point(98, 59);
            comboBoxTipoEndereco.Name = "comboBoxTipoEndereco";
            comboBoxTipoEndereco.Size = new Size(100, 26);
            comboBoxTipoEndereco.TabIndex = 4;
            comboBoxTipoEndereco.Text = "Selecione";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(76, 18);
            label3.TabIndex = 5;
            label3.Text = "Endereço";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogradouro.Location = new Point(219, 59);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.PlaceholderText = "Logradouro";
            textBoxLogradouro.Size = new Size(302, 26);
            textBoxLogradouro.TabIndex = 6;
            // 
            // textBoxNumeroEndereco
            // 
            textBoxNumeroEndereco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumeroEndereco.Location = new Point(561, 59);
            textBoxNumeroEndereco.Name = "textBoxNumeroEndereco";
            textBoxNumeroEndereco.PlaceholderText = "Número";
            textBoxNumeroEndereco.Size = new Size(94, 26);
            textBoxNumeroEndereco.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(660, 64);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Sem número";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 114);
            label5.Name = "label5";
            label5.Size = new Size(42, 18);
            label5.TabIndex = 10;
            label5.Text = "CEP";
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxCep.Location = new Point(69, 111);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(125, 26);
            maskedTextBoxCep.TabIndex = 11;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBairro.Location = new Point(219, 114);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.PlaceholderText = "Bairro";
            textBoxBairro.Size = new Size(167, 26);
            textBoxBairro.TabIndex = 12;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCidade.Location = new Point(404, 114);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.PlaceholderText = "Cidade";
            textBoxCidade.Size = new Size(117, 26);
            textBoxCidade.TabIndex = 13;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxEstado.ForeColor = SystemColors.WindowText;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxEstado.Location = new Point(561, 117);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(193, 26);
            comboBoxEstado.TabIndex = 14;
            comboBoxEstado.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 168);
            label4.Name = "label4";
            label4.Size = new Size(66, 18);
            label4.TabIndex = 15;
            label4.Text = "Telefone";
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxTelefone.Location = new Point(98, 162);
            maskedTextBoxTelefone.Mask = "(00)00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(165, 26);
            maskedTextBoxTelefone.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(269, 163);
            label6.Name = "label6";
            label6.Size = new Size(0, 18);
            label6.TabIndex = 18;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(282, 165);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "E-mail";
            textBoxEmail.Size = new Size(239, 26);
            textBoxEmail.TabIndex = 19;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = SystemColors.Highlight;
            buttonSalvar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = SystemColors.Window;
            buttonSalvar.Location = new Point(561, 162);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(193, 29);
            buttonSalvar.TabIndex = 20;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 228);
            label7.Name = "label7";
            label7.Size = new Size(146, 19);
            label7.TabIndex = 21;
            label7.Text = "Consultar/ Deletar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(84, 19);
            label8.TabIndex = 22;
            label8.Text = "Cadastrar";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(289, 221);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(180, 26);
            maskedTextBox1.TabIndex = 24;
            maskedTextBox1.TextMaskFormat = MaskFormat.IncludePrompt;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(183, 229);
            label9.Name = "label9";
            label9.Size = new Size(100, 18);
            label9.TabIndex = 25;
            label9.Text = "Digite o CPF";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(168, 310);
            label10.Name = "label10";
            label10.Size = new Size(0, 18);
            label10.TabIndex = 26;
            // 
            // buttonConsultar
            // 
            buttonConsultar.BackColor = Color.ForestGreen;
            buttonConsultar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsultar.ForeColor = SystemColors.Window;
            buttonConsultar.Location = new Point(486, 218);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(169, 30);
            buttonConsultar.TabIndex = 28;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = false;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // buttonDeletar
            // 
            buttonDeletar.BackColor = Color.Red;
            buttonDeletar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeletar.ForeColor = SystemColors.Window;
            buttonDeletar.Location = new Point(661, 217);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(100, 30);
            buttonDeletar.TabIndex = 29;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseVisualStyleBackColor = false;
            buttonDeletar.Click += this.buttonDeletar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(849, 173);
            dataGridView1.TabIndex = 30;
            dataGridView1.Visible = false;
            // 
            // labelBemVindo
            // 
            labelBemVindo.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelBemVindo.Location = new Point(12, 267);
            labelBemVindo.Name = "labelBemVindo";
            labelBemVindo.Size = new Size(849, 173);
            labelBemVindo.TabIndex = 31;
            labelBemVindo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(875, 449);
            Controls.Add(labelBemVindo);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDeletar);
            Controls.Add(buttonConsultar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(maskedTextBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxEmail);
            Controls.Add(label6);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(label4);
            Controls.Add(comboBoxEstado);
            Controls.Add(textBoxCidade);
            Controls.Add(textBoxBairro);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(textBoxNumeroEndereco);
            Controls.Add(textBoxLogradouro);
            Controls.Add(label3);
            Controls.Add(comboBoxTipoEndereco);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(textBoxNomeCompleto);
            Name = "TelaPrincipal";
            Text = "Cadastro de Pessoas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNomeCompleto;
        private MaskedTextBox maskedTextBoxCpf;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxTipoEndereco;
        private Label label3;
        private TextBox textBoxLogradouro;
        private TextBox textBoxNumeroEndereco;
        private CheckBox checkBox1;
        private Label label5;
        private MaskedTextBox maskedTextBoxCep;
        private TextBox textBoxBairro;
        private TextBox textBoxCidade;
        private ComboBox comboBoxEstado;
        private Label label4;
        private MaskedTextBox maskedTextBoxTelefone;
        private Label label6;
        private TextBox textBoxEmail;
        private Button buttonSalvar;
        private Label label7;
        private Label label8;
        private MaskedTextBox maskedTextBox1;
        private Label label9;
        private Label label10;
        private Button buttonConsultar;
        private Button buttonDeletar;
        private DataGridView dataGridView1;
        internal Label labelBemVindo;
    }
}