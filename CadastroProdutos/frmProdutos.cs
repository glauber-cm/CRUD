using System;
using System.Data;
using System.Data.SqlClient;
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
            ListarProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            novo = true;

        }

        public void Salvar(Produtos prod)
        {
            string sql = "INSERT INTO PRODUTOS(CODPRODUTO, NOME, PRECO, EMBALAGEM, SABOR, QUANTIDADE)" +
                  "VALUES(@CodProduto, @Nome, @Preco, @Embalagem, @Sabor, @Quantidade)";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@CodProduto", prod.CodProduto);
            cmd.Parameters.AddWithValue("@Nome", prod.Nome);
            cmd.Parameters.AddWithValue("@Preco", prod.Preco);
            cmd.Parameters.AddWithValue("@Embalagem", prod.Embalagem);
            cmd.Parameters.AddWithValue("@Sabor", prod.Sabor);
            cmd.Parameters.AddWithValue("@Quantidade", prod.Quantidade);
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
            finally
            {
                con.Close();
            }
            
        }

        public void Editar(Produtos prod)
        {
            string sql = @"UPDATE PRODUTOS SET NOME=@Nome, PRECO=@Preco, EMBALAGEM=@Embalagem," +
                         "SABOR=@Sabor, QUANTIDADE=@Quantidade WHERE CODPRODUTO=@CodProduto";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@CodProduto", prod.CodProduto);
            cmd.Parameters.AddWithValue("@Nome", prod.Nome);
            cmd.Parameters.AddWithValue("@Preco", prod.Preco);
            cmd.Parameters.AddWithValue("@Embalagem", prod.Embalagem);
            cmd.Parameters.AddWithValue("@Sabor", prod.Sabor);
            cmd.Parameters.AddWithValue("@Quantidade", prod.Quantidade);
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
            finally
            {
                con.Close();
            }

        }

        public void Deletar(Produtos prod)
        {
            string sql = @"DELETE FROM Produtos WHERE CODPRODUTO = @CodProduto";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@CodProduto", prod.CodProduto);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void ListarProdutos()
        {
            string sql = @"SELECT *FROM Produtos";
            
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dtListaProd = new DataTable();
                dataAdapter.Fill(dtListaProd);
                dgvProdutos.DataSource = dtListaProd;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            
        }

        public void LimparCampos()
        {
            txtCodProduto.Text = string.Empty;
            txtNome.Text = string.Empty;
            cmbEmbalagem.Text = string.Empty;
            cmbQtde.Text = string.Empty;
            txtSabor.Text = string.Empty;
            txtPreco.Text = string.Empty;
        }

        public bool ValidarCampos()
        {
            bool teste;

            if (string.IsNullOrEmpty(txtCodProduto.Text))
            {
                MessageBox.Show("Favor inserir o codigo!");
                teste = false;
            }
            else if (string.IsNullOrEmpty(cmbQtde.Text))
            {
                MessageBox.Show("Favor inserir a quantidade!");
                teste = false;
            }
            else if (string.IsNullOrEmpty(txtPreco.Text))
            {
                MessageBox.Show("Favor inserir o preço!");
                teste = false;
            }
            else
                teste = true;

            return teste;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            Produtos prod = new Produtos();

            if (ValidarCampos())
            {
                prod.CodProduto = int.Parse(txtCodProduto.Text);
                prod.Nome = txtNome.Text;
                prod.Embalagem = cmbEmbalagem.Text;
                prod.Quantidade = int.Parse(cmbQtde.Text);
                prod.Sabor = txtSabor.Text;
                prod.Preco = double.Parse(txtPreco.Text);

                if (novo)
                {
                    Salvar(prod);
                    novo = false;
                }
                else
                    Editar(prod);
                
                dgvProdutos.Refresh();
                ListarProdutos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //
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

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();
            prod.CodProduto = int.Parse(txtCodProduto.Text);
            Deletar(prod);
            ListarProdutos();

        }
    }
}
