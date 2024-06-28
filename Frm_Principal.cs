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
    public partial class Frm_Principal : Form
    {
        string tipo = "";
        int flag;

        public Frm_Principal()
        {
            InitializeComponent();
        }

        public Frm_Principal(string tipoUser, string nomeUser)
        {

            InitializeComponent();      

            if (tipoUser == "COORDENADOR")
            {
                
            }
            else if(tipoUser == "ATENDIMENTO")
            {
                administraçãoToolStripMenuItem.Visible = false;
                tpCadastrarUsuarios.Visible = false;
                tpListarUsuarios.Visible = false;  
            }
            tpNomeUsuario.Text = "User: "+nomeUser;
        }



      
        //AJUDA
        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ajuda();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre();
        }




        //JANELA
        private void organizarNaHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void organizarNaVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void organizarEmCascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fecharTodasAsJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void maximizarTodasAsJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.WindowState = FormWindowState.Minimized;
            }
        }

        private void mInimizarTodasAsJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.WindowState = FormWindowState.Maximized;
            }

        }




        //ADMNISTRAÇÃO
        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarUsers();
        }

        //listar usuários
        private void vizualizarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarUsuarios();
        }




        //SISTEMA
        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarClientes();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarClientes();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscaClientes();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarAlunos();
        }

        private void listarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarAlunos();
        }

        private void buscarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscaAlunos();
        }

        //cadastrar alunos
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cadastrarAlunos();
        }



   
        //EXIBIR
        private void ocultarBarraDeFerramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(toolStrip1.Visible == true)
            {
                toolStrip1.Visible = false;
            }
            else
            {
                toolStrip1.Visible = true;
            }
                
        }

       


        //METÓDOS DOS FORMULÁRIOS
        private void listarClientes()
        {
            tipo = "CLIENTES";
            Frm_ListarCadastros frm_ListarClientes = new Frm_ListarCadastros(tipo);
            frm_ListarClientes.MdiParent = this;
            frm_ListarClientes.Show();
        }

        private void listarAlunos()
        {
            tipo = "ALUNOS";
            Frm_ListarCadastros frm_ListarClientes = new Frm_ListarCadastros(tipo);
            frm_ListarClientes.MdiParent = this;
            frm_ListarClientes.Show();
        }

        private void listarUsuarios()
        {
            tipo = "USER";
            Frm_ListarCadastros frm_ListarClientes = new Frm_ListarCadastros(tipo);
            frm_ListarClientes.MdiParent = this;
            frm_ListarClientes.Show();
        }

        private void cadastrarUsers()
        {
            Frm_CadastrarUsuario frmcadUsu = new Frm_CadastrarUsuario();
            frmcadUsu.MdiParent = this;
            frmcadUsu.Show();
        }

        private void cadastrarClientes()
        {
            Frm_CadastrarClientes frmcadcli = new Frm_CadastrarClientes();
            frmcadcli.MdiParent = this;
            frmcadcli.Show();
        }

        private void cadastrarAlunos()
        {
            Frm_CadastrarAluno frmCadAluno = new Frm_CadastrarAluno();
            frmCadAluno.MdiParent = this;
            frmCadAluno.Show();
        }

        private void buscaClientes()
        {
            Frm_BuscaClientes frmbuscaCli = new Frm_BuscaClientes();
            frmbuscaCli.MdiParent = this;
            frmbuscaCli.Show();
        }

        private void buscaAlunos()
        {
            Frm_BuscarAluno frmBuscaAlu = new Frm_BuscarAluno();
            frmBuscaAlu.MdiParent = this;
            frmBuscaAlu.Show();
        }

        private void sobre()
        {
            Frm_Sobre frmsobre = new Frm_Sobre();
            //frmsobre.MdiParent= this;
            frmsobre.Show();
        }

        private void ajuda()
        {
            Frm_Ajuda frmajuda = new Frm_Ajuda();
            frmajuda.MdiParent = this;
            frmajuda.Show();
        }




        //ICONES BARRA DE FERRAMENTAS
        private void tpCadastroCliente_Click(object sender, EventArgs e)
        {
            cadastrarClientes();
        }

        private void tpCadastararAlunos_Click(object sender, EventArgs e)
        {
            cadastrarAlunos();
        }

        private void tpBuscaAlunos_Click(object sender, EventArgs e)
        {
            buscaAlunos();
        }

        private void tpBuscaCliente_Click(object sender, EventArgs e)
        {
            buscaClientes();
        }

        private void tpListarUsuarios_Click(object sender, EventArgs e)
        {
            listarUsuarios();
        }

        private void tpListarAlunos_Click(object sender, EventArgs e)
        {
            listarAlunos();
        }

        private void tpListarClientes_Click(object sender, EventArgs e)
        {
            listarClientes();
        }

        //ajuda
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ajuda();
        }

        //fechar programa
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }




        //NÃO ESTÁ EM USO
        private void agendarAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void visualizarAtendimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
