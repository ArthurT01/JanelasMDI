namespace JanelasMDI
{
    partial class Frm_BuscarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarAluno));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mktCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.mktCpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.mktTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.mkdDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mkdDDD = new System.Windows.Forms.MaskedTextBox();
            this.cbTipoBusca = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mktBusca = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mktDddCliente = new System.Windows.Forms.MaskedTextBox();
            this.mktTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(472, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(472, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "E-mail:";
            // 
            // mktCpfCliente
            // 
            this.mktCpfCliente.Location = new System.Drawing.Point(572, 159);
            this.mktCpfCliente.Mask = "000.000.000-00";
            this.mktCpfCliente.Name = "mktCpfCliente";
            this.mktCpfCliente.ReadOnly = true;
            this.mktCpfCliente.Size = new System.Drawing.Size(100, 20);
            this.mktCpfCliente.TabIndex = 11;
            // 
            // mktCpfAluno
            // 
            this.mktCpfAluno.Location = new System.Drawing.Point(472, 159);
            this.mktCpfAluno.Mask = "000.000.000-00";
            this.mktCpfAluno.Name = "mktCpfAluno";
            this.mktCpfAluno.ReadOnly = true;
            this.mktCpfAluno.Size = new System.Drawing.Size(94, 20);
            this.mktCpfAluno.TabIndex = 10;
            // 
            // mktTelefone
            // 
            this.mktTelefone.Location = new System.Drawing.Point(273, 206);
            this.mktTelefone.Mask = "00000-0000";
            this.mktTelefone.Name = "mktTelefone";
            this.mktTelefone.ReadOnly = true;
            this.mktTelefone.Size = new System.Drawing.Size(73, 20);
            this.mktTelefone.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(246, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(246, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nome Completo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(246, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Código do Aluno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(352, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(341, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Gênero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(572, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "CPF do Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(472, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "CPF do Aluno:";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(341, 106);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(118, 20);
            this.txtSexo.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(246, 159);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(246, 106);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(85, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // mkdDataNascimento
            // 
            this.mkdDataNascimento.Location = new System.Drawing.Point(352, 206);
            this.mkdDataNascimento.Mask = "00/00/0000";
            this.mkdDataNascimento.Name = "mkdDataNascimento";
            this.mkdDataNascimento.ReadOnly = true;
            this.mkdDataNascimento.Size = new System.Drawing.Size(107, 20);
            this.mkdDataNascimento.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Azure;
            this.btnBuscar.Location = new System.Drawing.Point(572, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mkdDDD
            // 
            this.mkdDDD.Location = new System.Drawing.Point(246, 206);
            this.mkdDDD.Mask = "(00)";
            this.mkdDDD.Name = "mkdDDD";
            this.mkdDDD.ReadOnly = true;
            this.mkdDDD.Size = new System.Drawing.Size(25, 20);
            this.mkdDDD.TabIndex = 6;
            // 
            // cbTipoBusca
            // 
            this.cbTipoBusca.FormattingEnabled = true;
            this.cbTipoBusca.Items.AddRange(new object[] {
            "CÓDIGO ALUNO",
            "CÓDIGO CLIENTE",
            "CPF ALUNO",
            "CPF CLIENTE"});
            this.cbTipoBusca.Location = new System.Drawing.Point(246, 32);
            this.cbTipoBusca.Name = "cbTipoBusca";
            this.cbTipoBusca.Size = new System.Drawing.Size(121, 21);
            this.cbTipoBusca.TabIndex = 0;
            this.cbTipoBusca.SelectedIndexChanged += new System.EventHandler(this.cbTipoBusca_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(243, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Tipo da Busca:";
            // 
            // mktBusca
            // 
            this.mktBusca.Location = new System.Drawing.Point(394, 32);
            this.mktBusca.Name = "mktBusca";
            this.mktBusca.Size = new System.Drawing.Size(144, 20);
            this.mktBusca.TabIndex = 1;
            this.mktBusca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mktBusca_MaskInputRejected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(391, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "Busca:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(246, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 96;
            this.label11.Text = "Nome do responsável:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(246, 250);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(200, 20);
            this.txtNomeCliente.TabIndex = 97;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(472, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 99;
            this.label13.Text = "Telefone:";
            // 
            // mktDddCliente
            // 
            this.mktDddCliente.Location = new System.Drawing.Point(472, 250);
            this.mktDddCliente.Mask = "(00)";
            this.mktDddCliente.Name = "mktDddCliente";
            this.mktDddCliente.ReadOnly = true;
            this.mktDddCliente.Size = new System.Drawing.Size(25, 20);
            this.mktDddCliente.TabIndex = 100;
            // 
            // mktTelefoneCliente
            // 
            this.mktTelefoneCliente.Location = new System.Drawing.Point(499, 250);
            this.mktTelefoneCliente.Mask = "00000-0000";
            this.mktTelefoneCliente.Name = "mktTelefoneCliente";
            this.mktTelefoneCliente.ReadOnly = true;
            this.mktTelefoneCliente.Size = new System.Drawing.Size(94, 20);
            this.mktTelefoneCliente.TabIndex = 101;
            // 
            // Frm_BuscarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(691, 301);
            this.Controls.Add(this.mktTelefoneCliente);
            this.Controls.Add(this.mktDddCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mktBusca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbTipoBusca);
            this.Controls.Add(this.mkdDDD);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mkdDataNascimento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mktCpfCliente);
            this.Controls.Add(this.mktCpfAluno);
            this.Controls.Add(this.mktTelefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Frm_BuscarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de Alunos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_BuscarAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mktCpfCliente;
        private System.Windows.Forms.MaskedTextBox mktCpfAluno;
        private System.Windows.Forms.MaskedTextBox mktTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox mkdDataNascimento;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mkdDDD;
        private System.Windows.Forms.ComboBox cbTipoBusca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mktBusca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mktDddCliente;
        private System.Windows.Forms.MaskedTextBox mktTelefoneCliente;
    }
}