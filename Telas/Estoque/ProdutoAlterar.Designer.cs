namespace Bistro.Telas.Estoque
{
    partial class ProdutoAlterar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lbnmlFornecedor = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.dtvConsulta = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cboTipoo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbotipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label47 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvConsulta)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(77, -27);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtFornecedor.TabIndex = 35;
            // 
            // lbnmlFornecedor
            // 
            this.lbnmlFornecedor.AutoSize = true;
            this.lbnmlFornecedor.Location = new System.Drawing.Point(10, -24);
            this.lbnmlFornecedor.Name = "lbnmlFornecedor";
            this.lbnmlFornecedor.Size = new System.Drawing.Size(35, 13);
            this.lbnmlFornecedor.TabIndex = 29;
            this.lbnmlFornecedor.Text = "Nome";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(494, 4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(18, 19);
            this.label24.TabIndex = 60;
            this.label24.Text = "?";
            this.toolTip1.SetToolTip(this.label24, "Ajuda");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(518, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "X";
            this.toolTip2.SetToolTip(this.label5, "Fechar");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDeletar);
            this.panel3.Location = new System.Drawing.Point(13, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 64);
            this.panel3.TabIndex = 64;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeletar.Location = new System.Drawing.Point(65, 21);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 24);
            this.btnDeletar.TabIndex = 53;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // dtvConsulta
            // 
            this.dtvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvConsulta.Location = new System.Drawing.Point(13, 99);
            this.dtvConsulta.Name = "dtvConsulta";
            this.dtvConsulta.Size = new System.Drawing.Size(220, 270);
            this.dtvConsulta.TabIndex = 62;
            this.dtvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtvConsulta_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboProduto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(238, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 64);
            this.panel2.TabIndex = 63;
            // 
            // cboProduto
            // 
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(105, 24);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(100, 21);
            this.cboProduto.TabIndex = 52;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.Location = new System.Drawing.Point(46, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Produto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.cboTipoo);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.cbotipo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Location = new System.Drawing.Point(238, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 270);
            this.panel1.TabIndex = 61;
            // 
            // cboID
            // 
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(105, 78);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(100, 21);
            this.cboID.TabIndex = 54;
            this.cboID.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.Location = new System.Drawing.Point(80, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "ID";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(129, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 16);
            this.label23.TabIndex = 55;
            this.label23.Text = "Alterar ";
            // 
            // cboTipoo
            // 
            this.cboTipoo.FormattingEnabled = true;
            this.cboTipoo.Location = new System.Drawing.Point(105, 131);
            this.cboTipoo.Name = "cboTipoo";
            this.cboTipoo.Size = new System.Drawing.Size(100, 21);
            this.cboTipoo.TabIndex = 52;
            this.cboTipoo.SelectedIndexChanged += new System.EventHandler(this.CboTipoo_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(105, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(99, 20);
            this.txtNome.TabIndex = 50;
            // 
            // cbotipo
            // 
            this.cbotipo.AutoSize = true;
            this.cbotipo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbotipo.Location = new System.Drawing.Point(68, 132);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(32, 17);
            this.cbotipo.TabIndex = 48;
            this.cbotipo.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.Location = new System.Drawing.Point(56, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nome";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.Location = new System.Drawing.Point(104, 158);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 24);
            this.btnAlterar.TabIndex = 40;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label47.Location = new System.Drawing.Point(209, 6);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(115, 18);
            this.label47.TabIndex = 74;
            this.label47.Text = "Alterar Produtos";
            // 
            // ProdutoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BackgroundImage = global::Bistro.Properties.Resources.Paris1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 391);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtvConsulta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.lbnmlFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdutoAlterar";
            this.Text = "ProdutoAlterar";
            this.Load += new System.EventHandler(this.ProdutoAlterar_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvConsulta)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lbnmlFornecedor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridView dtvConsulta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ComboBox cboTipoo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label cbotipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label47;
    }
}