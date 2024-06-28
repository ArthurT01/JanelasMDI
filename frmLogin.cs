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
using MySql.Data.MySqlClient;

namespace JanelasMDI
{
    public partial class frmLogin : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQL;
        public string tipo;
        string valorCriptografado;

        public frmLogin()
        {
            InitializeComponent();
        }

         
        //BOTÕES 
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            CriptografaDados();
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_usuarios WHERE nomeUsuario = @nomeUsuario AND senhaUsuario = @senhaUsuario";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@nomeUsuario", txtLogin.Text);
                comando.Parameters.AddWithValue("@senhaUsuario", valorCriptografado);

                conexao.Open();

                dr = comando.ExecuteReader();
                
                if(dr.HasRows)
                {
                    string nome = " ";
                    string tipo = " ";
                    while (dr.Read())
                    {                    
                        tipo = Convert.ToString(dr["cargo"]);
                        nome = Convert.ToString(dr["nomeUsuario"]);

                    }
                    Frm_Principal Menu = new Frm_Principal(tipo, nome);
                    Menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Senha ou Login de usuário incorreto ou inexistênte");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //CRIPTOGRAFIA DE SENHA
        public void CriptografaDados()
        {
            Criptografia c = new Criptografia(SHA512.Create());

            valorCriptografado = c.CriptografarSenha(txtSenha.Text);

        }



        //EXIBIR SENHA
        private void chkExibirSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != "Digite sua senha")
            {
                if (chkExibirSenha.Checked)
                {
                    txtSenha.PasswordChar = default;
                }
                else
                {
                    txtSenha.PasswordChar = '*';
                }
            }
        }
        


        //NÃO ESTÁ EM USO
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


    }

}
