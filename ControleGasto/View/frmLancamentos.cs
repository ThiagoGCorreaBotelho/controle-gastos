using ControleGasto.Entity;
using ControleGasto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ControleGasto.View
{
    public partial class frmLancamentos : Form
    {
        AnoModel modelAno = new AnoModel();
        Lancamento objeto = new Lancamento();

        #region Construtores

        public frmLancamentos()
        {
            InitializeComponent();
            ListaAno();

            dtDataLancamento.Value = DateTime.Now;
            btnSalvar.Enabled = false;

            DesabilitarCampos();
            Lista();
            Totalizar();
        }

      

        #endregion

        #region Métodos Utéis

        // Desabilita os campos abaixo
        private void DesabilitarCampos()
        {
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            cbTipo.Enabled = false;
            cbMes.Enabled = false;
            cbAno.Enabled = false;
            dtDataLancamento.Enabled = false;
        }

        // Habilita os campos abaixo
        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            cbTipo.Enabled = true;
            cbMes.Enabled = true;
            cbAno.Enabled = true;
            dtDataLancamento.Enabled = true;
        }
        
        // limpa os campos abaixo.
        private void LimparCampos()
        {
            txtDescricao.Text = string.Empty;
            txtValor.Text = string.Empty;
            cbBuscarTipo.Text = string.Empty;
        }

        private decimal ValorTotal()
        {
            decimal total = 0;
            decimal totalEntrada = 0;
            decimal totalSaida = 0;


            int i = 0;
            for (i = 0; i < dgLancamento.Rows.Count; i++)
            {
                if (dgLancamento.Rows[i].Cells[1].Value.ToString() == "Entrada")
                {
                    totalEntrada = totalEntrada + Convert.ToDecimal(dgLancamento.Rows[i].Cells[3].Value);

                }
                else
                {
                    totalSaida = totalSaida + Convert.ToDecimal(dgLancamento.Rows[i].Cells[3].Value);

                }
            }

            return totalEntrada - totalSaida;
        }

        private void Totalizar()
        {
            lblLancamentoTotal.Text = ValorTotal().ToString();

            if (Convert.ToDecimal(lblLancamentoTotal.Text) < 0)
            {
                lblLancamentoTotal.ForeColor = Color.Red;
            }
            else
            {
                lblLancamentoTotal.ForeColor = Color.Green;
            }
        }



        #endregion

        #region CRUD

        // Combo do ano listado
        private void ListaAno()
        {
            cbAno.DataSource = modelAno.Lista();
            cbAno.ValueMember = "AnoId";
            cbAno.DisplayMember = "Ano";
        }

        // Lista os dados na grid
        private void Lista()
        {
            try
            {
                List<Lancamento> lista = new List<Lancamento>();
                lista = new LancamentoModel().Lista();

                dgLancamento.DataSource = lista;
                dgLancamento.Columns[0].Visible = false;
                dgLancamento.Columns[4].Visible = false;
                dgLancamento.Columns[5].Visible = false;
                dgLancamento.Columns[1].HeaderText = "Tipo";
                dgLancamento.Columns[2].HeaderText = "Descrição";
                dgLancamento.Columns[3].HeaderText = "Valor";
                dgLancamento.Columns[6].HeaderText = "Data";
                dgLancamento.Columns[2].Width = 250;
                dgLancamento.Columns[6].Width = 144;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro durante a execuçao do código do método Liista: {ex}");
            }
        }


        //Inseri um novo registro
        private void Salvar()
        {
            try
            {
                objeto.Tipo = cbTipo.Text;
                objeto.Descricao = txtDescricao.Text;
                objeto.Valor = Convert.ToDecimal(txtValor.Text);
                objeto.Mes = cbMes.Text;
                objeto.AnoId = Convert.ToInt32(cbAno.SelectedValue);
                objeto.Data = Convert.ToDateTime(dtDataLancamento.Text);
                int retorno = LancamentoModel.Inserir(objeto);
                if (retorno > 0)
                {
                    MessageBox.Show($"Informações inserida com sucesso :)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro durante a execuçao do código no método salvar do frmLancamentos: {ex}");
            }
        }

        // Altera um novo registro
        private void Editar()
        {
            try
            {
                objeto.Tipo = cbTipo.Text;
                objeto.Descricao = txtDescricao.Text;
                objeto.Valor = Convert.ToDecimal(txtValor.Text);
                objeto.Mes = cbMes.Text;
                objeto.AnoId = Convert.ToInt32(cbAno.SelectedValue);
                objeto.Data = Convert.ToDateTime(dtDataLancamento.Text);
                objeto.LancamentoId = Convert.ToInt32(txtLancamentoId.Text);
                int retorno = LancamentoModel.Alterar(objeto);
                if (retorno > 0)
                {
                    MessageBox.Show($"Informações alerada com sucesso :)");
                }
                else
                {
                    MessageBox.Show($" Falha ao editar as informações!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro durante a execuçao do código no método editar do frmLancamentos: {ex}");
            }
        }

        private void Excluir()
        {
            try
            {
                objeto.LancamentoId = Convert.ToInt32(txtLancamentoId.Text);
                int retorno = LancamentoModel.Excluir(objeto);

                if (retorno > 0)
                {
                    MessageBox.Show("Registro excluido com sucesso!");
                }
                else
                {
                    MessageBox.Show($"Fala ao tentar excluir o registro {objeto.Descricao}!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro de tratamento MÉTODO EXCLUIR -> FRMLANCAMENTOS erro --> {ex}");
            }
        }


        #endregion

        #region Eventos


        private void rbBuscarPorTipo_CheckedChanged(object sender, EventArgs e)
        {
            dtPesquisarData.Visible = false;
            cbBuscarTipo.Visible = true;

        }

        private void rbBuscarData_CheckedChanged(object sender, EventArgs e)
        {
            dtPesquisarData.Value = DateTime.Now;
            dtPesquisarData.Visible = true;
            dtPesquisarData.Enabled = true;
            cbBuscarTipo.Visible = false;
        }

        // Evento de novo registro
        private void button4_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == string.Empty)
            {
                MessageBox.Show("Por favor, insera o valor do lancamento.");
                return;
            }

            Salvar();
            LimparCampos();
            btnSalvar.Enabled = false;
            Lista();
            Totalizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == string.Empty)
            {
                MessageBox.Show($"Por favor, insira o campo valor.");
                txtValor.Focus();
                return;
            }

            Editar();
            LimparCampos();
            btnSalvar.Enabled = false;
            Lista();
            Totalizar();
        }

        private void dgLancamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            txtLancamentoId.Text = dgLancamento.CurrentRow.Cells[0].Value.ToString();
            cbTipo.Text = dgLancamento.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dgLancamento.CurrentRow.Cells[2].Value.ToString();
            txtValor.Text = dgLancamento.CurrentRow.Cells[3].Value.ToString();
            cbMes.Text = dgLancamento.CurrentRow.Cells[4].Value.ToString();
            cbAno.SelectedItem = dgLancamento.CurrentRow.Cells[5].Value.ToString();
            dtDataLancamento.Text = dgLancamento.CurrentRow.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtLancamentoId.Text == string.Empty)
            {
                MessageBox.Show($"Por favor selecione um registro para realizar a exclusão!");
                return;
            }

            Excluir();
            DesabilitarCampos();
            LimparCampos();
            Lista();
            Totalizar();
        }


        private void cbBuscarTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }
        private void cbBuscarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                objeto.Tipo = cbBuscarTipo.Text;
                List<Lancamento> lista = new List<Lancamento>();
                lista = new LancamentoModel().BuscarTipo(objeto);
                dgLancamento.AutoGenerateColumns = false;
                dgLancamento.DataSource = lista;
                Totalizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro de tratamento (Evento cbBuscarTipo_SelectionChangeCommitted no frmLancamento) -> Mensagem: {ex}");
            }
        }

        // Pesquisa por data
        private void dtPesquisarData_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                objeto.Data = Convert.ToDateTime(dtPesquisarData.Text);
                List<Lancamento> lista = new List<Lancamento>();
                lista = new LancamentoModel().Buscar(objeto);
                dgLancamento.AutoGenerateColumns = false;
                dgLancamento.DataSource = lista;
                Totalizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro de tratamento (Evento dtPesquisarData_ValueChanged no frmLancamento) -> Mensagem: {ex}");
            }
        }


        #endregion


    }
}
