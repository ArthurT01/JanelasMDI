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
        string strSQL;

        public Frm_CadastrarClientes()
        {
            InitializeComponent();
        }

        private void Frm_CadastrarAnimal_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text == null || txtEmail.Text == null || txtNumeroEndereco.Text == null || txtPais.Text == null || txtProfissao.Text == null || txtRua.Text == null || txtBairro.Text == null || txtCidade.Text == null || mktCep.MaskCompleted == false || mktCpf.MaskCompleted == false || mktDDD.MaskCompleted == false || mktTelefone.MaskCompleted == false)
            {
                MessageBox.Show("Cadastro incompleto!");
            }
            else
            {
                
                cadastroCliente();
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
                comando.Parameters.AddWithValue("@numCasa", txtNumeroEndereco.Text);
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

        private void mktCep_Leave(object sender, EventArgs e)
        {
            if(mktCep.MaskCompleted)
            {
                executaBuscaTratada();
            }
        }
    }  

}
