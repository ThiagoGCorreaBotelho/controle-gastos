namespace ControleGasto.View
{
    partial class frmLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamentos));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgLancamento = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPesquisarData = new System.Windows.Forms.DateTimePicker();
            this.lblDataLancamento = new System.Windows.Forms.Label();
            this.dtDataLancamento = new System.Windows.Forms.DateTimePicker();
            this.rbBuscarData = new System.Windows.Forms.RadioButton();
            this.rbBuscarPorTipo = new System.Windows.Forms.RadioButton();
            this.cbBuscarTipo = new System.Windows.Forms.ComboBox();
            this.txtLancamentoId = new System.Windows.Forms.TextBox();
            this.lblTotalLancamento = new System.Windows.Forms.Label();
            this.lblLancamentoTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLancamento)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(250, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(349, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(144, 468);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(41, 468);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgLancamento
            // 
            this.dgLancamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgLancamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLancamento.Location = new System.Drawing.Point(41, 227);
            this.dgLancamento.Name = "dgLancamento";
            this.dgLancamento.Size = new System.Drawing.Size(638, 235);
            this.dgLancamento.TabIndex = 2;
            this.dgLancamento.Text = "dataGridView1";
            this.dgLancamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLancamento_CellClick);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDescricao.Location = new System.Drawing.Point(111, 158);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(311, 26);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(32, 160);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(73, 20);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.ForeColor = System.Drawing.SystemColors.Window;
            this.txtValor.Location = new System.Drawing.Point(493, 158);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(115, 26);
            this.txtValor.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(443, 160);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(44, 20);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(16, 117);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.ForeColor = System.Drawing.Color.White;
            this.lblMes.Location = new System.Drawing.Point(241, 117);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(39, 20);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mês:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.ForeColor = System.Drawing.Color.White;
            this.lblAno.Location = new System.Drawing.Point(468, 117);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(37, 20);
            this.lblAno.TabIndex = 0;
            this.lblAno.Text = "Ano:";
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.cbTipo.ForeColor = System.Drawing.SystemColors.Window;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbTipo.Location = new System.Drawing.Point(61, 114);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(149, 28);
            this.cbTipo.TabIndex = 4;
            // 
            // cbMes
            // 
            this.cbMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.cbMes.ForeColor = System.Drawing.SystemColors.Window;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(286, 114);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(149, 28);
            this.cbMes.TabIndex = 4;
            // 
            // cbAno
            // 
            this.cbAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.cbAno.ForeColor = System.Drawing.SystemColors.Window;
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(511, 114);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(168, 28);
            this.cbAno.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(451, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar:";
            // 
            // dtPesquisarData
            // 
            this.dtPesquisarData.CalendarMonthBackground = System.Drawing.SystemColors.Desktop;
            this.dtPesquisarData.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtPesquisarData.Enabled = false;
            this.dtPesquisarData.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPesquisarData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPesquisarData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtPesquisarData.Location = new System.Drawing.Point(530, 32);
            this.dtPesquisarData.Name = "dtPesquisarData";
            this.dtPesquisarData.Size = new System.Drawing.Size(149, 25);
            this.dtPesquisarData.TabIndex = 2;
            this.dtPesquisarData.Value = new System.DateTime(2020, 8, 21, 0, 0, 0, 0);
            this.dtPesquisarData.ValueChanged += new System.EventHandler(this.dtPesquisarData_ValueChanged);
            // 
            // lblDataLancamento
            // 
            this.lblDataLancamento.AutoSize = true;
            this.lblDataLancamento.ForeColor = System.Drawing.Color.White;
            this.lblDataLancamento.Location = new System.Drawing.Point(32, 198);
            this.lblDataLancamento.Name = "lblDataLancamento";
            this.lblDataLancamento.Size = new System.Drawing.Size(39, 20);
            this.lblDataLancamento.TabIndex = 0;
            this.lblDataLancamento.Text = "Data:";
            // 
            // dtDataLancamento
            // 
            this.dtDataLancamento.CalendarMonthBackground = System.Drawing.SystemColors.Desktop;
            this.dtDataLancamento.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtDataLancamento.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataLancamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtDataLancamento.Location = new System.Drawing.Point(111, 194);
            this.dtDataLancamento.Name = "dtDataLancamento";
            this.dtDataLancamento.Size = new System.Drawing.Size(130, 25);
            this.dtDataLancamento.TabIndex = 2;
            this.dtDataLancamento.Value = new System.DateTime(2020, 8, 21, 0, 0, 0, 0);
            // 
            // rbBuscarData
            // 
            this.rbBuscarData.AutoSize = true;
            this.rbBuscarData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbBuscarData.Location = new System.Drawing.Point(89, 32);
            this.rbBuscarData.Name = "rbBuscarData";
            this.rbBuscarData.Size = new System.Drawing.Size(121, 24);
            this.rbBuscarData.TabIndex = 5;
            this.rbBuscarData.TabStop = true;
            this.rbBuscarData.Text = "Buscar por data";
            this.rbBuscarData.UseVisualStyleBackColor = true;
            this.rbBuscarData.CheckedChanged += new System.EventHandler(this.rbBuscarData_CheckedChanged);
            // 
            // rbBuscarPorTipo
            // 
            this.rbBuscarPorTipo.AutoSize = true;
            this.rbBuscarPorTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbBuscarPorTipo.Location = new System.Drawing.Point(317, 32);
            this.rbBuscarPorTipo.Name = "rbBuscarPorTipo";
            this.rbBuscarPorTipo.Size = new System.Drawing.Size(118, 24);
            this.rbBuscarPorTipo.TabIndex = 5;
            this.rbBuscarPorTipo.TabStop = true;
            this.rbBuscarPorTipo.Text = "Buscar por tipo";
            this.rbBuscarPorTipo.UseVisualStyleBackColor = true;
            this.rbBuscarPorTipo.CheckedChanged += new System.EventHandler(this.rbBuscarPorTipo_CheckedChanged);
            // 
            // cbBuscarTipo
            // 
            this.cbBuscarTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.cbBuscarTipo.ForeColor = System.Drawing.SystemColors.Window;
            this.cbBuscarTipo.FormattingEnabled = true;
            this.cbBuscarTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbBuscarTipo.Location = new System.Drawing.Point(530, 29);
            this.cbBuscarTipo.Name = "cbBuscarTipo";
            this.cbBuscarTipo.Size = new System.Drawing.Size(149, 28);
            this.cbBuscarTipo.TabIndex = 4;
            this.cbBuscarTipo.Visible = false;
            this.cbBuscarTipo.SelectedIndexChanged += new System.EventHandler(this.cbBuscarTipo_SelectedIndexChanged);
            this.cbBuscarTipo.SelectionChangeCommitted += new System.EventHandler(this.cbBuscarTipo_SelectionChangeCommitted);
            // 
            // txtLancamentoId
            // 
            this.txtLancamentoId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtLancamentoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLancamentoId.Enabled = false;
            this.txtLancamentoId.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLancamentoId.Location = new System.Drawing.Point(614, 158);
            this.txtLancamentoId.Name = "txtLancamentoId";
            this.txtLancamentoId.Size = new System.Drawing.Size(65, 26);
            this.txtLancamentoId.TabIndex = 1;
            // 
            // lblTotalLancamento
            // 
            this.lblTotalLancamento.AutoSize = true;
            this.lblTotalLancamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalLancamento.ForeColor = System.Drawing.Color.White;
            this.lblTotalLancamento.Location = new System.Drawing.Point(451, 473);
            this.lblTotalLancamento.Name = "lblTotalLancamento";
            this.lblTotalLancamento.Size = new System.Drawing.Size(168, 19);
            this.lblTotalLancamento.TabIndex = 0;
            this.lblTotalLancamento.Text = "Total de lançamento:";
            // 
            // lblLancamentoTotal
            // 
            this.lblLancamentoTotal.AutoSize = true;
            this.lblLancamentoTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLancamentoTotal.ForeColor = System.Drawing.Color.White;
            this.lblLancamentoTotal.Location = new System.Drawing.Point(625, 473);
            this.lblLancamentoTotal.Name = "lblLancamentoTotal";
            this.lblLancamentoTotal.Size = new System.Drawing.Size(18, 19);
            this.lblLancamentoTotal.TabIndex = 0;
            this.lblLancamentoTotal.Text = "0";
            // 
            // frmLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(712, 525);
            this.Controls.Add(this.lblLancamentoTotal);
            this.Controls.Add(this.lblTotalLancamento);
            this.Controls.Add(this.txtLancamentoId);
            this.Controls.Add(this.cbBuscarTipo);
            this.Controls.Add(this.rbBuscarPorTipo);
            this.Controls.Add(this.rbBuscarData);
            this.Controls.Add(this.dtDataLancamento);
            this.Controls.Add(this.lblDataLancamento);
            this.Controls.Add(this.dtPesquisarData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dgLancamento);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmLancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LANÇAMENTOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgLancamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgLancamento;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPesquisarData;
        private System.Windows.Forms.Label lblDataLancamento;
        private System.Windows.Forms.DateTimePicker dtDataLancamento;
        private System.Windows.Forms.RadioButton rbBuscarData;
        private System.Windows.Forms.RadioButton rbBuscarPorTipo;
        private System.Windows.Forms.ComboBox cbBuscarTipo;
        private System.Windows.Forms.TextBox txtLancamentoId;
        private System.Windows.Forms.Label lblTotalLancamento;
        private System.Windows.Forms.Label lblLancamentoTotal;
    }
}