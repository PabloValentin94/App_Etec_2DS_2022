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
    public partial class frm_principal : Form
    {

        /* Ao declararmos esses formulários como públicos, permitimos ao usuário que, caso ele clique em voltar, e depois abra o mesmo
         * formulário novamente, as alterações não sejam resetadas (o usuário poderá continuar de onde parou).
         * O formulário só será realmente resetado, quando a aplicação for fechada. */

        frm_alunos formulario_alunos = new frm_alunos();

        frm_professores formulario_professores = new frm_professores();

        public frm_principal()
        {

            InitializeComponent();

        }

        private void btn_alunos_Click(object sender, EventArgs e)
        {

            formulario_alunos.ShowDialog(); // Chamando um formulário público.

        }

        private void btn_professores_Click(object sender, EventArgs e)
        {

            formulario_professores.ShowDialog(); // Chamando um formulário público.

        }

        private void btn_informacoes_Click(object sender, EventArgs e)
        {

            new frm_informacoes().ShowDialog(); /* Como esse formulário não possui nada que será alterado, ele pode ser declarado dentro 
                                                 * do prórpio método. */

        }

        private void btn_nsa_Click(object sender, EventArgs e)
        {

            new frm_nsa().ShowDialog(); /* Como esse formulário não possui nada que será alterado, ele pode ser declarado dentro 
                                         * do prórpio método. */

        }
    }
}
