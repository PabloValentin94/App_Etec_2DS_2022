using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211066
{
    public partial class frm_nsa : Form
    {
        public frm_nsa()
        {
            InitializeComponent();
        }

        private void pcbx_nsa_online_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://nsa.cps.sp.gov.br"); /* Aqui estamos especificando
                                                                           * o link da página que deve
                                                                           * ser aberta, após a PictureBox 
                                                                           * (imagem) ser clicada. */

        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {

            this.Close(); /* Esse comando é responsável por fechar o formulário,
                           * caso o usuário clique na Label. */

        }
    }
}
