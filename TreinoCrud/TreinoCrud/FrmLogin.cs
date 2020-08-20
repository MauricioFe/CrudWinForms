using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinoCrud.LojaDbDataSetTableAdapters;
using TreinoCrud.Models;
using static TreinoCrud.LojaDbDataSet;

namespace TreinoCrud
{
    public partial class FrmLogin : Form
    {
        UsuarioTableAdapter adapter = new UsuarioTableAdapter(); 
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioDataTable usuarioDt = new UsuarioDataTable();
            int count  = adapter.FillLogin(usuarioDt, txtEmail.Text, txtSenha.Text);

            if (count > 0)
            {
                usuarioDt = adapter.GetLogin(txtEmail.Text, txtSenha.Text);
                Usuario usuario = new Usuario();
                foreach (var item in usuarioDt)
                {
                    usuario.Id = Convert.ToInt32(item["id"]);
                    usuario.Nome = item["Nome"].ToString(); ;
                    usuario.Email = item["Email"].ToString(); ;
                }
                FrmMenu form = new FrmMenu(usuario);
                form.Show();
            }
            else
            {
                MessageBox.Show("Erro ao realizar login. Verifique suas credênciais");
            }
        }
    }
}
