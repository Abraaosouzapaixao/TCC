namespace Bistro.Telas.Estoque
{
    partial class ProdutoAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cboInserirTipo = new System.Windows.Forms.ComboBox();
            this.txtNmProduto = new System.Windows.Forms.TextBox();
            this.cbotipo = new System.Windows.Forms.Label();
            this.lbnmlFornecedor = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboNome = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboConsultarTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label47 = new System.Windows.Forms.Label();
            this.dtvConsulta = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.cboInserirTipo);
            this.panel1.Controls.Add(this.txtNmProduto);
            this.panel1.Controls.Add(this.cbotipo);
            this.panel1.Controls.Add(this.lbnmlFornecedor);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 111);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdicionar.Location = new System.Drawing.Point(88, 69);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 30);
            this.btnAdicionar.TabIndex = 47;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // cboInserirTipo
            // 
            this.cboInserirTipo.FormattingEnabled = true;
            this.cboInserirTipo.Items.AddRange(new object[] {
            "consumidor",
            "industriais ",
            "de conveniência ",
            "de impulso ",
            "de emergência ",
            "de compra comparada  ",
            "de especialidade ",
            "não procurados ",
            "perecíveis ",
            "duráveis ",
            "não-duráveis ",
            "de capital ",
            "partes e materiais ",
            "abastecimento e serviços ",
            "commodities ",
            "intermediários"});
            this.cboInserirTipo.Location = new System.Drawing.Point(88, 38);
            this.cboInserirTipo.Name = "cboInserirTipo";
            this.cboInserirTipo.Size = new System.Drawing.Size(100, 21);
            this.cboInserirTipo.TabIndex = 39;
            // 
            // txtNmProduto
            // 
            this.txtNmProduto.BackColor = System.Drawing.Color.White;
            this.txtNmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmProduto.Location = new System.Drawing.Point(89, 12);
            this.txtNmProduto.Name = "txtNmProduto";
            this.txtNmProduto.Size = new System.Drawing.Size(100, 20);
            this.txtNmProduto.TabIndex = 35;
            // 
            // cbotipo
            // 
            this.cbotipo.AutoSize = true;
            this.cbotipo.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.cbotipo.Location = new System.Drawing.Point(49, 41);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(30, 16);
            this.cbotipo.TabIndex = 30;
            this.cbotipo.Text = "Tipo";
            // 
            // lbnmlFornecedor
            // 
            this.lbnmlFornecedor.AutoSize = true;
            this.lbnmlFornecedor.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lbnmlFornecedor.Location = new System.Drawing.Point(43, 14);
            this.lbnmlFornecedor.Name = "lbnmlFornecedor";
            this.lbnmlFornecedor.Size = new System.Drawing.Size(40, 16);
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
            this.label24.TabIndex = 46;
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
            this.label5.TabIndex = 45;
            this.label5.Text = "X";
            this.toolTip2.SetToolTip(this.label5, "Fechar");
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboNome);
            this.panel2.Controls.Add(this.btnConsultar);
            this.panel2.Controls.Add(this.cboConsultarTipo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(281, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 111);
            this.panel2.TabIndex = 48;
            // 
            // cboNome
            // 
            this.cboNome.FormattingEnabled = true;
            this.cboNome.Location = new System.Drawing.Point(92, 12);
            this.cboNome.Name = "cboNome";
            this.cboNome.Size = new System.Drawing.Size(100, 21);
            this.cboNome.TabIndex = 48;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.Location = new System.Drawing.Point(92, 69);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 30);
            this.btnConsultar.TabIndex = 47;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboConsultarTipo
            // 
            this.cboConsultarTipo.FormattingEnabled = true;
            this.cboConsultarTipo.Items.AddRange(new object[] {
            "consumidor",
            "industriais ",
            "de conveniência ",
            "de impulso ",
            "de emergência ",
            "de compra comparada  ",
            "de especialidade ",
            "não procurados ",
            "perecíveis ",
            "duráveis ",
            "não-duráveis ",
            "de capital ",
            "partes e materiais ",
            "abastecimento e serviços ",
            "commodities ",
            "intermediários"});
            this.cboConsultarTipo.Location = new System.Drawing.Point(92, 39);
            this.cboConsultarTipo.Name = "cboConsultarTipo";
            this.cboConsultarTipo.Size = new System.Drawing.Size(100, 21);
            this.cboConsultarTipo.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label8.Location = new System.Drawing.Point(56, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label9.Location = new System.Drawing.Point(46, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Nome";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label47.Location = new System.Drawing.Point(209, 6);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(138, 18);
            this.label47.TabIndex = 58;
            this.label47.Text = "Cadastrar Produtos";
            // 
            // dtvConsulta
            // 
            this.dtvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dtvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvConsulta.Location = new System.Drawing.Point(14, 152);
            this.dtvConsulta.Name = "dtvConsulta";
            this.dtvConsulta.Size = new System.Drawing.Size(526, 227);
            this.dtvConsulta.TabIndex = 49;
            this.dtvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtvConsulta_CellContentClick);
            // 
            // ProdutoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BackgroundImage = global::Bistro.Properties.Resources.Paris1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 391);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.dtvConsulta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdutoAdd";
            this.Text = "ProdutoAdd";
            this.Load += new System.EventHandler(this.ProdutoAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboInserirTipo;
        private System.Windows.Forms.TextBox txtNmProduto;
        private System.Windows.Forms.Label cbotipo;
        private System.Windows.Forms.Label lbnmlFornecedor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboConsultarTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ComboBox cboNome;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.DataGridView dtvConsulta;
    }
}