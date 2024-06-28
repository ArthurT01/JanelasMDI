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
        MySqlDataReader dr;
        string strSQL;
        int cod;
        int flag = 0;
        string codCliente;

        public Frm_CadastrarAluno()
        {
            InitializeComponent();
        }

        //INFORMA NÚMERO DO CADASTRO
        private void Frm_AgendarConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT MAX(codigoAluno) FROM t_alunos";
                comando = new MySqlCommand(strSQL, conexao);

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cod = Convert.ToInt32(dr["MAX(codigoAluno)"]);
                        cod += 1;
                    }
                    txtCodigoAluno.Text = Convert.ToString(cod);
                }
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }


        //BOTÕES 
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            flag = 0;          
            tratamentoDeDados();
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            limpa();
        }




        //MÉTODOS
        private void cadastroAluno()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "INSERT INTO t_alunos (dataNascimentoAluno, telefoneAluno, dddAluno, generoAluno, emailAluno, nomeAluno, cpfAluno, fk_cpfCliente, fk_codigoCliente) VALUES (@dataNascimentoAluno, @telefoneAluno, @dddAluno, @generoAluno, @emailAluno, @nomeAluno, @cpfAluno,@fk_cpfCliente, @fk_codigoCliente)";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@nomeAluno", txtNomeCompleto.Text);
                comando.Parameters.AddWithValue("@emailAluno", txtEmail.Text);
                comando.Parameters.AddWithValue("@telefoneAluno", mktTelefone.Text);
                comando.Parameters.AddWithValue("@fk_cpfCliente", mktCpfCliente.Text);
                comando.Parameters.AddWithValue("@fk_codigoCliente", codCliente);
                comando.Parameters.AddWithValue("@cpfAluno", mktCpfAluno.Text);
                comando.Parameters.AddWithValue("@dddAluno", mktDDD.Text);
                comando.Parameters.AddWithValue("@dataNascimentoAluno", Convert.ToDateTime(dtNascimento.Text));
                comando.Parameters.AddWithValue("@generoAluno", cbSexo.Text);
                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro Efetuado!");

                limpa();
                cod++;
                txtCodigoAluno.Text = Convert.ToString(cod);


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
    
        private void limpa()
        {
            txtNomeCompleto.Text = "";
            dtNascimento.Text = "";
            mktCpfAluno.Text = "";
            txtCodigoAluno.Text = "";
            txtEmail.Text = "";
            mktTelefone.Text = "";
            mktDDD.Text = "";
            cbSexo.Text = "";
        }

        private void tratamentoDeDados()
        {
            string email = txtEmail.Text;

            if (txtEmail.Text == null || txtNomeCompleto.Text == null || mktCpfAluno.MaskCompleted == false || mktCpfCliente.MaskCompleted == false || mktDDD.MaskCompleted == false || mktTelefone.MaskCompleted == false || cbSexo.Text == null)
            {
                MessageBox.Show("Campo em branco ou incompleto");
            }
            else
            {
                if (!email.Contains("@") || !email.Contains(".") || email.Length < 3)
                {
                    MessageBox.Show("Email inválido");
                    txtEmail.Text = "";
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if (txtNomeCompleto.Text.Contains(i.ToString()))
                        {
                            flag++;
                            MessageBox.Show("Não é permitido números, Verifique os seguintes campos: 'Nome', 'País', 'Profissão', 'Rua', 'Bairro' e 'Cidade'");
                            break;
                        }
                    }
                    if (flag == 1)
                    {

                    }
                    else
                    {
                        List<string> caracteresEspeciais = new List<string>()
                        {
                            "!", "@", "#", "$", "%", "^", "&", "*", "(", ")",
                            "-", "_", "=", "+", "[", "]", "{", "}", ";", ":",
                            "'", "\"", "<", ">", ",", ".", "?", "/", "º", "ª",
                            "\\", "`", "~", "|"
                        };

                        foreach (var i in caracteresEspeciais)
                        {
                            if(txtNomeCompleto.Text.Contains(i.ToString()))
                            {
                                flag++;
                                MessageBox.Show("Não é permitido carateres especiais, Verifique os seguintes campos: 'Nome', 'País', 'Profissão', 'Rua', 'Bairro' e 'Cidade'");
                                break;
                            }
                        }
                        if (flag == 1)
                        {

                        }
                        else
                        {
                            codigoCliente();
                            cadastroAluno();
                        }
                    }
                }
            }

        }

        private void codigoCliente()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT codigoCliente FROM t_clientes WHERE cpfCliente = @cpfCliente ";
                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@cpfCliente", mktCpfCliente.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       codCliente = Convert.ToString(dr["codigoCliente"]);
                    }
                }
                else
                {
                    MessageBox.Show("ID não encontrado no Banco de Dados");
                }

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



        //NÃO ESTÁ EM USO
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

   
    }
}
