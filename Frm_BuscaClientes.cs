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
    public partial class Frm_BuscaClientes : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQL;

        public Frm_BuscaClientes()
        {
            InitializeComponent();
        }

        private void Frm_BuscaClientes_Load(object sender, EventArgs e)
        {
          
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbTipoBusca.Text == "CÓDIGO")
            {
                buscaCódigo();
            }
            else if (cbTipoBusca.Text == "CPF")
            {
                buscaCpf();
            }
        }

        private void buscaCpf()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_clientes WHERE cpfCliente = @cpfCliente ";
                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@cpfCliente", mktBusca.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        txtNomeCompleto.Text = Convert.ToString(dr["nomeCliente"]);
                        mktDataNasc.Text = Convert.ToString(dr["dataNascimentoCliente"]);
                        mktCpf.Text = Convert.ToString(dr["cpfCliente"]);
                        txtCodigoCliente.Text = Convert.ToString(dr["codigoCliente"]);
                        txtEmail.Text = Convert.ToString(dr["emailCliente"]);
                        txtProfissão.Text = Convert.ToString(dr["profissao"]);
                        mktTelefone.Text = Convert.ToString(dr["telefoneCliente"]);
                        mkdDDD.Text = Convert.ToString(dr["dddCliente"]);
                        txtGenero.Text = Convert.ToString(dr["generoCliente"]);
                        txtTipoEndereco.Text = Convert.ToString(dr["tipoEndereço"]);
                        txtRua.Text = Convert.ToString(dr["rua"]);
                        txtBairro.Text = Convert.ToString(dr["bairro"]);
                        txtCidade.Text = Convert.ToString(dr["cidade"]);
                        txtEstado.Text = Convert.ToString(dr["estado"]);
                        txtNumeroEndereco.Text = Convert.ToString(dr["numCasa"]);
                        txtPais.Text = Convert.ToString(dr["país"]);
                        mktCep.Text = Convert.ToString(dr["cep"]);

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

        private void buscaCódigo()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_clientes WHERE codigoCliente = @codigoCliente ";
                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@codigoCliente", mktBusca.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        txtNomeCompleto.Text = Convert.ToString(dr["nomeCliente"]);
                        mktDataNasc.Text = Convert.ToString(dr["dataNascimentoCliente"]);
                        mktCpf.Text = Convert.ToString(dr["cpfCliente"]);
                        txtCodigoCliente.Text = Convert.ToString(dr["codigoCliente"]);
                        txtEmail.Text = Convert.ToString(dr["emailCliente"]);
                        txtProfissão.Text = Convert.ToString(dr["profissao"]);
                        mktTelefone.Text = Convert.ToString(dr["telefoneCliente"]);
                        mkdDDD.Text = Convert.ToString(dr["dddCliente"]);
                        txtGenero.Text = Convert.ToString(dr["generoCliente"]);
                        txtTipoEndereco.Text = Convert.ToString(dr["tipoEndereço"]);
                        txtRua.Text = Convert.ToString(dr["rua"]);
                        txtBairro.Text = Convert.ToString(dr["bairro"]);
                        txtCidade.Text = Convert.ToString(dr["cidade"]);
                        txtEstado.Text = Convert.ToString(dr["estado"]);
                        txtNumeroEndereco.Text = Convert.ToString(dr["numCasa"]);
                        txtPais.Text = Convert.ToString(dr["país"]);
                        mktCep.Text = Convert.ToString(dr["cep"]);

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

        private void cbTipoBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoBusca.Text == "CPF")
            {
                mktBusca.Mask = "000.000.000-00";
            }
            else
            {
                mktBusca.Mask = "0000";
            }
        }

        private void limpa()
        {
            txtNomeCompleto.Text = "";
            mktDataNasc.Text = "";
            mktCpf.Text = "";
            txtCodigoCliente.Text = "";
            txtEmail.Text = "";
            txtProfissão.Text = "";
            mktTelefone.Text = "";
            mkdDDD.Text = "";
            txtGenero.Text = "";
            txtTipoEndereco.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = 
            txtNumeroEndereco.Text = "";
            txtPais.Text = "";
            mktCep.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpa();
        }
    }
}
