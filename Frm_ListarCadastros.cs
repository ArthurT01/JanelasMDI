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
    public partial class Frm_ListarCadastros : Form
    {
        MySqlConnection conexao;
        MySqlDataAdapter da;
        string strSQL;

        public Frm_ListarCadastros()
        {
            InitializeComponent();
        }

        public Frm_ListarCadastros(string tipo)
        {
            InitializeComponent();
           
            if (tipo == "ALUNOS")
            {
                listarAlunos();
                label1.Text = "LISTAR ALUNOS";
            }
            else if (tipo == "CLIENTES")
            {
                listarClientes();
                label1.Text = "LISTAR CLIENTES";
            }
            else if (tipo == "USER")
            {
                listarUsuarios();
                label1.Text = "LISTAR USUÁRIOS";
            }
            else
            {
                MessageBox.Show("Nenhuma Opção selecionada");
            }
        }



        //BOTÕES
        private void picSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //MÉTODOS
        private void listarAlunos()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");

                strSQL = "SELECT * FROM t_alunos";
                da = new MySqlDataAdapter(strSQL, conexao);

                conexao.Open();

                DataTable dt = new DataTable();

                da.Fill(dt);
                dtListarCadastros.DataSource = dt;
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

        private void listarClientes()
        {
            try
            { 
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_clientes";
                da = new MySqlDataAdapter(strSQL, conexao);

                conexao.Open();

                DataTable dt = new DataTable();

                da.Fill(dt);
                dtListarCadastros.DataSource = dt;
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

        private void listarUsuarios()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_usuarios";
                da = new MySqlDataAdapter(strSQL, conexao);

                conexao.Open();

                DataTable dt = new DataTable();

                da.Fill(dt);
                dtListarCadastros.DataSource = dt;
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