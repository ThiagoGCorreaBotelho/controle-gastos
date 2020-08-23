namespace ControleGasto
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.labelLancamentoDia = new System.Windows.Forms.Label();
            this.dtPesquidaDataDashGastos = new System.Windows.Forms.DateTimePicker();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.dgEntrada = new System.Windows.Forms.DataGridView();
            this.dgSaida = new System.Windows.Forms.DataGridView();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.lblValorSaldoTotal = new System.Windows.Forms.Label();
            this.picAno = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorSaldoTotalEntrada = new System.Windows.Forms.Label();
            this.lblTotalEntrada = new System.Windows.Forms.Label();
            this.lblSaldoTotalSaida = new System.Windows.Forms.Label();
            this.lblValorSaldoTotalSaida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLancamentoDia
            // 
            this.labelLancamentoDia.AutoSize = true;
            this.labelLancamentoDia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLancamentoDia.ForeColor = System.Drawing.Color.White;
            this.labelLancamentoDia.Location = new System.Drawing.Point(17, 132);
            this.labelLancamentoDia.Name = "labelLancamentoDia";
            this.labelLancamentoDia.Size = new System.Drawing.Size(130, 20);
            this.labelLancamentoDia.TabIndex = 1;
            this.labelLancamentoDia.Text = "Lançamentos do dia";
            // 
            // dtPesquidaDataDashGastos
            // 
            this.dtPesquidaDataDashGastos.CalendarMonthBackground = System.Drawing.SystemColors.Desktop;
            this.dtPesquidaDataDashGastos.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtPesquidaDataDashGastos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPesquidaDataDashGastos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPesquidaDataDashGastos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtPesquidaDataDashGastos.Location = new System.Drawing.Point(17, 155);
            this.dtPesquidaDataDashGastos.Name = "dtPesquidaDataDashGastos";
            this.dtPesquidaDataDashGastos.Size = new System.Drawing.Size(130, 25);
            this.dtPesquidaDataDashGastos.TabIndex = 2;
            this.dtPesquidaDataDashGastos.Value = new System.DateTime(2020, 8, 21, 0, 0, 0, 0);
            this.dtPesquidaDataDashGastos.ValueChanged += new System.EventHandler(this.dtPesquidaDataDashGastos_ValueChanged);
            this.dtPesquidaDataDashGastos.Enter += new System.EventHandler(this.dtPesquidaDataDashGastos_Enter);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEntrada.ForeColor = System.Drawing.Color.White;
            this.lblEntrada.Location = new System.Drawing.Point(10, 210);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(84, 19);
            this.lblEntrada.TabIndex = 1;
            this.lblEntrada.Text = "Entradas:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaida.ForeColor = System.Drawing.Color.White;
            this.lblSaida.Location = new System.Drawing.Point(406, 210);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(67, 19);
            this.lblSaida.TabIndex = 1;
            this.lblSaida.Text = "Saídas:";
            // 
            // dgEntrada
            // 
            this.dgEntrada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntrada.Location = new System.Drawing.Point(12, 233);
            this.dgEntrada.Name = "dgEntrada";
            this.dgEntrada.Size = new System.Drawing.Size(388, 284);
            this.dgEntrada.TabIndex = 3;
            this.dgEntrada.Text = "dataGridView1";
            // 
            // dgSaida
            // 
            this.dgSaida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaida.GridColor = System.Drawing.Color.Maroon;
            this.dgSaida.Location = new System.Drawing.Point(406, 234);
            this.dgSaida.Name = "dgSaida";
            this.dgSaida.Size = new System.Drawing.Size(373, 284);
            this.dgSaida.TabIndex = 3;
            this.dgSaida.Text = "dataGridView2";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoTotal.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSaldoTotal.Location = new System.Drawing.Point(12, 549);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(100, 19);
            this.lblSaldoTotal.TabIndex = 1;
            this.lblSaldoTotal.Text = "Saldo Total:";
            // 
            // lblValorSaldoTotal
            // 
            this.lblValorSaldoTotal.AutoSize = true;
            this.lblValorSaldoTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorSaldoTotal.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblValorSaldoTotal.Location = new System.Drawing.Point(107, 548);
            this.lblValorSaldoTotal.Name = "lblValorSaldoTotal";
            this.lblValorSaldoTotal.Size = new System.Drawing.Size(16, 20);
            this.lblValorSaldoTotal.TabIndex = 1;
            this.lblValorSaldoTotal.Text = "0";
            // 
            // picAno
            // 
            this.picAno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAno.Image = ((System.Drawing.Image)(resources.GetObject("picAno.Image")));
            this.picAno.Location = new System.Drawing.Point(10, 12);
            this.picAno.Name = "picAno";
            this.picAno.Size = new System.Drawing.Size(99, 75);
            this.picAno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAno.TabIndex = 6;
            this.picAno.TabStop = false;
            this.picAno.Tag = "";
            this.picAno.Click += new System.EventHandler(this.picAno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(226, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(333, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lançamentos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Relatorios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(368, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sair";
            // 
            // lblValorSaldoTotalEntrada
            // 
            this.lblValorSaldoTotalEntrada.AutoSize = true;
            this.lblValorSaldoTotalEntrada.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorSaldoTotalEntrada.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblValorSaldoTotalEntrada.Location = new System.Drawing.Point(164, 519);
            this.lblValorSaldoTotalEntrada.Name = "lblValorSaldoTotalEntrada";
            this.lblValorSaldoTotalEntrada.Size = new System.Drawing.Size(16, 20);
            this.lblValorSaldoTotalEntrada.TabIndex = 1;
            this.lblValorSaldoTotalEntrada.Text = "0";
            // 
            // lblTotalEntrada
            // 
            this.lblTotalEntrada.AutoSize = true;
            this.lblTotalEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalEntrada.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTotalEntrada.Location = new System.Drawing.Point(10, 520);
            this.lblTotalEntrada.Name = "lblTotalEntrada";
            this.lblTotalEntrada.Size = new System.Drawing.Size(158, 19);
            this.lblTotalEntrada.TabIndex = 1;
            this.lblTotalEntrada.Text = "Saldo total entrada:";
            // 
            // lblSaldoTotalSaida
            // 
            this.lblSaldoTotalSaida.AutoSize = true;
            this.lblSaldoTotalSaida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoTotalSaida.ForeColor = System.Drawing.Color.Red;
            this.lblSaldoTotalSaida.Location = new System.Drawing.Point(406, 522);
            this.lblSaldoTotalSaida.Name = "lblSaldoTotalSaida";
            this.lblSaldoTotalSaida.Size = new System.Drawing.Size(141, 19);
            this.lblSaldoTotalSaida.TabIndex = 1;
            this.lblSaldoTotalSaida.Text = "Saldo total saída:";
            // 
            // lblValorSaldoTotalSaida
            // 
            this.lblValorSaldoTotalSaida.AutoSize = true;
            this.lblValorSaldoTotalSaida.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorSaldoTotalSaida.ForeColor = System.Drawing.Color.Red;
            this.lblValorSaldoTotalSaida.Location = new System.Drawing.Point(553, 521);
            this.lblValorSaldoTotalSaida.Name = "lblValorSaldoTotalSaida";
            this.lblValorSaldoTotalSaida.Size = new System.Drawing.Size(16, 20);
            this.lblValorSaldoTotalSaida.TabIndex = 1;
            this.lblValorSaldoTotalSaida.Text = "0";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(791, 590);
            this.Controls.Add(this.lblValorSaldoTotalSaida);
            this.Controls.Add(this.lblSaldoTotalSaida);
            this.Controls.Add(this.lblTotalEntrada);
            this.Controls.Add(this.lblValorSaldoTotalEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picAno);
            this.Controls.Add(this.lblValorSaldoTotal);
            this.Controls.Add(this.lblSaldoTotal);
            this.Controls.Add(this.dgSaida);
            this.Controls.Add(this.dgEntrada);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.dtPesquidaDataDashGastos);
            this.Controls.Add(this.labelLancamentoDia);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROLE DE GASTOS";
            this.Activated += new System.EventHandler(this.Principal_Activated);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Click += new System.EventHandler(this.Principal_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelLancamentoDia;
        private System.Windows.Forms.DateTimePicker dtPesquidaDataDashGastos;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.DataGridView dgEntrada;
        private System.Windows.Forms.DataGridView dgSaida;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label lblValorSaldoTotal;
        private System.Windows.Forms.PictureBox picAno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValorSaldoTotalEntrada;
        private System.Windows.Forms.Label lblTotalEntrada;
        private System.Windows.Forms.Label lblSaldoTotalSaida;
        private System.Windows.Forms.Label lblValorSaldoTotalSaida;
    }
}

