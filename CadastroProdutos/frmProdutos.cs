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
    }
}
