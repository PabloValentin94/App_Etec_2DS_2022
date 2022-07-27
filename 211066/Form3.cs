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
    public partial class frm_professores : Form
    {

        int id_professores = 0;

        int indice = 0;

        ArrayList registros_professores = new ArrayList();

        public frm_professores()
        {

            InitializeComponent();

            lbl_nome_professor.Enabled = false;
            txt_nome_professor.Enabled = false;

            lbl_email.Enabled = false;
            txt_email.Enabled = false;

            lbl_disciplinas.Enabled = false;
            txt_disciplinas.Enabled = false;

            btn_inserir.Enabled = false;

            lbl_id.Enabled = false;
            txt_id.Enabled = false;

            btn_remover.Enabled = false;

            btn_reset.Enabled = false;

            // Cadastrando todos os professores que já deram aula para a turma de Desenvolvimento de Sistemas (D.S.), Atual 2º Ano,
            // com excessão dos que saíram da escola.

            id_professores++;
            registros_professores.Add(id_professores.ToString() + " - " + "Ana Sheila do Couto Trindade Moraco" + " / " + 
            "Desconhecido" + " / " + "Artes");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "André Pignatti Zago" + " / " +
            "Desconhecido" + " / " + "Análise de Sistemas");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Charles Sangiorgi Sartori" + " / " +
            "Desconhecido" + " / " + "Desenvolvimento de Sistemas; Sistemas Embarcados");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Dalva Fiorillo Lopes" + " / " +
            "cp@etecjau.com.br" + " / " + "Matemática");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Eder Alexandro de Lima" + " / " +
            "eder.lima25@etec.sp.gov.br" + " / " + "Fundamentos da Informática; Design Digital; Sistemas Embarcados");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Everton Gonzales Sette" + " / " +
            "Desconhecido" + " / " + "Desenvolvimento de Sistemas");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Gustavo da Fonseca" + " / " +
            "fonseca.guh@gmail.com" + " / " + "Biologia");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Joice Ferreira Nicola" + " / " +
            "joiceferreiranicola@gmail.com" + " / " + "Inglês");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Marcelo Sabbadini Francisco" + " / " +
            "marcelo.francisco6@etec.sp.gov.br" + " / " + "Matemática; Matemática Financeira");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Márcia Regina Seresuela Zugliani" + " / " +
            "Desconhecido" + " / " + "Educação Física");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Marcos Rogério Pagagnotti" + " / " +
            "Desconhecido" + " / " + "Programação Web; Banco de Dados; Programação Mobile");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Maria Ivone Chagas" + " / " +
            "Desconhecido" + " / " + "Geografia");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Osmar Martins Floret Junior" + " / " +
            "Desconhecido" + " / " + "Química");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Pâmela Cristiane Rabaldelli" + " / " +
            "pan  rabaldelli@hotmail.com" + " / " + "Língua Portuguesa e Literatura");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Rafael Martins Sanches" + " / " +
            "rafael.sanches7@etec.sp.gov.br" + " / " + "Geografia");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Rinaldo dos Santos" + " / " +
            "Desconhecido" + " / " + "História");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Sérgio Eduardo Cirilo Vieira" + " / " +
            "Desconhecido" + " / " + "Ética e Cidadania Organizacional");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Solange Maria Cacador" + " / " +
            "solange.cacador@etec.sp.gov.br" + " / " + "Filosofia; Sociologia");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Telma Juliana Silva" + " / " +
            "Desconhecido" + " / " + "Programação Web; Análise de Sistemas");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Thiago Pignatti de Freitas" + " / " +
            "tgpignatti@gmail.com" + " / " + "Física");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

            id_professores++;
            indice++;
            registros_professores.Add(id_professores.ToString() + " - " + "Tiago Antônio da Silva" + " / " +
            "Desconhecido" + " / " + "Técnicas de Programação e Algoritmos; Banco de Dados; Programação Web; Programação Mobile");
            lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {

            this.Close(); /* Esse comando é responsável por fechar o formulário,
                           * caso o usuário clique na Label. */

        }

        private void ckb_insercao_CheckedChanged(object sender, EventArgs e)
        {

            ckb_insercao.Enabled = true;

            lbl_nome_professor.Enabled = true;
            txt_nome_professor.Enabled = true;

            lbl_email.Enabled = true;
            txt_email.Enabled = true;

            lbl_disciplinas.Enabled = true;
            txt_disciplinas.Enabled = true;

            btn_inserir.Enabled = true;

            btn_reset.Enabled = true;

            if (ckb_insercao.Checked == true)
            {

                ckb_remocao.Enabled = false;

                lbl_id.Enabled = false;
                txt_id.Enabled = false;

                btn_remover.Enabled = false;

            }

            else if (ckb_insercao.Checked == false & ckb_remocao.Checked == false)
            {

                ckb_insercao.Enabled = true;

                lbl_nome_professor.Enabled = false;
                txt_nome_professor.Enabled = false;

                lbl_email.Enabled = false;
                txt_email.Enabled = false;

                lbl_disciplinas.Enabled = false;
                txt_disciplinas.Enabled = false;

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

            txt_nome_professor.Clear();

            txt_email.Clear();

            txt_disciplinas.Clear();

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

                lbl_nome_professor.Enabled = false;
                txt_nome_professor.Enabled = false;

                lbl_email.Enabled = false;
                txt_email.Enabled = false;

                lbl_disciplinas.Enabled = false;
                txt_disciplinas.Enabled = false;

                btn_inserir.Enabled = false;

            }

            else if (ckb_remocao.Checked == false & ckb_insercao.Checked == false)
            {

                ckb_insercao.Enabled = true;

                lbl_nome_professor.Enabled = false;
                txt_nome_professor.Enabled = false;

                lbl_email.Enabled = false;
                txt_email.Enabled = false;

                lbl_disciplinas.Enabled = false;
                txt_disciplinas.Enabled = false;

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

                lbl_nome_professor.Enabled = true;
                txt_nome_professor.Enabled = true;

                lbl_email.Enabled = true;
                txt_email.Enabled = true;

                lbl_disciplinas.Enabled = true;
                txt_disciplinas.Enabled = true;

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

            if(txt_nome_professor.Text == "" & txt_email.Text == "" & txt_disciplinas.Text == "")
            {

                MessageBox.Show("Preencha os campos Nome do Professor, Email e Disciplina(as), para " +
                "prosseguir!");

            }

            else if(txt_nome_professor.Text == "" & txt_email.Text == "")
            {

                MessageBox.Show("Preencha os campos Nome do Professor e Email, para prosseguir!");

            }
            
            else if(txt_nome_professor.Text == "" & txt_disciplinas.Text == "")
            {

                MessageBox.Show("Preencha os campos Nome do Professor e Disciplina(as), para prosseguir!");

            }

            else if(txt_email.Text == "" & txt_disciplinas.Text == "")
            {

                MessageBox.Show("Preencha os campos Email e Disciplina(as), para prosseguir!");

            }

            else if(txt_nome_professor.Text == "")
            {

                MessageBox.Show("Preencha o campo Nome do Professor, para prosseguir!");

            }

            else if(txt_email.Text == "")
            {

                MessageBox.Show("Preencha o campo Email, para prosseguir!");

            }

            else if(txt_disciplinas.Text == "")
            {

                MessageBox.Show("Preencha o campo Disciplina(as), para prosseguir!");

            }

            else
            {

                string nome_professor = txt_nome_professor.Text;

                string email_professor = txt_email.Text;

                string disciplinas_professor = txt_disciplinas.Text;

                id_professores++;

                indice++;

                registros_professores.Add(id_professores.ToString() + " - " + nome_professor + 
                " / " + email_professor + " / " + disciplinas_professor);

                lsb_professores_cadastrados.Items.Add(registros_professores[indice]);

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

                if (double.Parse(txt_id.Text) > registros_professores.Count)
                {

                    MessageBox.Show("Insira uma ID válida!");

                }

                else
                {

                    int id = int.Parse(txt_id.Text);

                    lsb_professores_cadastrados.Items.Remove(registros_professores[id - 1]);

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

            txt_nome_professor.Clear();

            txt_email.Clear();

            txt_disciplinas.Clear();

        }

    }
}
