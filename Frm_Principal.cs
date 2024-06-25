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
            }
            tpNomeUsuario.Text = "User: "+nomeUser;
        }



        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastrarClientes frmcadcli = new Frm_CadastrarClientes();
            frmcadcli.MdiParent = this;
            frmcadcli.Show(); 
        }


        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Ajuda frmajuda = new Frm_Ajuda();
            frmajuda.MdiParent = this;
            frmajuda.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sobre frmsobre = new Frm_Sobre();
            //frmsobre.MdiParent= this;
            frmsobre.Show();
        }

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

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = "CLIENTES";
            Frm_ListarCadastros frm_ListarClientes =  new Frm_ListarCadastros(tipo);
            frm_ListarClientes.MdiParent = this;
            frm_ListarClientes.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            Frm_BuscaClientes frmbuscaCli = new Frm_BuscaClientes();
            frmbuscaCli.MdiParent = this;
            frmbuscaCli.Show();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastrarAluno frmCadAluno = new Frm_CadastrarAluno();
            frmCadAluno.MdiParent = this;
            frmCadAluno.Show();
        }

        private void listarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = "ALUNOS";
            Frm_ListarCadastros frm_ListarClientes = new Frm_ListarCadastros(tipo);
            frm_ListarClientes.MdiParent = this;
            frm_ListarClientes.Show();
        }

        private void buscarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BuscarAluno frmBuscaAlu = new Frm_BuscarAluno();
            frmBuscaAlu.MdiParent = this;
            frmBuscaAlu.Show();
        }

        private void agendarAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void visualizarAtendimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastrarUsuario frmcadUsu = new Frm_CadastrarUsuario();
            frmcadUsu.MdiParent = this;
            frmcadUsu.Show();
        }

        private void vizualizarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = "USER";
            Frm_ListarCadastros frm_ListarClientes = new Frm_ListarCadastros(tipo);
            frm_ListarClientes.MdiParent = this;
            frm_ListarClientes.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frm_CadastrarAluno frmcadAlu = new Frm_CadastrarAluno();
            frmcadAlu.MdiParent = this;
            frmcadAlu.Show();
        }

        private void maximizarTodasAsJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.WindowState = FormWindowState.Minimized;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Frm_BuscarAluno frmBuscaAlu = new Frm_BuscarAluno();
            frmBuscaAlu.MdiParent = this;
            frmBuscaAlu.Show();
        }

        private void mInimizarTodasAsJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.WindowState = FormWindowState.Maximized;
            }

        }

        private void tpFecharJanelas_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Frm_Ajuda frmajuda = new Frm_Ajuda();
            frmajuda.MdiParent = this;
            frmajuda.Show();
        }

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
    }
}
