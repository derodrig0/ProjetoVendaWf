﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Util.Entidades.Clientes;
using Util.Entidades.Clientes.Repositorio;


namespace ProjetoVendaWF
{
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();
        }

        private ClienteRepositorio clienteRepositorio;
        public static List<Cliente> retornoClienteRepositorio;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cNome = string.Empty;
            var cCPF = string.Empty;
            var cEndereco = string.Empty;

            cNome = txtNome.Text;
            cCPF = txtCPF.Text;
            cEndereco = txtEndereco.Text;

            var cInfo = new Cliente(cNome, cCPF, cEndereco);
            retornoClienteRepositorio.Add(cInfo);

            //string output = string.Empty;
            //foreach (var item in retornoClienteRepositorio)
            //{
            //    output += "Nome: " + item.Nome + " | " + "CPF: " + item.Cpf + " | " + "Cidade: " + item.Endereco + "\n";
            //}
            //MessageBox.Show(output);

            txtNome.Text = String.Empty;
            txtCPF.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtNome.Focus();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
             clienteRepositorio = new ClienteRepositorio();
             retornoClienteRepositorio = clienteRepositorio.Clientes;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            txtEndereco.CharacterCasing = CharacterCasing.Upper;
        }

    }
}
