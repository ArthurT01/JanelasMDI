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
    public partial class Frm_CadastrarClientes : Form
    {

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQL;
        int cod;
        int flag = 0;

        public Frm_CadastrarClientes()
        {
            InitializeComponent();
        }

        private void Frm_CadastrarAnimal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT MAX(codigoCliente) FROM t_clientes";
                comando = new MySqlCommand(strSQL, conexao);

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cod = Convert.ToInt32(dr["MAX(codigoCliente)"]);
                        cod += 1;
                    }
                    txtCodigoCliente.Text = Convert.ToString(cod);
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

        private void cadastroCliente()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "INSERT INTO t_clientes (nomeCliente, cpfCliente, emailCliente, profissao, telefoneCliente, dddCliente, dataNascimentoCliente, generoCliente, tipoEndereço, rua, bairro, cidade, estado, numCasa, país, cep) VALUES (@nomeCliente, @cpfCliente, @emailCliente, @profissao, @telefoneCliente, @dddCliente, @dataNascimentoCliente, @generoCliente , @tipoEndereço, @rua,  @bairro, @cidade, @estado, @numCasa, @país, @cep)";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@nomeCliente", txtNomeCompleto.Text);
                comando.Parameters.AddWithValue("@cpfCliente", mktCpf.Text);
                comando.Parameters.AddWithValue("@profissao", txtProfissao.Text);
                comando.Parameters.AddWithValue("@emailCliente", txtEmail.Text);
                comando.Parameters.AddWithValue("@telefoneCliente", mktTelefone.Text);
                comando.Parameters.AddWithValue("@dddCliente", mktDDD.Text);
                comando.Parameters.AddWithValue("@dataNascimentoCliente", Convert.ToDateTime(dtNascimento.Text));
                comando.Parameters.AddWithValue("@generoCliente", cbSexo.Text);
                comando.Parameters.AddWithValue("@tipoEndereço", cbTipoEndereco.Text);
                comando.Parameters.AddWithValue("@rua", txtRua.Text);
                comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                comando.Parameters.AddWithValue("@estado", cbEstado.Text);
                comando.Parameters.AddWithValue("@numCasa", mktNumCasa.Text);
                comando.Parameters.AddWithValue("@país", txtPais.Text);
                comando.Parameters.AddWithValue("@cep", Convert.ToInt64(mktCep.Text));
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
    
        private void executaBuscaTratada()
        {
            string input = mktCep.Text;
            int c;

            if (int.TryParse(input, out c) && input.Length == 8)
            {
                try
                {
                    BuscaCep BuscaCep = new BuscaCep(c);

                    if (string.IsNullOrEmpty(BuscaCep.Cep))
                    {
                        MessageBox.Show("CEP não encontrado. " +
                                        "Verifique o número digitado e tente novamente.",
                                        "CEP Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtRua.Text = BuscaCep.Rua;
                        txtBairro.Text = BuscaCep.Bairro;
                        txtCidade.Text = BuscaCep.Cidade;
                        cbEstado.Text = BuscaCep.Estado;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao buscar o CEP: " + ex.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, insira um CEP válido que contenha apenas números.",
                                "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mktCep.Clear();
                mktCep.Focus();
            }
        }

        private void tratamentoDeDados()
        {
            string email = txtEmail.Text;

            if (txtEmail.Text == null || txtNomeCompleto.Text == null || mktCpf.MaskCompleted == false || mktNumCasa.TextLength < 1 || mktDDD.MaskCompleted == false || mktTelefone.MaskCompleted == false || cbSexo.Text == null || cbTipoEndereco.Text == null || cbEstado.Text == null || txtPais.Text == null || txtProfissao.Text == null || txtRua.Text == null || txtBairro.Text == null || txtCidade.Text == null)
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
                        if (txtNomeCompleto.Text.Contains(i.ToString()) || txtProfissao.Text.Contains(i.ToString()) || txtBairro.Text.Contains(i.ToString()) || txtCidade.Text.Contains(i.ToString()) || txtRua.Text.Contains(i.ToString()) || txtPais.Text.Contains(i.ToString()))
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
                            if (txtNomeCompleto.Text.Contains(i.ToString()))
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
                            cadastroCliente();
                        }
                    }
                }
            }

        }

        private void limpa()
        {
            txtNomeCompleto.Text = "";
            dtNascimento.Text = "";
            mktCpf.Text = "";
            mktCep.Text = "";
            txtEmail.Text = "";
            mktTelefone.Text = "";
            mktDDD.Text = "";
            cbSexo.Text = "";
            mktNumCasa.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
            txtProfissao.Text = "";
            txtPais.Text = "";
        }

        private void mktCep_Leave(object sender, EventArgs e)
        {
            if(mktCep.MaskCompleted)
            {
                executaBuscaTratada();
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            flag = 0;
            tratamentoDeDados();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpa();
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  

}
