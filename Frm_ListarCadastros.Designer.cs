﻿namespace JanelasMDI
{
    partial class Frm_ListarCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListarCadastros));
            this.dtListarCadastros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.picSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtListarCadastros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListarCadastros
            // 
            this.dtListarCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListarCadastros.Location = new System.Drawing.Point(-3, -3);
            this.dtListarCadastros.Name = "dtListarCadastros";
            this.dtListarCadastros.Size = new System.Drawing.Size(806, 363);
            this.dtListarCadastros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // picSair
            // 
            this.picSair.BackColor = System.Drawing.Color.White;
            this.picSair.Image = ((System.Drawing.Image)(resources.GetObject("picSair.Image")));
            this.picSair.Location = new System.Drawing.Point(12, 393);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(34, 31);
            this.picSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSair.TabIndex = 131;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // Frm_ListarCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.picSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtListarCadastros);
            this.Name = "Frm_ListarCadastros";
            this.Text = "Listar Cadastros";
            ((System.ComponentModel.ISupportInitialize)(this.dtListarCadastros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListarCadastros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSair;
    }
}