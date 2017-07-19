namespace LJMSOFT.VIEW.AG_AGENDA
{
    partial class Form1
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
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.checkBoxAReceber = new System.Windows.Forms.CheckBox();
            this.checkBoxAPagar = new System.Windows.Forms.CheckBox();
            this.checkBoxComprar = new System.Windows.Forms.CheckBox();
            this.checkBoxTarefas = new System.Windows.Forms.CheckBox();
            this.buttonSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Location = new System.Drawing.Point(242, 167);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.Size = new System.Drawing.Size(1096, 550);
            this.dataGridViewLista.TabIndex = 0;
            // 
            // checkBoxAReceber
            // 
            this.checkBoxAReceber.AutoSize = true;
            this.checkBoxAReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAReceber.Location = new System.Drawing.Point(34, 251);
            this.checkBoxAReceber.Name = "checkBoxAReceber";
            this.checkBoxAReceber.Size = new System.Drawing.Size(122, 24);
            this.checkBoxAReceber.TabIndex = 1;
            this.checkBoxAReceber.Text = "A RECEBER";
            this.checkBoxAReceber.UseVisualStyleBackColor = true;
            this.checkBoxAReceber.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxAPagar
            // 
            this.checkBoxAPagar.AutoSize = true;
            this.checkBoxAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAPagar.Location = new System.Drawing.Point(34, 281);
            this.checkBoxAPagar.Name = "checkBoxAPagar";
            this.checkBoxAPagar.Size = new System.Drawing.Size(100, 24);
            this.checkBoxAPagar.TabIndex = 2;
            this.checkBoxAPagar.Text = "A PAGAR";
            this.checkBoxAPagar.UseVisualStyleBackColor = true;
            // 
            // checkBoxComprar
            // 
            this.checkBoxComprar.AutoSize = true;
            this.checkBoxComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxComprar.Location = new System.Drawing.Point(34, 311);
            this.checkBoxComprar.Name = "checkBoxComprar";
            this.checkBoxComprar.Size = new System.Drawing.Size(109, 24);
            this.checkBoxComprar.TabIndex = 3;
            this.checkBoxComprar.Text = "COMPRAR";
            this.checkBoxComprar.UseVisualStyleBackColor = true;
            // 
            // checkBoxTarefas
            // 
            this.checkBoxTarefas.AutoSize = true;
            this.checkBoxTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTarefas.Location = new System.Drawing.Point(34, 341);
            this.checkBoxTarefas.Name = "checkBoxTarefas";
            this.checkBoxTarefas.Size = new System.Drawing.Size(103, 24);
            this.checkBoxTarefas.TabIndex = 4;
            this.checkBoxTarefas.Text = "TAREFAS";
            this.checkBoxTarefas.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(114, 636);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(122, 81);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.Text = "SAIR";
            this.buttonSair.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.checkBoxTarefas);
            this.Controls.Add(this.checkBoxComprar);
            this.Controls.Add(this.checkBoxAPagar);
            this.Controls.Add(this.checkBoxAReceber);
            this.Controls.Add(this.dataGridViewLista);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.CheckBox checkBoxAReceber;
        private System.Windows.Forms.CheckBox checkBoxAPagar;
        private System.Windows.Forms.CheckBox checkBoxComprar;
        private System.Windows.Forms.CheckBox checkBoxTarefas;
        private System.Windows.Forms.Button buttonSair;
    }
}