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
    public partial class FrmCadastrarProduto : Form
    {
        ProdutoTableAdapter adapter = new ProdutoTableAdapter();
        ProdutoDataTable produtoDt;
        public FrmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void FrmCadastrarProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDbDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.lojaDbDataSet.Categoria);
            AtualizaGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != "" && txtPreco.Text != "")
            {
                try
                {
                    adapter.Insert(txtDescricao.Text, decimal.Parse(txtPreco.Text), int.Parse(cboCategoria.SelectedValue.ToString()));
                    MessageBox.Show("Inserido com sucesso");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void AtualizaGrid()
        {
            produtoDt = adapter.GetGrid();
            dgvProduto.Rows.Clear();
            foreach (var item in produtoDt)
            {
                int n = dgvProduto.Rows.Add();
                dgvProduto.Rows[n].Cells[0].Value = item["id"];
                dgvProduto.Rows[n].Cells[1].Value = item["nome"];
                dgvProduto.Rows[n].Cells[2].Value = item["preco"];
                dgvProduto.Rows[n].Cells[3].Value = item["categoria"];
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != "" && txtPreco.Text != "")
            {
                try
                {
                    adapter.UpdateQuery(txtDescricao.Text, decimal.Parse(txtPreco.Text), int.Parse(cboCategoria.SelectedValue.ToString()), int.Parse(txtId.Text));
                    MessageBox.Show("Editado com sucesso");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescricao.Text = dgvProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPreco.Text = dgvProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
            cboCategoria.Text = dgvProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse registro", "Exclusão", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    adapter.DeleteQuery(int.Parse(txtId.Text));
                    MessageBox.Show("Excluído com sucesso");
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
