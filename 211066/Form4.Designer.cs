namespace _211066
{
    partial class frm_informacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_informacoes));
            this.lbl_titulo_informacoes = new System.Windows.Forms.Label();
            this.grp_historia = new System.Windows.Forms.GroupBox();
            this.lbl_historia = new System.Windows.Forms.Label();
            this.grp_link = new System.Windows.Forms.GroupBox();
            this.lklbl_site = new System.Windows.Forms.LinkLabel();
            this.grp_endereco = new System.Windows.Forms.GroupBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_voltar = new System.Windows.Forms.Label();
            this.grp_historia.SuspendLayout();
            this.grp_link.SuspendLayout();
            this.grp_endereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo_informacoes
            // 
            this.lbl_titulo_informacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo_informacoes.AutoSize = true;
            this.lbl_titulo_informacoes.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_informacoes.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_titulo_informacoes.Location = new System.Drawing.Point(264, 9);
            this.lbl_titulo_informacoes.Name = "lbl_titulo_informacoes";
            this.lbl_titulo_informacoes.Size = new System.Drawing.Size(237, 45);
            this.lbl_titulo_informacoes.TabIndex = 1;
            this.lbl_titulo_informacoes.Text = "Informações";
            this.lbl_titulo_informacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_historia
            // 
            this.grp_historia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_historia.BackColor = System.Drawing.SystemColors.Control;
            this.grp_historia.Controls.Add(this.lbl_historia);
            this.grp_historia.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_historia.Location = new System.Drawing.Point(96, 79);
            this.grp_historia.Name = "grp_historia";
            this.grp_historia.Size = new System.Drawing.Size(597, 231);
            this.grp_historia.TabIndex = 2;
            this.grp_historia.TabStop = false;
            this.grp_historia.Text = "História:";
            // 
            // lbl_historia
            // 
            this.lbl_historia.AutoSize = true;
            this.lbl_historia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_historia.Location = new System.Drawing.Point(32, 34);
            this.lbl_historia.Name = "lbl_historia";
            this.lbl_historia.Size = new System.Drawing.Size(538, 180);
            this.lbl_historia.TabIndex = 0;
            this.lbl_historia.Text = resources.GetString("lbl_historia.Text");
            // 
            // grp_link
            // 
            this.grp_link.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_link.BackColor = System.Drawing.SystemColors.Control;
            this.grp_link.Controls.Add(this.lklbl_site);
            this.grp_link.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_link.Location = new System.Drawing.Point(96, 384);
            this.grp_link.Name = "grp_link";
            this.grp_link.Size = new System.Drawing.Size(597, 53);
            this.grp_link.TabIndex = 3;
            this.grp_link.TabStop = false;
            this.grp_link.Text = "Link - Site:";
            // 
            // lklbl_site
            // 
            this.lklbl_site.AutoSize = true;
            this.lklbl_site.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklbl_site.Location = new System.Drawing.Point(230, 23);
            this.lklbl_site.Name = "lklbl_site";
            this.lklbl_site.Size = new System.Drawing.Size(121, 16);
            this.lklbl_site.TabIndex = 0;
            this.lklbl_site.TabStop = true;
            this.lklbl_site.Text = "www.etecjau.com.br";
            this.lklbl_site.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_site_LinkClicked);
            // 
            // grp_endereco
            // 
            this.grp_endereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_endereco.BackColor = System.Drawing.SystemColors.Control;
            this.grp_endereco.Controls.Add(this.lbl_endereco);
            this.grp_endereco.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_endereco.Location = new System.Drawing.Point(96, 316);
            this.grp_endereco.Name = "grp_endereco";
            this.grp_endereco.Size = new System.Drawing.Size(597, 53);
            this.grp_endereco.TabIndex = 4;
            this.grp_endereco.TabStop = false;
            this.grp_endereco.Text = "Endereço:";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.Location = new System.Drawing.Point(107, 26);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(385, 18);
            this.lbl_endereco.TabIndex = 0;
            this.lbl_endereco.Text = "R. Humaitá, 1090 - Centro - CEP: 17201-320 - Jaú/SP";
            // 
            // lbl_voltar
            // 
            this.lbl_voltar.AutoSize = true;
            this.lbl_voltar.BackColor = System.Drawing.Color.Blue;
            this.lbl_voltar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_voltar.ForeColor = System.Drawing.Color.White;
            this.lbl_voltar.Location = new System.Drawing.Point(0, 0);
            this.lbl_voltar.Name = "lbl_voltar";
            this.lbl_voltar.Size = new System.Drawing.Size(26, 24);
            this.lbl_voltar.TabIndex = 6;
            this.lbl_voltar.Text = "⬅";
            this.lbl_voltar.Click += new System.EventHandler(this.lbl_voltar_Click);
            // 
            // frm_informacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_voltar);
            this.Controls.Add(this.grp_endereco);
            this.Controls.Add(this.grp_link);
            this.Controls.Add(this.grp_historia);
            this.Controls.Add(this.lbl_titulo_informacoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_informacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema: Escola - Informações";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grp_historia.ResumeLayout(false);
            this.grp_historia.PerformLayout();
            this.grp_link.ResumeLayout(false);
            this.grp_link.PerformLayout();
            this.grp_endereco.ResumeLayout(false);
            this.grp_endereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_informacoes;
        private System.Windows.Forms.GroupBox grp_historia;
        private System.Windows.Forms.GroupBox grp_link;
        private System.Windows.Forms.LinkLabel lklbl_site;
        private System.Windows.Forms.Label lbl_historia;
        private System.Windows.Forms.GroupBox grp_endereco;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_voltar;
    }
}