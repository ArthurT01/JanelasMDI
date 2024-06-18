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

namespace JanelasMDI
{
    public partial class Frm_CadastrarAluno : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        MySqlDataReader dr;

        public Frm_CadastrarAluno()
        {
            InitializeComponent();
        }

        private void Frm_AgendarConsulta_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "INSERT INTO t_alunos (dataNascimentoAluno, telefoneAluno, dddAluno, generoAluno, emailAluno, nomeAluno, cpfAluno, fk_cpfCliente) VALUES (@dataNascimentoAluno, @telefoneAluno, @dddAluno, @generoAluno, @emailAluno, @nomeAluno, @cpfAluno,@fk_cpfCliente)";

                comando = new MySqlCommand(strSQL, conexao);
                
                comando.Parameters.AddWithValue("@nomeAluno", txtNomeCompleto.Text);
                comando.Parameters.AddWithValue("@emailAluno", txtEmail.Text);
                comando.Parameters.AddWithValue("@telefoneAluno", mktTelefone.Text);
                comando.Parameters.AddWithValue("@fk_cpfCliente", mktCpfCliente.Text);
                comando.Parameters.AddWithValue("@cpfAluno", mktCpfAluno.Text);
                comando.Parameters.AddWithValue("@dddAluno", mktDDD.Text);
                comando.Parameters.AddWithValue("@dataNascimentoAluno", Convert.ToDateTime(dtNascimento.Text));
                comando.Parameters.AddWithValue("@generoAluno", cbSexo.Text);      
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
    }
}
