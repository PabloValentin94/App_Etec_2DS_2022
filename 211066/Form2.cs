using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using System.Collections; // Precisamos chamar esta classe para usar o ArrayList.



namespace _211066
{

    // Para trocar a opção, basta desmarcar a opção escolhida e depois marcar a outra.

    public partial class frm_alunos : Form
    {

        int id_alunos = 0;

        int indice = 0;

        ArrayList registros_alunos = new ArrayList();

        ArrayList rms = new ArrayList();

        public frm_alunos()
        {

            InitializeComponent();

            lbl_nome_aluno.Enabled = false;
            txt_nome_aluno.Enabled = false;

            lbl_rm.Enabled = false;
            txt_rm.Enabled = false;

            btn_inserir.Enabled = false;

            lbl_id.Enabled = false;
            txt_id.Enabled = false;

            btn_remover.Enabled = false;

            btn_reset.Enabled = false;

            // Cadastrando os alunos já existentes da turma de Desenvolvimento de Sistemas (D.S.), 2º Ano.

            id_alunos++;
            rms.Add("211090");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Adauto Facin Filho / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211084");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Adib Paulini Neto / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211063");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Bianca Camila de Morais / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211077");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Bruno Mazzi Pignatari / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211080");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Bruno Righi / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211071");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Diego Baroni da Silva / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211377");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Edilson Chiodi Junior / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211082");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Eduardo Frasson Domine / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211074");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Gabriel Roberto de Oliveira Siqueira / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211081");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Gabriel Tesser / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211091");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Gabriela Martins da Silva / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211083");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Giovani D Eleuterio Olaia / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211376");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Higor Buttura da Silva / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211087");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Hilary Fernanda Rodrigues da Silva / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211067");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Hugo Buttura da Silva / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211072");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Isabella Moraes Aguiar / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211078");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Isabella Rodrigues de Oliveira / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211092");
            registros_alunos.Add(id_alunos.ToString() + " - " + "João Paulo Franchini de Freitas / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211362");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Julyo Elias Hidalgo da Silva / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211065");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Kaliany Andressa Arrabal Palma / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211068");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Leonardo Fernando Luzetti / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211089");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Lorenzo Fanizzi / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211075");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Luar Akynatom Botelho Burghi / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211375");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Lucas de Alencar Gomes / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211070");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Lucas Gabriel de Paula Pinto / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211085");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Mariane Fernanda Pagagnotti / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211069");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Mateus Gabriel Moreno / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211066");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Pablo Valentin / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211073");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Renato Serrano Mello da Costa / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211076");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Rodrigo Donizete Videira / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211079");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Thiago Miranda Luz de Gino Filho / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            id_alunos++;
            indice++;
            rms.Add("211086");
            registros_alunos.Add(id_alunos.ToString() + " - " + "Victor Roberto Vendrameto / " + rms[indice]);
            lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {

            this.Close(); /* Esse comando é responsável por fechar o formulário,
                           * caso o usuário clique na Label. */

        }

        private void ckb_insercao_CheckedChanged(object sender, EventArgs e)
        {

            ckb_insercao.Enabled = true;

            lbl_nome_aluno.Enabled = true;
            txt_nome_aluno.Enabled = true;

            lbl_rm.Enabled = true;
            txt_rm.Enabled = true;

            btn_inserir.Enabled = true;

            btn_reset.Enabled = true;

            if (ckb_insercao.Checked == true)
            {

                ckb_remocao.Enabled = false;

                lbl_id.Enabled = false;
                txt_id.Enabled = false;

                btn_remover.Enabled = false;

            }

            else if(ckb_insercao.Checked == false & ckb_remocao.Checked == false)
            {

                ckb_insercao.Enabled = true;

                lbl_nome_aluno.Enabled = false;
                txt_nome_aluno.Enabled = false;

                lbl_rm.Enabled = false;
                txt_rm.Enabled = false;

                btn_inserir.Enabled = false;

                ckb_remocao.Enabled = true;

                lbl_id.Enabled = false;
                txt_id.Enabled = false;

                btn_remover.Enabled = false;

                btn_reset.Enabled = false;

            }

            else
            {

                ckb_remocao.Enabled = true;

                lbl_id.Enabled = true;
                txt_id.Enabled = true;

                btn_remover.Enabled = true;

            }

            /* Isso impedirá que o usuário comece a prencher os campos e desmarque a opção escolhida, pois se 
             * o fizer, a(as) caixa(as) de texto será(ão) resetada(as). */

            txt_nome_aluno.Clear();

            txt_rm.Clear();

        }

        private void ckb_remocao_CheckedChanged(object sender, EventArgs e)
        {

            ckb_remocao.Enabled = true;

            lbl_id.Enabled = true;
            txt_id.Enabled = true;

            btn_remover.Enabled = true;

            btn_reset.Enabled = true;

            if (ckb_remocao.Checked == true)
            {

                ckb_insercao.Enabled = false;

                lbl_nome_aluno.Enabled = false;
                txt_nome_aluno.Enabled = false;

                lbl_rm.Enabled = false;
                txt_rm.Enabled = false;

                btn_inserir.Enabled = false;

            }

            else if (ckb_remocao.Checked == false & ckb_insercao.Checked == false)
            {

                ckb_insercao.Enabled = true;

                lbl_nome_aluno.Enabled = false;
                txt_nome_aluno.Enabled = false;

                lbl_rm.Enabled = false;
                txt_rm.Enabled = false;

                btn_inserir.Enabled = false;

                ckb_remocao.Enabled = true;

                lbl_id.Enabled = false;
                txt_id.Enabled = false;

                btn_remover.Enabled = false;

                btn_reset.Enabled = false;

            }

            else
            {

                ckb_insercao.Enabled = true;

                lbl_nome_aluno.Enabled = true;
                txt_nome_aluno.Enabled = true;

                lbl_rm.Enabled = true;
                txt_rm.Enabled = true;

                btn_inserir.Enabled = true;

            }

            /* Isso impedirá que o usuário comece a prencher os campos e desmarque a opção escolhida, pois se 
             * o fizer, a(as) caixa(as) de texto será(ão) resetada(as). */

            txt_id.Clear();

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {

            /* Apesar do sistema já forçar o usuário a escolher uma opção antes de digitar, 
             * caso ele consiga burlar isso de alguma forma,
             * essa estrutura impedirá que ele consiga pressionar o botão de inserir/remover 
             * antes de escolher uma das duas opções. 
             * Essa estrutura só serve como garantia. */

            if (ckb_remocao.Checked == false & ckb_insercao.Checked == false)
            {

                MessageBox.Show("Escolha uma opção primeiro!");

            }

            /* Se o usuário apertar o botão sem preencher todos os campos exigidos, 
             * o sistema exibirá uma mensagem ao usuário.
             * Existe uma mensagem diferente para cada caso. */

            if (txt_nome_aluno.Text == "" & txt_rm.Text == "")
            {

                MessageBox.Show("Preencha os campos Nome do Aluno e R.M., para prosseguir!");

            }

            else if(txt_nome_aluno.Text == "")
            {

                MessageBox.Show("Preencha o campo Nome do Aluno, para prosseguir!");

            }

            else if(txt_rm.Text == "")
            {

                MessageBox.Show("Preencha o campo R.M., para prosseguir!");

            }

            else
            {

                string nome_aluno = txt_nome_aluno.Text;

                string rm_aluno = txt_rm.Text;

                id_alunos++;

                indice++;

                rms.Add(rm_aluno);

                registros_alunos.Add(id_alunos.ToString() + " - " + nome_aluno + " / " + rm_aluno);

                lsb_alunos_cadastrados.Items.Add(registros_alunos[indice]);

            }

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {

            /* Apesar do sistema já forçar o usuário a escolher uma opção antes de digitar, 
             * caso ele consiga burlar isso de alguma forma,
             * essa estrutura impedirá que ele consiga pressionar o botão de inserir/remover 
             * antes de escolher uma das duas opções. 
             * Essa estrutura só serve como garantia. */

            if (ckb_remocao.Checked == false & ckb_insercao.Checked == false)
            {

                MessageBox.Show("Escolha uma opção primeiro!");

            }

            // Se o campo ID estiver em branco, o sistema exibirá uma mensagem ao usuário.

            if (txt_id.Text == "")
            {

                MessageBox.Show("Preencha o campo ID, para prosseguir!");

            }

            else
            {

                /* Barrando o usuário, caso a ID seja inexistente. */

                if (double.Parse(txt_id.Text) > registros_alunos.Count)
                {

                    MessageBox.Show("Insira uma ID válida!");

                }

                else
                {

                    int id = int.Parse(txt_id.Text);

                    lsb_alunos_cadastrados.Items.Remove(registros_alunos[id - 1]);

                }

            }

        }

        private void lklbl_nsa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("https://nsa.cps.sp.gov.br"); /* Aqui estamos especificando
                                                                            * o link da página que deve
                                                                            * ser aberta, após a LinkLabel 
                                                                            * ser clicada. */

            lklbl_nsa.LinkVisited = true;

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            // Desmarcando as CheckBoxes:

            ckb_insercao.Checked = false;

            ckb_remocao.Checked = false;

            // Elementos Visuais:

            txt_id.Clear();

            txt_nome_aluno.Clear();

            txt_rm.Clear();

        }
    }
}
