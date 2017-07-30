namespace LJMSOFT.VIEW.PD_PRODUTO
{
    partial class CadastroItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.codigoBox = new System.Windows.Forms.TextBox();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.valorUnitarioBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.familiaCombo = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.fornecedorCombo = new System.Windows.Forms.ComboBox();
            this.unidadeMedidaCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.observacaoBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nome";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(823, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 27);
            this.label12.TabIndex = 42;
            this.label12.Text = "Código";
            // 
            // codigoBox
            // 
            this.codigoBox.Enabled = false;
            this.codigoBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoBox.Location = new System.Drawing.Point(828, 49);
            this.codigoBox.Name = "codigoBox";
            this.codigoBox.Size = new System.Drawing.Size(102, 39);
            this.codigoBox.TabIndex = 41;
            // 
            // nomeBox
            // 
            this.nomeBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeBox.Location = new System.Drawing.Point(12, 49);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(369, 39);
            this.nomeBox.TabIndex = 39;
            // 
            // valorUnitarioBox
            // 
            this.valorUnitarioBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorUnitarioBox.Location = new System.Drawing.Point(434, 141);
            this.valorUnitarioBox.Name = "valorUnitarioBox";
            this.valorUnitarioBox.Size = new System.Drawing.Size(233, 39);
            this.valorUnitarioBox.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(383, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 24);
            this.label15.TabIndex = 36;
            this.label15.Text = "Família";
            // 
            // familiaCombo
            // 
            this.familiaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familiaCombo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familiaCombo.FormattingEnabled = true;
            this.familiaCombo.Location = new System.Drawing.Point(387, 49);
            this.familiaCombo.Name = "familiaCombo";
            this.familiaCombo.Size = new System.Drawing.Size(435, 40);
            this.familiaCombo.TabIndex = 35;
            this.familiaCombo.DropDown += new System.EventHandler(this.listarFamilia);
            this.familiaCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f3event);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(434, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 24);
            this.label19.TabIndex = 34;
            this.label19.Text = "Valor unitário";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 24);
            this.label20.TabIndex = 33;
            this.label20.Text = "Fornecedor";
            // 
            // fornecedorCombo
            // 
            this.fornecedorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fornecedorCombo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornecedorCombo.FormattingEnabled = true;
            this.fornecedorCombo.Location = new System.Drawing.Point(12, 141);
            this.fornecedorCombo.Name = "fornecedorCombo";
            this.fornecedorCombo.Size = new System.Drawing.Size(416, 40);
            this.fornecedorCombo.TabIndex = 31;
            this.fornecedorCombo.DropDown += new System.EventHandler(this.listarFornecedor);
            // 
            // unidadeMedidaCombo
            // 
            this.unidadeMedidaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unidadeMedidaCombo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadeMedidaCombo.FormattingEnabled = true;
            this.unidadeMedidaCombo.Items.AddRange(new object[] {
            "KG",
            "UN",
            "PC"});
            this.unidadeMedidaCombo.Location = new System.Drawing.Point(673, 141);
            this.unidadeMedidaCombo.Name = "unidadeMedidaCombo";
            this.unidadeMedidaCombo.Size = new System.Drawing.Size(257, 40);
            this.unidadeMedidaCombo.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Unidade de medida";
            // 
            // observacaoBox
            // 
            this.observacaoBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacaoBox.Location = new System.Drawing.Point(12, 244);
            this.observacaoBox.Name = "observacaoBox";
            this.observacaoBox.Size = new System.Drawing.Size(918, 125);
            this.observacaoBox.TabIndex = 48;
            this.observacaoBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Observação";
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarButton.Location = new System.Drawing.Point(818, 375);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(112, 34);
            this.cadastrarButton.TabIndex = 50;
            this.cadastrarButton.Text = "Cadastrar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.Location = new System.Drawing.Point(12, 375);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(112, 34);
            this.cancelarButton.TabIndex = 51;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarButton.Location = new System.Drawing.Point(817, 375);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(112, 34);
            this.editarButton.TabIndex = 52;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // CadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 412);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.observacaoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unidadeMedidaCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.codigoBox);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.valorUnitarioBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.familiaCombo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.fornecedorCombo);
            this.Name = "CadastroItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar novo item";
            this.Load += new System.EventHandler(this.CadastroItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox codigoBox;
        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.TextBox valorUnitarioBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox familiaCombo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox fornecedorCombo;
        private System.Windows.Forms.ComboBox unidadeMedidaCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox observacaoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button editarButton;
    }
}