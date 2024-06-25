namespace JanelasMDI
{
    partial class Frm_Ajuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ajuda));
            this.cbEscolha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbEscolha
            // 
            this.cbEscolha.FormattingEnabled = true;
            this.cbEscolha.Items.AddRange(new object[] {
            "Formulário de Cadastro de Alunos",
            "Formulário de Cadastro de Clientes",
            "Formulário de Cadastro de Usuários",
            "Formulário de Busca de Alunos",
            "Formulário de Busca de Clientes",
            "Formulário de Listagem de Alunos",
            "Formulário de Listagem de Clientes",
            "Formulário de Listagem de Usuários",
            "Formulário de escolha Principal"});
            this.cbEscolha.Location = new System.Drawing.Point(118, 44);
            this.cbEscolha.Name = "cbEscolha";
            this.cbEscolha.Size = new System.Drawing.Size(362, 21);
            this.cbEscolha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(115, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o formulário na qual precisa de ajuda:";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(503, 42);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(101, 23);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ajuda:";
            // 
            // Frm_Ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEscolha);
            this.Name = "Frm_Ajuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuda ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEscolha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label label2;
    }
}