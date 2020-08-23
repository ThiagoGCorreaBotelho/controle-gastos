using ControleGasto.Entity;
using ControleGasto.Model;
using ControleGasto.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleGasto
{
    public partial class Principal : Form
    {

        // Declaração do objeto
        Lancamento objetoEntity = new Lancamento();

        #region Construtor
        public Principal()
        {
            InitializeComponent();
            Lista();
            TotalizarEntrada();

        }



        #endregion

        #region Utéis

        private void TotalizarEntrada()
        {
            decimal total = ValorTotalEntradas() - ValorTotalSaidas();
            lblValorSaldoTotalEntrada.Text = ValorTotalEntradas().ToString();
            lblValorSaldoTotal.Text = total.ToString();

            if (Convert.ToDecimal(lblValorSaldoTotalEntrada.Text) == 0)
            {
                lblValorSaldoTotalEntrada.Text = $"Sem Lançamentos!";
            }

            // Verifica se é saldo positivo ou negativo, e atribui as cores;
            if (Convert.ToDecimal(lblValorSaldoTotal.Text) < 0)
            {
                lblValorSaldoTotal.ForeColor = Color.Red;
            }
            else if (Convert.ToDecimal(lblValorSaldoTotal.Text) == 0)
            {
                lblValorSaldoTotal.Text = $"Sem lançamentos para o dia {DateTime.Today.ToShortDateString()}";
            }
            else
            {
                lblValorSaldoTotal.ForeColor = Color.SeaGreen;
            }
        }

        private void TotalizarSaida()
        {
            lblValorSaldoTotalSaida.Text = ValorTotalSaidas().ToString();


            if (Convert.ToDecimal(lblValorSaldoTotalSaida.Text) == 0)
            {
                lblValorSaldoTotalSaida.Text = $"Sem Lançamentos!";
            }
        }

        private decimal ValorTotalEntradas()
        {
            decimal total = 0;
            int i = 0;

            for (i = 0; i < dgEntrada.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgEntrada.Rows[i].Cells[3].Value);
            }

            return total;
        }

        private decimal ValorTotalSaidas()
        {
            decimal total = 0;
            int i = 0;

            for (i = 0; i < dgSaida.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgSaida.Rows[i].Cells[3].Value);
            }

            return total;
        }


        #endregion

        #region Método

        private void Lista()
        {
            try
            {
                List<Lancamento> listaEntity = new List<Lancamento>();

                dgEntrada.DataSource = listaEntity;
                dgEntrada.Columns[0].Visible = false;
                dgEntrada.Columns[4].Visible = false;
                dgEntrada.Columns[5].Visible = false;
                //dgEntrada.Columns[6].Visible = false;
                dgEntrada.Columns[1].Visible = false;

                dgEntrada.Columns[1].HeaderText = "Tipo";
                dgEntrada.Columns[2].HeaderText = "Descrição";
                dgEntrada.Columns[2].Width = 145;
                dgEntrada.Columns[3].HeaderText = "Valor";
                dgEntrada.Columns[6].HeaderText = "Data";

                dgSaida.DataSource = listaEntity;
                dgSaida.Columns[0].Visible = false;
                dgSaida.Columns[4].Visible = false;
                dgSaida.Columns[5].Visible = false;
                //dgSaida.Columns[6].Visible = false;
                dgSaida.Columns[1].Visible = false;

                dgSaida.Columns[1].HeaderText = "Tipo";
                dgSaida.Columns[2].HeaderText = "Descrição";
                dgSaida.Columns[2].Width = 131;
                dgSaida.Columns[3].HeaderText = "Valor";
                dgSaida.Columns[6].HeaderText = "Data";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro de tratamento (Método: ListaEntradas || Classe Principal.cs) Erro: {ex}");
            }
        }

        private void Buscar()
        {

            try
            {

                objetoEntity.Data = Convert.ToDateTime(dtPesquidaDataDashGastos.Text);
                // objetoEntity.Tipo = "Entrada";

                List<Lancamento> listaEntrada = new List<Lancamento>();
                listaEntrada = new LancamentoModel().BuscarDataTipoEntrada(objetoEntity);


                // Para grid de entrada
                dgEntrada.AutoGenerateColumns = false;
                dgEntrada.DataSource = listaEntrada;

                // Para grid de saída
                List<Lancamento> listaSaida = new List<Lancamento>();
                dgSaida.DataSource = listaSaida;
                listaSaida = new LancamentoModel().BuscarDataTipoSaida(objetoEntity);

                dgSaida.AutoGenerateColumns = false;
                dgSaida.DataSource = listaSaida;

                TotalizarEntrada();
                TotalizarSaida();


            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no tratamento de dados! (Método: Buscar || Classe: Principal.cs)");

            }
        }

        #endregion

        #region Eventos

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmCadastroAno frm = new frmCadastroAno();
            frm.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmCadastroAno frm = new frmCadastroAno();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            frmCadastroAno frm = new frmCadastroAno();
            frm.ShowDialog();
        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            frmCadastroAno frm = new frmCadastroAno();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {
            frmCadastroAno frm = new frmCadastroAno();
            frm.ShowDialog();
        }

        private void subMenuAno_Click(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void picAno_Click(object sender, EventArgs e)
        {
            frmCadastroAno frm = new frmCadastroAno();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLancamentos frm = new frmLancamentos();
            frm.ShowDialog();
        }

        // Evento para buscar por data
        private void dtPesquidaDataDashGastos_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void dtPesquidaDataDashGastos_Enter(object sender, EventArgs e)
        {
            dtPesquidaDataDashGastos.Text = DateTime.Now.ToString();
        }

        private void Principal_Click(object sender, EventArgs e)
        {
            ;// Buscar();
        }


        #endregion

        private void Principal_Load(object sender, EventArgs e)
        {
            //Buscar();
        }

        private void Principal_Activated(object sender, EventArgs e)
        {
            Buscar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
