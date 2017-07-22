namespace LJMSOFT.VIEW.CX_CAIXA
{
    partial class CaixaEntradaTela
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.codigoBox = new System.Windows.Forms.TextBox();
            this.valorTotalBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.formaPagamentoCombo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pessoaCombo = new System.Windows.Forms.ComboBox();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.quantidadeBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.itensCombo = new System.Windows.Forms.ComboBox();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.valorTotalPedidoBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tipoPagamentoCombo = new System.Windows.Forms.ComboBox();
            this.tabControl3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1231, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 27);
            this.label12.TabIndex = 28;
            this.label12.Text = "Código";
            // 
            // codigoBox
            // 
            this.codigoBox.Enabled = false;
            this.codigoBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoBox.Location = new System.Drawing.Point(1236, 50);
            this.codigoBox.Name = "codigoBox";
            this.codigoBox.Size = new System.Drawing.Size(102, 39);
            this.codigoBox.TabIndex = 27;
            // 
            // valorTotalBox
            // 
            this.valorTotalBox.Enabled = false;
            this.valorTotalBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalBox.Location = new System.Drawing.Point(887, 30);
            this.valorTotalBox.Name = "valorTotalBox";
            this.valorTotalBox.Size = new System.Drawing.Size(179, 32);
            this.valorTotalBox.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(15, 137);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(229, 39);
            this.textBox5.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1194, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 49);
            this.button3.TabIndex = 17;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Valor por parcela";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(487, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "Forma de pagamento";
            // 
            // formaPagamentoCombo
            // 
            this.formaPagamentoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formaPagamentoCombo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formaPagamentoCombo.FormattingEnabled = true;
            this.formaPagamentoCombo.Location = new System.Drawing.Point(491, 49);
            this.formaPagamentoCombo.Name = "formaPagamentoCombo";
            this.formaPagamentoCombo.Size = new System.Drawing.Size(313, 40);
            this.formaPagamentoCombo.TabIndex = 22;
            this.formaPagamentoCombo.DropDown += new System.EventHandler(this.listarFormaPagamento);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 24);
            this.label15.TabIndex = 21;
            this.label15.Text = "Cliente";
            // 
            // pessoaCombo
            // 
            this.pessoaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pessoaCombo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaCombo.FormattingEnabled = true;
            this.pessoaCombo.Location = new System.Drawing.Point(15, 49);
            this.pessoaCombo.Name = "pessoaCombo";
            this.pessoaCombo.Size = new System.Drawing.Size(470, 40);
            this.pessoaCombo.TabIndex = 20;
            this.pessoaCombo.DropDown += new System.EventHandler(this.listarCliente);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl3.Location = new System.Drawing.Point(31, 338);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1307, 379);
            this.tabControl3.TabIndex = 19;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.quantidadeBox);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.valorTotalBox);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.checkBox1);
            this.tabPage4.Controls.Add(this.itensCombo);
            this.tabPage4.Controls.Add(this.itemDataGridView);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1299, 341);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Itens";
            // 
            // quantidadeBox
            // 
            this.quantidadeBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeBox.Location = new System.Drawing.Point(791, 30);
            this.quantidadeBox.MaxLength = 7;
            this.quantidadeBox.Name = "quantidadeBox";
            this.quantidadeBox.Size = new System.Drawing.Size(90, 32);
            this.quantidadeBox.TabIndex = 22;
            this.quantidadeBox.TextChanged += new System.EventHandler(this.recalcularValorr);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(887, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 18);
            this.label16.TabIndex = 21;
            this.label16.Text = "Valor Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(789, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 18);
            this.label17.TabIndex = 20;
            this.label17.Text = "Quantidade";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 18);
            this.label18.TabIndex = 19;
            this.label18.Text = "Item";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(640, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 26);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Informar valor";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // itensCombo
            // 
            this.itensCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itensCombo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itensCombo.FormattingEnabled = true;
            this.itensCombo.Location = new System.Drawing.Point(5, 31);
            this.itensCombo.Name = "itensCombo";
            this.itensCombo.Size = new System.Drawing.Size(360, 32);
            this.itensCombo.TabIndex = 15;
            this.itensCombo.DropDown += new System.EventHandler(this.listarItens);
            this.itensCombo.DropDownClosed += new System.EventHandler(this.itensCombo_DropDownClosed);
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.itemDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.itemDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Location = new System.Drawing.Point(4, 67);
            this.itemDataGridView.MultiSelect = false;
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.ReadOnly = true;
            this.itemDataGridView.RowHeadersVisible = false;
            this.itemDataGridView.Size = new System.Drawing.Size(1290, 271);
            this.itemDataGridView.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1072, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 37);
            this.button4.TabIndex = 0;
            this.button4.Text = "Adcionar Item";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // valorTotalPedidoBox
            // 
            this.valorTotalPedidoBox.Enabled = false;
            this.valorTotalPedidoBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalPedidoBox.Location = new System.Drawing.Point(250, 137);
            this.valorTotalPedidoBox.Name = "valorTotalPedidoBox";
            this.valorTotalPedidoBox.Size = new System.Drawing.Size(176, 39);
            this.valorTotalPedidoBox.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(246, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 24);
            this.label19.TabIndex = 18;
            this.label19.Text = "Valor total";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(805, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(187, 24);
            this.label20.TabIndex = 16;
            this.label20.Text = "Tipo de pagamento";
            // 
            // tipoPagamentoCombo
            // 
            this.tipoPagamentoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPagamentoCombo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPagamentoCombo.FormattingEnabled = true;
            this.tipoPagamentoCombo.Location = new System.Drawing.Point(809, 49);
            this.tipoPagamentoCombo.Name = "tipoPagamentoCombo";
            this.tipoPagamentoCombo.Size = new System.Drawing.Size(313, 40);
            this.tipoPagamentoCombo.TabIndex = 15;
            this.tipoPagamentoCombo.DropDown += new System.EventHandler(this.listarTipoPagamento);
            // 
            // CaixaEntradaTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LJMSOFT.Properties.Resources.backgroundn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.codigoBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.valorTotalPedidoBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.formaPagamentoCombo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pessoaCombo);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tipoPagamentoCombo);
            this.Name = "CaixaEntradaTela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa - Entrada";
            this.Load += new System.EventHandler(this.CaixaEntradaTela_Load);
            this.tabControl3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox codigoBox;
        private System.Windows.Forms.TextBox valorTotalBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox formaPagamentoCombo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox pessoaCombo;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox quantidadeBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox valorTotalPedidoBox;
        private System.Windows.Forms.ComboBox itensCombo;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox tipoPagamentoCombo;
    }
}