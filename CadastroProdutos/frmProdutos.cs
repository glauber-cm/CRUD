using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProdutos
{
    public partial class frmProdutos : Form
    {
        string connectionString = @"Server=.;Data Source=PC_MENDES\SQLEXPRESS;Initial Catalog=BD_PRODUTOS;Integrated Security=True;";
        bool novo;
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo = true;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                string sql = "INSERT INTO PRODUTOS(CODPRODUTO, NOME, PRECO, EMBALAGEM, SABOR, QUANTIDADE)" +
                    "VALUES(@CodProduto, @Nome, @Preco, @Embalagem, @Sabor, @Quantidade)";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CodProduto", int.Parse(txtCodProduto.Text));
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Preco", double.Parse(txtPreco.Text));
                cmd.Parameters.AddWithValue("@Embalagem", cmbEmbalagem.SelectedItem);
                cmd.Parameters.AddWithValue("@Sabor", txtSabor.Text );
                cmd.Parameters.AddWithValue("@Quantidade", cmbQtde.SelectedItem);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Salvo com Sucesso!!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex.ToString());
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodProduto.Text = string.Empty;
            txtNome.Text = string.Empty;
            cmbEmbalagem.Text = string.Empty;
            cmbQtde.Text = string.Empty;
            txtSabor.Text = string.Empty;
            txtPreco.Text = string.Empty;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE PRODUTOS SET NOME=@Nome, PRECO=@Preco, EMBALAGEM=@Embalagem," +
                "SABOR=@Sabor, QUANTIDADE=@Quantidade WHERE CODPRODUTO=@CodProduto";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@CodProduto", int.Parse(txtCodProduto.Text));
            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@Preco", double.Parse(txtPreco.Text));
            cmd.Parameters.AddWithValue("@Embalagem", cmbEmbalagem.SelectedItem);
            cmd.Parameters.AddWithValue("@Sabor", txtSabor.Text);
            cmd.Parameters.AddWithValue("@Quantidade", cmbQtde.SelectedItem);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Produto atualizado com sucesso!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.ToString());
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvProdutos.CurrentRow.Index;

            txtCodProduto.Text = Convert.ToString(dgvProdutos["codproduto",sel].Value);
            txtNome.Text = Convert.ToString(dgvProdutos["nome",sel].Value);
            cmbEmbalagem.Text = Convert.ToString(dgvProdutos["embalagem",sel].Value);
            cmbQtde.Text = Convert.ToString(dgvProdutos["quantidade",sel].Value);
            txtSabor.Text = Convert.ToString(dgvProdutos["sabor",sel].Value);
            txtPreco.Text = Convert.ToString(dgvProdutos["preco",sel].Value);
        }
    }
}
