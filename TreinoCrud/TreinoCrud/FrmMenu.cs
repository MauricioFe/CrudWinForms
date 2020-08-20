using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinoCrud.Models;

namespace TreinoCrud
{
    public partial class FrmMenu : Form
    {
        Usuario _usuario = new Usuario();
        public FrmMenu(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblTitulo.Text += " " + _usuario.Nome;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Dispose();
        }

        private void btnCadastraCategoria_Click(object sender, EventArgs e)
        {
            FrmCadastrarCategoria form = new FrmCadastrarCategoria();
            form.Show();
            this.Dispose();
        }

        private void btnCadatrarProduto_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto form = new FrmCadastrarProduto();
            form.Show();
            this.Dispose();
        }
    }
}
