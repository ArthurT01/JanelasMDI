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
    public partial class Frm_BuscarAluno : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQL;

        public Frm_BuscarAluno()
        {
            InitializeComponent();
        }

        private void Frm_BuscarAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           if(cbTipoBusca.Text == "CÓDIGO ALUNO")
           {
                buscaCódigoAluno();
           }
           if (cbTipoBusca.Text == "CÓDIGO CLIENTE")
           {
                buscaCódigoCliente();
           }
           if (cbTipoBusca.Text == "CPF ALUNO")
           {
                buscaCpfAluno();
           }
           if (cbTipoBusca.Text == "CPF CLIENTE")
           {
                buscaCpfCliente();
           }
        }

        private void buscaCódigoAluno()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_alunos WHERE codigoAluno = @codigoAluno";
                comando = new MySqlCommand(strSQL, conexao);
                             
                comando.Parameters.AddWithValue("@codigoAluno", mktBusca.Text);
                        
                conexao.Open();
                
                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtNome.Text = Convert.ToString(dr["nomeAluno"]);
                        mkdDataNascimento.Text = Convert.ToString(dr["dataNascimentoAluno"]);
                        mktCpfCliente.Text = Convert.ToString(dr["fk_cpfCliente"]);
                        mktCpfAluno.Text = Convert.ToString(dr["cpfAluno"]);
                        txtEmail.Text = Convert.ToString(dr["emailAluno"]);
                        txtCodigo.Text = Convert.ToString(dr["codigoAluno"]);
                        mktTelefone.Text = Convert.ToString(dr["telefoneAluno"]);
                        mkdDDD.Text = Convert.ToString(dr["dddAluno"]);
                        txtSexo.Text = Convert.ToString(dr["generoAluno"]);
                    }
                    buscaDadosCliente();
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

        private void buscaCódigoCliente()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_alunos WHERE fk_codigoCliente = @fk_codigoCliente";
                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@fk_codigoCliente", mktBusca.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtNome.Text = Convert.ToString(dr["nomeAluno"]);
                        mkdDataNascimento.Text = Convert.ToString(dr["dataNascimentoAluno"]);
                        mktCpfCliente.Text = Convert.ToString(dr["fk_cpfCliente"]);
                        mktCpfAluno.Text = Convert.ToString(dr["cpfAluno"]);
                        txtEmail.Text = Convert.ToString(dr["emailAluno"]);
                        txtCodigo.Text = Convert.ToString(dr["codigoAluno"]);
                        mktTelefone.Text = Convert.ToString(dr["telefoneAluno"]);
                        mkdDDD.Text = Convert.ToString(dr["dddAluno"]);
                        txtSexo.Text = Convert.ToString(dr["generoAluno"]);
                    }
                    buscaDadosCliente();
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

        private void buscaCpfAluno()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_alunos WHERE cpfAluno = @cpfAluno";
                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@cpfAluno", mktBusca.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtNome.Text = Convert.ToString(dr["nomeAluno"]);
                        mkdDataNascimento.Text = Convert.ToString(dr["dataNascimentoAluno"]);
                        mktCpfCliente.Text = Convert.ToString(dr["fk_cpfCliente"]);
                        mktCpfAluno.Text = Convert.ToString(dr["cpfAluno"]);
                        txtEmail.Text = Convert.ToString(dr["emailAluno"]);
                        txtCodigo.Text = Convert.ToString(dr["codigoAluno"]);
                        mktTelefone.Text = Convert.ToString(dr["telefoneAluno"]);
                        mkdDDD.Text = Convert.ToString(dr["dddAluno"]);
                        txtSexo.Text = Convert.ToString(dr["generoAluno"]);
                    }
                    buscaDadosCliente();
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

        private void buscaCpfCliente()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_alunos WHERE fk_cpfCliente = @fk_cpfCliente";
                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@fk_cpfCliente", mktBusca.Text);

                conexao.Open();

                dr = comando.ExecuteReader();
                 
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtNome.Text = Convert.ToString(dr["nomeAluno"]);
                        mkdDataNascimento.Text = Convert.ToString(dr["dataNascimentoAluno"]);
                        mktCpfCliente.Text = Convert.ToString(dr["fk_cpfCliente"]);
                        mktCpfAluno.Text = Convert.ToString(dr["cpfAluno"]);
                        txtEmail.Text = Convert.ToString(dr["emailAluno"]);
                        txtCodigo.Text = Convert.ToString(dr["codigoAluno"]);
                        mktTelefone.Text = Convert.ToString(dr["telefoneAluno"]);
                        mkdDDD.Text = Convert.ToString(dr["dddAluno"]);
                        txtSexo.Text = Convert.ToString(dr["generoAluno"]);
                    }
                    buscaDadosCliente();
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


        private void buscaDadosCliente()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT nomeCliente, telefoneCliente, dddCliente FROM t_clientes join t_alunos on t_clientes.cpfCliente = @cpfCliente";
                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@cpfCliente", mktCpfCliente.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtNomeCliente.Text = Convert.ToString(dr["nomeCliente"]);
                        mktTelefoneCliente.Text = Convert.ToString(dr["telefoneCliente"]);
                        mktDddCliente.Text = Convert.ToString(dr["dddCliente"]);
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


        private void mktBusca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void cbTipoBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoBusca.Text == "CPF ALUNO" || cbTipoBusca.Text == "CPF CLIENTE")
            {
                mktBusca.Mask = "000.000.000-00";
            }
            else
            {
                mktBusca.Mask = "0000";
            }
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
