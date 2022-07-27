namespace _211066
{
    partial class frm_professores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_professores));
            this.lbl_titulo_informacoes = new System.Windows.Forms.Label();
            this.lbl_voltar = new System.Windows.Forms.Label();
            this.grp_link_nsa = new System.Windows.Forms.GroupBox();
            this.lklbl_nsa = new System.Windows.Forms.LinkLabel();
            this.grp_cadastro_professores = new System.Windows.Forms.GroupBox();
            this.txt_disciplinas = new System.Windows.Forms.TextBox();
            this.lbl_disciplinas = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.ckb_remocao = new System.Windows.Forms.CheckBox();
            this.ckb_insercao = new System.Windows.Forms.CheckBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_nome_professor = new System.Windows.Forms.TextBox();
            this.lbl_nome_professor = new System.Windows.Forms.Label();
            this.lsb_professores_cadastrados = new System.Windows.Forms.ListBox();
            this.grp_professores_cadastrados = new System.Windows.Forms.GroupBox();
            this.grp_link_nsa.SuspendLayout();
            this.grp_cadastro_professores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo_informacoes
            // 
            this.lbl_titulo_informacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo_informacoes.AutoSize = true;
            this.lbl_titulo_informacoes.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_informacoes.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_titulo_informacoes.Location = new System.Drawing.Point(260, 9);
            this.lbl_titulo_informacoes.Name = "lbl_titulo_informacoes";
            this.lbl_titulo_informacoes.Size = new System.Drawing.Size(228, 45);
            this.lbl_titulo_informacoes.TabIndex = 2;
            this.lbl_titulo_informacoes.Text = "Professores";
            this.lbl_titulo_informacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // grp_link_nsa
            // 
            this.grp_link_nsa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_link_nsa.Controls.Add(this.lklbl_nsa);
            this.grp_link_nsa.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_link_nsa.Location = new System.Drawing.Point(12, 394);
            this.grp_link_nsa.Name = "grp_link_nsa";
            this.grp_link_nsa.Size = new System.Drawing.Size(350, 44);
            this.grp_link_nsa.TabIndex = 9;
            this.grp_link_nsa.TabStop = false;
            this.grp_link_nsa.Text = "Link - NSA:";
            // 
            // lklbl_nsa
            // 
            this.lklbl_nsa.AutoSize = true;
            this.lklbl_nsa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklbl_nsa.Location = new System.Drawing.Point(93, 21);
            this.lklbl_nsa.Name = "lklbl_nsa";
            this.lklbl_nsa.Size = new System.Drawing.Size(151, 16);
            this.lklbl_nsa.TabIndex = 0;
            this.lklbl_nsa.TabStop = true;
            this.lklbl_nsa.Text = "https://nsa.cps.sp.gov.br";
            this.lklbl_nsa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_nsa_LinkClicked);
            // 
            // grp_cadastro_professores
            // 
            this.grp_cadastro_professores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_cadastro_professores.Controls.Add(this.txt_disciplinas);
            this.grp_cadastro_professores.Controls.Add(this.lbl_disciplinas);
            this.grp_cadastro_professores.Controls.Add(this.btn_reset);
            this.grp_cadastro_professores.Controls.Add(this.ckb_remocao);
            this.grp_cadastro_professores.Controls.Add(this.ckb_insercao);
            this.grp_cadastro_professores.Controls.Add(this.txt_id);
            this.grp_cadastro_professores.Controls.Add(this.lbl_id);
            this.grp_cadastro_professores.Controls.Add(this.btn_remover);
            this.grp_cadastro_professores.Controls.Add(this.btn_inserir);
            this.grp_cadastro_professores.Controls.Add(this.txt_email);
            this.grp_cadastro_professores.Controls.Add(this.lbl_email);
            this.grp_cadastro_professores.Controls.Add(this.txt_nome_professor);
            this.grp_cadastro_professores.Controls.Add(this.lbl_nome_professor);
            this.grp_cadastro_professores.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_cadastro_professores.Location = new System.Drawing.Point(12, 70);
            this.grp_cadastro_professores.Name = "grp_cadastro_professores";
            this.grp_cadastro_professores.Size = new System.Drawing.Size(350, 309);
            this.grp_cadastro_professores.TabIndex = 8;
            this.grp_cadastro_professores.TabStop = false;
            this.grp_cadastro_professores.Text = "Cadastro de Professores:";
            // 
            // txt_disciplinas
            // 
            this.txt_disciplinas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_disciplinas.Location = new System.Drawing.Point(151, 225);
            this.txt_disciplinas.Name = "txt_disciplinas";
            this.txt_disciplinas.Size = new System.Drawing.Size(166, 26);
            this.txt_disciplinas.TabIndex = 12;
            // 
            // lbl_disciplinas
            // 
            this.lbl_disciplinas.AutoSize = true;
            this.lbl_disciplinas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disciplinas.Location = new System.Drawing.Point(27, 228);
            this.lbl_disciplinas.Name = "lbl_disciplinas";
            this.lbl_disciplinas.Size = new System.Drawing.Size(118, 19);
            this.lbl_disciplinas.TabIndex = 11;
            this.lbl_disciplinas.Text = "Disciplina(as):";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(124, 266);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 33);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // ckb_remocao
            // 
            this.ckb_remocao.AutoSize = true;
            this.ckb_remocao.Location = new System.Drawing.Point(203, 29);
            this.ckb_remocao.Name = "ckb_remocao";
            this.ckb_remocao.Size = new System.Drawing.Size(84, 20);
            this.ckb_remocao.TabIndex = 9;
            this.ckb_remocao.Text = "Remoção";
            this.ckb_remocao.UseVisualStyleBackColor = true;
            this.ckb_remocao.CheckedChanged += new System.EventHandler(this.ckb_remocao_CheckedChanged);
            // 
            // ckb_insercao
            // 
            this.ckb_insercao.AutoSize = true;
            this.ckb_insercao.Location = new System.Drawing.Point(58, 29);
            this.ckb_insercao.Name = "ckb_insercao";
            this.ckb_insercao.Size = new System.Drawing.Size(77, 20);
            this.ckb_insercao.TabIndex = 8;
            this.ckb_insercao.Text = "Inserção";
            this.ckb_insercao.UseVisualStyleBackColor = true;
            this.ckb_insercao.CheckedChanged += new System.EventHandler(this.ckb_insercao_CheckedChanged);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(64, 63);
            this.txt_id.Name = "txt_id";
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_id.Size = new System.Drawing.Size(253, 26);
            this.txt_id.TabIndex = 7;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(27, 66);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(31, 19);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "ID:";
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.Red;
            this.btn_remover.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.ForeColor = System.Drawing.Color.White;
            this.btn_remover.Location = new System.Drawing.Point(237, 266);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(100, 33);
            this.btn_remover.TabIndex = 5;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.BackColor = System.Drawing.Color.Green;
            this.btn_inserir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.ForeColor = System.Drawing.Color.White;
            this.btn_inserir.Location = new System.Drawing.Point(11, 266);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(100, 33);
            this.btn_inserir.TabIndex = 4;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(92, 171);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(225, 26);
            this.txt_email.TabIndex = 3;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(27, 174);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(57, 19);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email:";
            // 
            // txt_nome_professor
            // 
            this.txt_nome_professor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_professor.Location = new System.Drawing.Point(190, 116);
            this.txt_nome_professor.Name = "txt_nome_professor";
            this.txt_nome_professor.Size = new System.Drawing.Size(127, 26);
            this.txt_nome_professor.TabIndex = 1;
            // 
            // lbl_nome_professor
            // 
            this.lbl_nome_professor.AutoSize = true;
            this.lbl_nome_professor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_professor.Location = new System.Drawing.Point(27, 119);
            this.lbl_nome_professor.Name = "lbl_nome_professor";
            this.lbl_nome_professor.Size = new System.Drawing.Size(157, 19);
            this.lbl_nome_professor.TabIndex = 0;
            this.lbl_nome_professor.Text = "Nome do Professor";
            // 
            // lsb_professores_cadastrados
            // 
            this.lsb_professores_cadastrados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lsb_professores_cadastrados.FormattingEnabled = true;
            this.lsb_professores_cadastrados.HorizontalScrollbar = true;
            this.lsb_professores_cadastrados.Location = new System.Drawing.Point(403, 96);
            this.lsb_professores_cadastrados.Name = "lsb_professores_cadastrados";
            this.lsb_professores_cadastrados.Size = new System.Drawing.Size(379, 329);
            this.lsb_professores_cadastrados.TabIndex = 7;
            // 
            // grp_professores_cadastrados
            // 
            this.grp_professores_cadastrados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_professores_cadastrados.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_professores_cadastrados.Location = new System.Drawing.Point(397, 70);
            this.grp_professores_cadastrados.Name = "grp_professores_cadastrados";
            this.grp_professores_cadastrados.Size = new System.Drawing.Size(391, 368);
            this.grp_professores_cadastrados.TabIndex = 12;
            this.grp_professores_cadastrados.TabStop = false;
            this.grp_professores_cadastrados.Text = "Professores Cadastrados:";
            // 
            // frm_professores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grp_link_nsa);
            this.Controls.Add(this.grp_cadastro_professores);
            this.Controls.Add(this.lsb_professores_cadastrados);
            this.Controls.Add(this.lbl_voltar);
            this.Controls.Add(this.lbl_titulo_informacoes);
            this.Controls.Add(this.grp_professores_cadastrados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_professores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema: Escola - Professores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grp_link_nsa.ResumeLayout(false);
            this.grp_link_nsa.PerformLayout();
            this.grp_cadastro_professores.ResumeLayout(false);
            this.grp_cadastro_professores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_informacoes;
        private System.Windows.Forms.Label lbl_voltar;
        private System.Windows.Forms.GroupBox grp_link_nsa;
        private System.Windows.Forms.LinkLabel lklbl_nsa;
        private System.Windows.Forms.GroupBox grp_cadastro_professores;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.CheckBox ckb_remocao;
        private System.Windows.Forms.CheckBox ckb_insercao;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_nome_professor;
        private System.Windows.Forms.Label lbl_nome_professor;
        private System.Windows.Forms.ListBox lsb_professores_cadastrados;
        private System.Windows.Forms.TextBox txt_disciplinas;
        private System.Windows.Forms.Label lbl_disciplinas;
        private System.Windows.Forms.GroupBox grp_professores_cadastrados;
    }
}