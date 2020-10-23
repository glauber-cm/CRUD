namespace CadastroProdutos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblEmbalagem = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblSabor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblCadastroProduto = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(26, 66);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(40, 13);
            this.lblCodProduto.TabIndex = 0;
            this.lblCodProduto.Text = "Código";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(26, 118);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(182, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(72, 63);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCodProduto.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(387, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(225, 92);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblEmbalagem
            // 
            this.lblEmbalagem.AutoSize = true;
            this.lblEmbalagem.Location = new System.Drawing.Point(4, 92);
            this.lblEmbalagem.Name = "lblEmbalagem";
            this.lblEmbalagem.Size = new System.Drawing.Size(62, 13);
            this.lblEmbalagem.TabIndex = 8;
            this.lblEmbalagem.Text = "Embalagem";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(460, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 20);
            this.textBox5.TabIndex = 11;
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(419, 92);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(35, 13);
            this.lblSabor.TabIndex = 10;
            this.lblSabor.Text = "Sabor";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "45",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboBox1.Location = new System.Drawing.Point(293, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Pet",
            "Garrafa",
            "Lata",
            "Pacote",
            "Unidade(s)"});
            this.comboBox2.Location = new System.Drawing.Point(72, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // lblCadastroProduto
            // 
            this.lblCadastroProduto.AutoSize = true;
            this.lblCadastroProduto.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroProduto.Location = new System.Drawing.Point(120, 9);
            this.lblCadastroProduto.Name = "lblCadastroProduto";
            this.lblCadastroProduto.Size = new System.Drawing.Size(423, 44);
            this.lblCadastroProduto.TabIndex = 14;
            this.lblCadastroProduto.Text = "CADASTRO DE PRODUTOS";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(7, 153);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(603, 229);
            this.dgvProdutos.TabIndex = 15;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(7, 388);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 37);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(87, 388);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 37);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(454, 388);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 37);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.Location = new System.Drawing.Point(373, 388);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 37);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeletar.Location = new System.Drawing.Point(535, 388);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 37);
            this.btnDeletar.TabIndex = 20;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblCadastroProduto);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblSabor);
            this.Controls.Add(this.lblEmbalagem);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblCodProduto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblEmbalagem;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblCadastroProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnDeletar;
    }
}

