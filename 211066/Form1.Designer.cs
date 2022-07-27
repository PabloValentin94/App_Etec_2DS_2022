namespace _211066
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.lbl_titulo_pagina_principal = new System.Windows.Forms.Label();
            this.grp_opcoes = new System.Windows.Forms.GroupBox();
            this.btn_nsa = new System.Windows.Forms.Button();
            this.btn_informacoes = new System.Windows.Forms.Button();
            this.btn_professores = new System.Windows.Forms.Button();
            this.btn_alunos = new System.Windows.Forms.Button();
            this.grp_opcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo_pagina_principal
            // 
            this.lbl_titulo_pagina_principal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo_pagina_principal.AutoSize = true;
            this.lbl_titulo_pagina_principal.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_pagina_principal.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_titulo_pagina_principal.Location = new System.Drawing.Point(103, 9);
            this.lbl_titulo_pagina_principal.Name = "lbl_titulo_pagina_principal";
            this.lbl_titulo_pagina_principal.Size = new System.Drawing.Size(596, 45);
            this.lbl_titulo_pagina_principal.TabIndex = 0;
            this.lbl_titulo_pagina_principal.Text = "Etec Joaquim Ferreira do Amaral";
            this.lbl_titulo_pagina_principal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_opcoes
            // 
            this.grp_opcoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_opcoes.BackColor = System.Drawing.SystemColors.Control;
            this.grp_opcoes.Controls.Add(this.btn_nsa);
            this.grp_opcoes.Controls.Add(this.btn_informacoes);
            this.grp_opcoes.Controls.Add(this.btn_professores);
            this.grp_opcoes.Controls.Add(this.btn_alunos);
            this.grp_opcoes.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_opcoes.Location = new System.Drawing.Point(111, 79);
            this.grp_opcoes.Name = "grp_opcoes";
            this.grp_opcoes.Size = new System.Drawing.Size(588, 359);
            this.grp_opcoes.TabIndex = 1;
            this.grp_opcoes.TabStop = false;
            this.grp_opcoes.Text = "Opções:";
            // 
            // btn_nsa
            // 
            this.btn_nsa.BackColor = System.Drawing.Color.Blue;
            this.btn_nsa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nsa.ForeColor = System.Drawing.Color.White;
            this.btn_nsa.Location = new System.Drawing.Point(330, 212);
            this.btn_nsa.Name = "btn_nsa";
            this.btn_nsa.Size = new System.Drawing.Size(139, 75);
            this.btn_nsa.TabIndex = 3;
            this.btn_nsa.Text = "NSA";
            this.btn_nsa.UseVisualStyleBackColor = false;
            this.btn_nsa.Click += new System.EventHandler(this.btn_nsa_Click);
            // 
            // btn_informacoes
            // 
            this.btn_informacoes.BackColor = System.Drawing.Color.DimGray;
            this.btn_informacoes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_informacoes.ForeColor = System.Drawing.Color.White;
            this.btn_informacoes.Location = new System.Drawing.Point(119, 212);
            this.btn_informacoes.Name = "btn_informacoes";
            this.btn_informacoes.Size = new System.Drawing.Size(139, 75);
            this.btn_informacoes.TabIndex = 2;
            this.btn_informacoes.Text = "Informações";
            this.btn_informacoes.UseVisualStyleBackColor = false;
            this.btn_informacoes.Click += new System.EventHandler(this.btn_informacoes_Click);
            // 
            // btn_professores
            // 
            this.btn_professores.BackColor = System.Drawing.Color.Red;
            this.btn_professores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_professores.ForeColor = System.Drawing.Color.White;
            this.btn_professores.Location = new System.Drawing.Point(330, 84);
            this.btn_professores.Name = "btn_professores";
            this.btn_professores.Size = new System.Drawing.Size(139, 75);
            this.btn_professores.TabIndex = 1;
            this.btn_professores.Text = "Professores";
            this.btn_professores.UseVisualStyleBackColor = false;
            this.btn_professores.Click += new System.EventHandler(this.btn_professores_Click);
            // 
            // btn_alunos
            // 
            this.btn_alunos.BackColor = System.Drawing.Color.Green;
            this.btn_alunos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alunos.ForeColor = System.Drawing.Color.White;
            this.btn_alunos.Location = new System.Drawing.Point(119, 84);
            this.btn_alunos.Name = "btn_alunos";
            this.btn_alunos.Size = new System.Drawing.Size(139, 75);
            this.btn_alunos.TabIndex = 0;
            this.btn_alunos.Text = "Alunos";
            this.btn_alunos.UseVisualStyleBackColor = false;
            this.btn_alunos.Click += new System.EventHandler(this.btn_alunos_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_opcoes);
            this.Controls.Add(this.lbl_titulo_pagina_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema: Escola";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grp_opcoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_pagina_principal;
        private System.Windows.Forms.GroupBox grp_opcoes;
        private System.Windows.Forms.Button btn_nsa;
        private System.Windows.Forms.Button btn_informacoes;
        private System.Windows.Forms.Button btn_professores;
        private System.Windows.Forms.Button btn_alunos;
    }
}

