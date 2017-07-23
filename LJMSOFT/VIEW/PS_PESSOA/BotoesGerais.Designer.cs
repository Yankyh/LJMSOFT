namespace LJMSOFT.VIEW.PS_PESSOA
{
    partial class BotoesGerais
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
            this.Cadastro = new System.Windows.Forms.Label();
            this.Voltarbutton = new System.Windows.Forms.Button();
            this.NovoCadastrobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSize = true;
            this.Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.Cadastro.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cadastro.Location = new System.Drawing.Point(28, 9);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(331, 31);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro efetuado com sucesso!";
            // 
            // Voltarbutton
            // 
            this.Voltarbutton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltarbutton.Location = new System.Drawing.Point(196, 93);
            this.Voltarbutton.Name = "Voltarbutton";
            this.Voltarbutton.Size = new System.Drawing.Size(163, 35);
            this.Voltarbutton.TabIndex = 1;
            this.Voltarbutton.Text = "Voltar";
            this.Voltarbutton.UseVisualStyleBackColor = true;
            this.Voltarbutton.Click += new System.EventHandler(this.Voltarbutton_Click);
            // 
            // NovoCadastrobutton
            // 
            this.NovoCadastrobutton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoCadastrobutton.Location = new System.Drawing.Point(12, 93);
            this.NovoCadastrobutton.Name = "NovoCadastrobutton";
            this.NovoCadastrobutton.Size = new System.Drawing.Size(161, 35);
            this.NovoCadastrobutton.TabIndex = 2;
            this.NovoCadastrobutton.Text = "Nova Pessoa";
            this.NovoCadastrobutton.UseVisualStyleBackColor = true;
            this.NovoCadastrobutton.Click += new System.EventHandler(this.NovoCadastrobutton_Click);
            // 
            // BotoesGerais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LJMSOFT.Properties.Resources.backgroundn;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.NovoCadastrobutton);
            this.Controls.Add(this.Voltarbutton);
            this.Controls.Add(this.Cadastro);
            this.Name = "BotoesGerais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BotoesGerais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.Button Voltarbutton;
        private System.Windows.Forms.Button NovoCadastrobutton;
    }
}