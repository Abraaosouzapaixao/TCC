namespace Bistro.Telas.Financeiro
{
    partial class FluxodeCaixa
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
            this.lblAjuda = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.BackColor = System.Drawing.Color.Transparent;
            this.lblAjuda.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAjuda.ForeColor = System.Drawing.Color.Black;
            this.lblAjuda.Location = new System.Drawing.Point(484, 4);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(24, 25);
            this.lblAjuda.TabIndex = 73;
            this.lblAjuda.Text = "?";
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.BackColor = System.Drawing.Color.Transparent;
            this.lblFechar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblFechar.ForeColor = System.Drawing.Color.Black;
            this.lblFechar.Location = new System.Drawing.Point(512, 4);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(26, 25);
            this.lblFechar.TabIndex = 72;
            this.lblFechar.Text = "X";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Felix Titling", 10F);
            this.label27.Location = new System.Drawing.Point(227, 12);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(126, 16);
            this.label27.TabIndex = 74;
            this.label27.Text = "Fluxo de Caixa";
            // 
            // FluxodeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BackgroundImage = global::Bistro.Properties.Resources.Paris1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 391);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.lblFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FluxodeCaixa";
            this.Text = "FluxodeCaixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label label27;
    }
}