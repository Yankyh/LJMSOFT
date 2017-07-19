namespace LJMSOFT.VIEW.AG_AGENDA
{
    partial class Agenda
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxEntrega = new System.Windows.Forms.CheckBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerDe = new System.Windows.Forms.DateTimePicker();
            this.labelDe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerAte = new System.Windows.Forms.DateTimePicker();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(3, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Contas a pagar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(3, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(150, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Contas a receber";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(3, 67);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(135, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Tarefas a fazer";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxEntrega
            // 
            this.checkBoxEntrega.AutoSize = true;
            this.checkBoxEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEntrega.Location = new System.Drawing.Point(3, 97);
            this.checkBoxEntrega.Name = "checkBoxEntrega";
            this.checkBoxEntrega.Size = new System.Drawing.Size(161, 24);
            this.checkBoxEntrega.TabIndex = 3;
            this.checkBoxEntrega.Text = "Tarefas concluidas";
            this.checkBoxEntrega.UseVisualStyleBackColor = true;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(72, 144);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCliente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 599);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 100);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonLimpar);
            this.panel2.Controls.Add(this.buttonPesquisar);
            this.panel2.Controls.Add(this.dateTimePickerAte);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelDe);
            this.panel2.Controls.Add(this.dateTimePickerDe);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBoxEntrega);
            this.panel2.Controls.Add(this.comboBoxCliente);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 599);
            this.panel2.TabIndex = 0;
            // 
            // dateTimePickerDe
            // 
            this.dateTimePickerDe.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDe.Location = new System.Drawing.Point(72, 190);
            this.dateTimePickerDe.Name = "dateTimePickerDe";
            this.dateTimePickerDe.Size = new System.Drawing.Size(121, 26);
            this.dateTimePickerDe.TabIndex = 6;
            this.dateTimePickerDe.Value = new System.DateTime(2017, 7, 19, 1, 16, 29, 0);
            this.dateTimePickerDe.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelDe
            // 
            this.labelDe.AutoSize = true;
            this.labelDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDe.Location = new System.Drawing.Point(3, 195);
            this.labelDe.Name = "labelDe";
            this.labelDe.Size = new System.Drawing.Size(38, 20);
            this.labelDe.TabIndex = 7;
            this.labelDe.Text = "De :";
            this.labelDe.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ate :";
            // 
            // dateTimePickerAte
            // 
            this.dateTimePickerAte.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAte.Location = new System.Drawing.Point(72, 229);
            this.dateTimePickerAte.Name = "dateTimePickerAte";
            this.dateTimePickerAte.Size = new System.Drawing.Size(121, 26);
            this.dateTimePickerAte.TabIndex = 9;
            this.dateTimePickerAte.Value = new System.DateTime(2017, 7, 19, 1, 16, 29, 0);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.Location = new System.Drawing.Point(101, 368);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(92, 33);
            this.buttonPesquisar.TabIndex = 10;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(7, 368);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(92, 33);
            this.buttonLimpar.TabIndex = 11;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Agenda";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxEntrega;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDe;
        private System.Windows.Forms.Label labelDe;
        private System.Windows.Forms.DateTimePicker dateTimePickerAte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonPesquisar;
    }
}