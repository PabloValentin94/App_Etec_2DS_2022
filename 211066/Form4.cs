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
    public partial class frm_informacoes : Form
    {
        public frm_informacoes()
        {
            InitializeComponent();
        }

        private void lkl_site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("www.etecjau.com.br"); /* Aqui estamos especificando
                                                                     * o link da página que deve
                                                                     * ser aberta, após a LinkLabel 
                                                                     * ser clicada. */

            lklbl_site.LinkVisited = true;

        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {

            this.Close(); /* Esse comando é responsável por fechar o formulário,
                           * caso o usuário clique na Label. */

        }
    }
}
