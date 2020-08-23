using ControleGasto.Entity;
using ControleGasto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleGasto.View
{
    public partial class frmCadastroAno : Form
    {
        Anos objeto = new Anos();

        public frmCadastroAno()
        {
            InitializeComponent();
            Lista();
        }

        private void Lista()
        {
            try
            {
                List<Anos> lista = new List<Anos>();
                lista = new AnoModel().Lista();
                dgAno.DataSource = lista;
                dgAno.Columns[0].Visible = false; // Oculta a primeira coluna da tabela.
                dgAno.Columns[1].HeaderText = "Ano";
                dgAno.Columns[1].DefaultCellStyle.BackColor = Color.DarkGray;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível montar sua lista! Erro: {ex}");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true; // Libera o botão de salvar
            txtAno.Enabled = true; // Libera o campo para edição.
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            // Verifica se o campo ano esta vazio.
            if (txtAno.Text == string.Empty)
            {
                MessageBox.Show("Insira um ano!");
                return;
            }

            // Executa o método para salvar
            Salvar();

            btnSalvar.Enabled = false; // Desabilita o botão.
            txtAno.Enabled = false; // Desabilita o campo de texto.
            txtAno.Text = string.Empty; // Deixa o campo vazio.
            Lista();
        }

        private void Salvar()
        {
            try
            {


                objeto.Ano = Convert.ToInt32(txtAno.Text);
                int retorno = AnoModel.Inserir(objeto); // Inseri o valor do objeto.

                // Verifica se a informação foi inserida.
                if (retorno > 0)
                {
                    MessageBox.Show($"O ano {objeto.Ano} foi inserido em nossa base de dados :)");
                }
                else
                {
                    MessageBox.Show($"O valor digitado ({objeto.Ano}) não foi inserido em nossa base, tente novamente ou contate o suporte.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"O valor digitado ({objeto.Ano}) não foi inserido em nossa base. -> Mensagem do erro {ex}");
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {

                // Verifica se o meu campo txt é vazio e lista todas as informações.
                if (txtPesquisar.Text == string.Empty)
                {
                    Lista();
                    return;
                }

                objeto.Ano = Convert.ToInt32(txtPesquisar.Text);
                List<Anos> lista = new List<Anos>();
                lista = new AnoModel().Buscar(objeto);
                dgAno.AutoGenerateColumns = false;
                dgAno.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocorreu um erro ao pesquisar, Erro: {ex}");
            }
        }

        private void dgAno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAnoId.Text = dgAno.CurrentRow.Cells[0].Value.ToString();
            txtAno.Text = dgAno.CurrentRow.Cells[1].Value.ToString();
            txtAno.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAno.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, selecione um ano para editar.");
                    return;
                }

                Editar();

                btnSalvar.Enabled = false;
                txtAno.Enabled = false;
                txtAno.Text = string.Empty;
                Lista();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao tentar editar o registro: {ex}");
            }
        }

        private void Editar()
        {
            try
            {
                objeto.Ano = Convert.ToInt32(txtAno.Text);
                objeto.AnoId = Convert.ToInt32(txtAnoId.Text);
                int retorno = AnoModel.Alterar(objeto);
                if (retorno > 0)
                {
                    MessageBox.Show($"Ano {objeto.Ano} alterado com sucesso :)");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ano {objeto.Ano} não foi alterado devido ao erro {ex}!");
            }
        }

       

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtAnoId.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, selecione o ano para a exclusão.");
                    return;
                }

                Excluir();

                btnSalvar.Enabled = false;
                txtAno.Enabled = false;
                txtAno.Text = string.Empty;
                Lista();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao tentar excluir o registro: {ex}");
            }
        }

        private void Excluir()
        {
            try
            {
                objeto.AnoId = Convert.ToInt32(txtAnoId.Text);
                int retorno = AnoModel.Excluir(objeto);
                if (retorno > 0)
                {
                    MessageBox.Show($"Ano {objeto.Ano} excluido com sucesso :)");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ano {objeto.Ano} não foi excluido devido ao erro {ex}!");
            }
        }
    }
}
