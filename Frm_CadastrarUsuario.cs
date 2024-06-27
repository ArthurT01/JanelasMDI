using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanelasMDI
{
    public partial class Frm_CadastrarUsuario : Form
    {
        string valorCriptografado;
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public string tipo;

        public Frm_CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void Frm_CadastrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                CriptografaDados();
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "INSERT INTO t_usuarios (nomeUsuario, senhaUsuario, cargo) VALUES (@nomeUsuario, @senhaUsuario, @cargo)";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@nomeUsuario", txtNomeUsuário.Text);
                comando.Parameters.AddWithValue("@senhaUsuario", valorCriptografado);
                comando.Parameters.AddWithValue("@cargo", cbCargo.Text);
                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro Efetuado!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void CriptografaDados()
        {
            Criptografia c = new Criptografia(SHA512.Create());

            valorCriptografado = c.CriptografarSenha(txtSenha.Text);
           
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
