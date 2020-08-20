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
using static TreinoCrud.LojaDbDataSet;

namespace TreinoCrud
{
    public partial class FrmCadastrarCategoria : Form
    {
        CategoriaTableAdapter adapter = new CategoriaTableAdapter();
        public FrmCadastrarCategoria()
        {
            InitializeComponent();
        }

        private void FrmCadastrarCategoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDbDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.lojaDbDataSet.Categoria);

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != "")
            {
                try
                {
                    adapter.Insert(txtDescricao.Text);
                    MessageBox.Show("Inserido com sucesso");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AtualizaGrid()
        {
            dgvCategoria.DataSource = adapter.GetData();
            txtDescricao.Text = "";
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescricao.Text = dgvCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtDescricao.Text != "")
            {
                try
                {
                    adapter.UpdateQuery(txtDescricao.Text, int.Parse(txtId.Text));
                    MessageBox.Show("Editado com sucesso");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente apagar esse registro?", "Exclusão", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    adapter.DeleteQuery(int.Parse(txtId.Text));
                    MessageBox.Show("Exluido com sucesso");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
