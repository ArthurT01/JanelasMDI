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
            buscaCódigo();
        }

        private void buscaCódigo()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_alunos WHERE fk_codigoCliente = @fk_codigoCliente OR codigoAluno = @codigoAluno OR fk_cpfCliente = @fk_cpfCliente OR cpfAluno = @cpfAluno";
                comando = new MySqlCommand(strSQL, conexao);
              
                comando.Parameters.AddWithValue("@cpfAluno", mktBusca.Text);              
                comando.Parameters.AddWithValue("@fk_cpfCliente", mktBusca.Text);              
                comando.Parameters.AddWithValue("@codigoAluno", mktBusca.Text);
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
    }
}
