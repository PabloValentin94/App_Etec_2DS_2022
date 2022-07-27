namespace _211066
{
    partial class frm_nsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nsa));
            this.pcbx_nsa_online = new System.Windows.Forms.PictureBox();
            this.lbl_titulo_nsa = new System.Windows.Forms.Label();
            this.grp_nsa = new System.Windows.Forms.GroupBox();
            this.lbl_voltar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_nsa_online)).BeginInit();
            this.grp_nsa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbx_nsa_online
            // 
            this.pcbx_nsa_online.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbx_nsa_online.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbx_nsa_online.Image = ((System.Drawing.Image)(resources.GetObject("pcbx_nsa_online.Image")));
            this.pcbx_nsa_online.Location = new System.Drawing.Point(158, 90);
            this.pcbx_nsa_online.Name = "pcbx_nsa_online";
            this.pcbx_nsa_online.Size = new System.Drawing.Size(261, 195);
            this.pcbx_nsa_online.TabIndex = 1;
            this.pcbx_nsa_online.TabStop = false;
            this.pcbx_nsa_online.Click += new System.EventHandler(this.pcbx_nsa_online_Click);
            // 
            // lbl_titulo_nsa
            // 
            this.lbl_titulo_nsa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo_nsa.AutoSize = true;
            this.lbl_titulo_nsa.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_nsa.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_titulo_nsa.Location = new System.Drawing.Point(335, 9);
            this.lbl_titulo_nsa.Name = "lbl_titulo_nsa";
            this.lbl_titulo_nsa.Size = new System.Drawing.Size(95, 45);
            this.lbl_titulo_nsa.TabIndex = 2;
            this.lbl_titulo_nsa.Text = "NSA";
            this.lbl_titulo_nsa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_nsa
            // 
            this.grp_nsa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_nsa.BackColor = System.Drawing.SystemColors.Control;
            this.grp_nsa.Controls.Add(this.pcbx_nsa_online);
            this.grp_nsa.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_nsa.Location = new System.Drawing.Point(96, 79);
            this.grp_nsa.Name = "grp_nsa";
            this.grp_nsa.Size = new System.Drawing.Size(597, 359);
            this.grp_nsa.TabIndex = 3;
            this.grp_nsa.TabStop = false;
            this.grp_nsa.Text = "Clique na imagem abaixo:";
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
            // frm_nsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_voltar);
            this.Controls.Add(this.grp_nsa);
            this.Controls.Add(this.lbl_titulo_nsa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frm_nsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema: Escola - NSA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_nsa_online)).EndInit();
            this.grp_nsa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbx_nsa_online;
        private System.Windows.Forms.Label lbl_titulo_nsa;
        private System.Windows.Forms.GroupBox grp_nsa;
        private System.Windows.Forms.Label lbl_voltar;
    }
}