namespace Bistro.Telas.RH
{
    partial class Controle_de_ponto
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
            this.label7 = new System.Windows.Forms.Label();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.dtvConsulta = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.nudFaltas = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpSaidaTrabalho = new System.Windows.Forms.DateTimePicker();
            this.dtpEntraAlmoco = new System.Windows.Forms.DateTimePicker();
            this.dtpSairAlmoco = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaTrabalho = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cboFuncionarioConsulta = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaltas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboFuncionario);
            this.panel1.Location = new System.Drawing.Point(164, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 37);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Funcionario:";
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(94, 7);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(100, 21);
            this.cboFuncionario.TabIndex = 47;
            // 
            // dtvConsulta
            // 
            this.dtvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvConsulta.Location = new System.Drawing.Point(21, 332);
            this.dtvConsulta.Name = "dtvConsulta";
            this.dtvConsulta.Size = new System.Drawing.Size(364, 110);
            this.dtvConsulta.TabIndex = 13;
            this.dtvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvConsulta_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(374, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            this.toolTip2.SetToolTip(this.label5, "Fechar");
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(350, 4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(18, 19);
            this.label24.TabIndex = 40;
            this.label24.Text = "?";
            this.toolTip1.SetToolTip(this.label24, "Ajuda");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label12.Location = new System.Drawing.Point(252, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 16);
            this.label12.TabIndex = 57;
            this.label12.Text = "Dia:";
            // 
            // dtpDia
            // 
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDia.Location = new System.Drawing.Point(280, 133);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(78, 20);
            this.dtpDia.TabIndex = 56;
            // 
            // nudFaltas
            // 
            this.nudFaltas.Location = new System.Drawing.Point(280, 263);
            this.nudFaltas.Name = "nudFaltas";
            this.nudFaltas.Size = new System.Drawing.Size(78, 20);
            this.nudFaltas.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label11.Location = new System.Drawing.Point(239, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Faltas:";
            // 
            // dtpSaidaTrabalho
            // 
            this.dtpSaidaTrabalho.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaidaTrabalho.Location = new System.Drawing.Point(280, 237);
            this.dtpSaidaTrabalho.Name = "dtpSaidaTrabalho";
            this.dtpSaidaTrabalho.Size = new System.Drawing.Size(78, 20);
            this.dtpSaidaTrabalho.TabIndex = 53;
            // 
            // dtpEntraAlmoco
            // 
            this.dtpEntraAlmoco.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntraAlmoco.Location = new System.Drawing.Point(280, 185);
            this.dtpEntraAlmoco.Name = "dtpEntraAlmoco";
            this.dtpEntraAlmoco.Size = new System.Drawing.Size(78, 20);
            this.dtpEntraAlmoco.TabIndex = 52;
            // 
            // dtpSairAlmoco
            // 
            this.dtpSairAlmoco.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSairAlmoco.Location = new System.Drawing.Point(280, 211);
            this.dtpSairAlmoco.Name = "dtpSairAlmoco";
            this.dtpSairAlmoco.Size = new System.Drawing.Size(78, 20);
            this.dtpSairAlmoco.TabIndex = 51;
            // 
            // dtpEntradaTrabalho
            // 
            this.dtpEntradaTrabalho.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaTrabalho.Location = new System.Drawing.Point(280, 159);
            this.dtpEntradaTrabalho.Name = "dtpEntradaTrabalho";
            this.dtpEntradaTrabalho.Size = new System.Drawing.Size(78, 20);
            this.dtpEntradaTrabalho.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label1.Location = new System.Drawing.Point(152, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Volta Hora do Almoço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label8.Location = new System.Drawing.Point(169, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Saída do Trabalho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label4.Location = new System.Drawing.Point(136, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Entrada Hora do Almoço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label6.Location = new System.Drawing.Point(158, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Entrada no Trabalho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "00:00h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Horas Trabalhadas:";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Transparent;
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInserir.Location = new System.Drawing.Point(269, 294);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 25);
            this.btnInserir.TabIndex = 41;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click_1);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label47.Location = new System.Drawing.Point(157, 9);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(129, 18);
            this.label47.TabIndex = 58;
            this.label47.Text = "Controle de Ponto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cboFuncionarioConsulta);
            this.panel2.Location = new System.Drawing.Point(21, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 37);
            this.panel2.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Funcionario:";
            // 
            // cboFuncionarioConsulta
            // 
            this.cboFuncionarioConsulta.FormattingEnabled = true;
            this.cboFuncionarioConsulta.Location = new System.Drawing.Point(94, 7);
            this.cboFuncionarioConsulta.Name = "cboFuncionarioConsulta";
            this.cboFuncionarioConsulta.Size = new System.Drawing.Size(100, 21);
            this.cboFuncionarioConsulta.TabIndex = 47;
            this.cboFuncionarioConsulta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Controle_de_ponto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BackgroundImage = global::Bistro.Properties.Resources.Paris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpDia);
            this.Controls.Add(this.nudFaltas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpSaidaTrabalho);
            this.Controls.Add(this.dtpEntraAlmoco);
            this.Controls.Add(this.dtpSairAlmoco);
            this.Controls.Add(this.dtpEntradaTrabalho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtvConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Controle_de_ponto";
            this.Text = "Controle_de_ponto";
            this.Load += new System.EventHandler(this.Controle_de_ponto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaltas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtvConsulta;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.NumericUpDown nudFaltas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpSaidaTrabalho;
        private System.Windows.Forms.DateTimePicker dtpEntraAlmoco;
        private System.Windows.Forms.DateTimePicker dtpSairAlmoco;
        private System.Windows.Forms.DateTimePicker dtpEntradaTrabalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboFuncionarioConsulta;
    }
}