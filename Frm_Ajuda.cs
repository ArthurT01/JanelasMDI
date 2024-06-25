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
    public partial class Frm_Ajuda : Form
    {
        public Frm_Ajuda()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if(cbEscolha.Text == "Formulário de Cadastro de Alunos")
            {
                label2.Text = "Um formulário utilizado para inserir novos dados de alunos em um sistema educacional ou administrativo, \nincluindo informações como nome, data de nascimento, entre outros.\n\nPreencha todos os dados corretamente e clique no botão cadastrar para salvar ou clique no botão limpar para limpar os campos \npreenchidos.";
            }
            else if(cbEscolha.Text == "Formulário de Cadastro de Clientes")
            {
                label2.Text = "Um formulário destinado ao registro de novos clientes em um sistema de gestão de clientes de uma empresa, \ncontendo dados como nome, endereço, telefone, e-mail, entre outros.\n\nPreencha todos os dados corretamente e clique no botão cadastrar para salvar ou clique no botão limpar para limpar os campos \npreenchidos.";
            }
            else if (cbEscolha.Text == "Formulário de Cadastro de Usuários")
            {
                label2.Text = "Um formulário que apenas os Coordenadore conseguem registrar novos usuários em um sistema, geralmente com campos como nome \nde usuário, senha, cargo, e-mail, entre outras informações necessárias para o acesso e gerenciamento de contas.\n\nPreencha todos os dados corretamente e clique no botão cadastrar para salvar ou clique no botão limpar para limpar os campos\n preenchidos.";
            }
            else if (cbEscolha.Text == "Formulário de Busca de Alunos")
            {
                label2.Text = "Um formulário utilizado para procurar informações específicas sobre alunos já cadastrados, geralmente por meio de\n campos como nome, matrícula, curso, etc., facilitando a localização rápida de dados individuais.\n\nSelecione o tipo da busca e preencha o campo para buscar o cliente.";
            }
            else if (cbEscolha.Text == "Formulário de Busca de Clientes")
            {
                label2.Text = "Um formulário que permite encontrar informações detalhadas sobre clientes existentes em um sistema, usando critérios \ncomo nome, telefone, e-mail, facilitando a consulta e o atendimento personalizado.\n\nSelecione o tipo da busca e preencha o campo para buscar o cliente.";
            }
            else if (cbEscolha.Text == "Formulário de Listagem de Alunos")
            {
                label2.Text = "Um formulário que exibe uma lista completa de todos os alunos cadastrados, mostrando detalhes como nome, matrícula, \ncurso, e outras informações relevantes para visualização rápida e gerenciamento de dados. \n\nAo clicar na opção de 'listar alunos' todos os alunos serão listados.";
            }
            else if (cbEscolha.Text == "FFormulário de Listagem de Clientes")
            {
                label2.Text = "Um formulário que apresenta uma lista completa de todos os clientes registrados em um sistema, exibindo informações como \nnome, endereço, telefone, e outras características relevantes para análise e gestão de relacionamento com clientes. \n\nAo clicar na opção de 'listar clientes' todos os clientes serão listados.";
            }
            else if (cbEscolha.Text == "Formulário de Listagem de Usuários")
            {
                label2.Text = "Um formulário que lista todos os usuários registrados no sistema, mostrando detalhes como nome de usuário e cargo, permitindo \numa visão geral dos usuários cadastrados para fins administrativos.\n\n Ao clicar na opção de 'listar usuários' todos os alunos serão listados.(Opção disponível apenas para Coordenadores)";
            }
            else if (cbEscolha.Text == "Formulário de escolha Principal")
            {
                label2.Text = "Um formulário ou tela inicial que apresenta opções principais para o usuário, servindo como ponto de entrada para diferentes \nfuncionalidades do sistema, como cadastro, busca ou listagem de dados específicos.";
            }
        }
    }
}
