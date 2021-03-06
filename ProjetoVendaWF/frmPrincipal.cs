﻿using System;
using System.Drawing;
using System.Windows.Forms;


namespace ProjetoVendaWF
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadClientes)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
                Form frmCli = new frmCadClientes();
                frmCli.MdiParent = this;
                frmCli.StartPosition = FormStartPosition.Manual;
                int x = (this.Width - frmCli.Width) / 2;
                int y = (this.Height - frmCli.Height) / 4;
                frmCli.Location = new Point(x, y);
                frmCli.Show();
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadProdutos)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
                Form frmProd = new frmCadProdutos();
                frmProd.MdiParent = this;
                frmProd.StartPosition = FormStartPosition.Manual;
                int x = (this.Width - frmProd.Width) / 2;
                int y = (this.Height - frmProd.Height) / 4;
                frmProd.Location = new Point(x, y);
                frmProd.Show();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadUsuarios)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
                Form frmUsu = new frmCadUsuarios();
                frmUsu.MdiParent = this;
                frmUsu.StartPosition = FormStartPosition.Manual;
                int x = (this.Width - frmUsu.Width) / 2;
                int y = (this.Height - frmUsu.Height) / 4;
                frmUsu.Location = new Point(x, y);
                frmUsu.Show();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            var produtoRepositorio = new Util.Entidades.Produtos.Repositorio.ProdutoRepositorio();
            var retornoProdutoRepositorio = produtoRepositorio.Produtos;

            var vendaRepositorio = new Util.Entidades.Vendas.Repositorio.VendaRepositorio();
            var retornoVendaRepositorio = vendaRepositorio.Vendas;
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmConsClientes)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
                Form frmCli = new frmConsClientes();
                frmCli.MdiParent = this;
                frmCli.StartPosition = FormStartPosition.Manual;
                int x = (this.Width - frmCli.Width) / 2;
                int y = (this.Height - frmCli.Height) / 4;
                frmCli.Location = new Point(x, y);
                frmCli.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmConsUsuarios)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
                Form frmUsu = new frmConsUsuarios();
                frmUsu.MdiParent = this;
                frmUsu.StartPosition = FormStartPosition.Manual;
                int x = (this.Width - frmUsu.Width) / 2;
                int y = (this.Height - frmUsu.Height) / 4;
                frmUsu.Location = new Point(x, y);
                frmUsu.Show();
            }
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmConsProdutos)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
                Form frmProd = new frmConsProdutos();
                frmProd.MdiParent = this;
                frmProd.StartPosition = FormStartPosition.Manual;
                int x = (this.Width - frmProd.Width) / 2;
                int y = (this.Height - frmProd.Height) / 4;
                frmProd.Location = new Point(x, y);
                frmProd.Show();
            }
        }
    }
}
