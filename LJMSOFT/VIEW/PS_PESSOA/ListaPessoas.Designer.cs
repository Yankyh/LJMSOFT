namespace LJMSOFT.VIEW.PS_PESSOA
{
    partial class ListaPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaPessoas));
            this.PessoadataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PesquisaPessoaRightBox = new System.Windows.Forms.RichTextBox();
            this.Pesquisabutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RefreshpictureBox = new System.Windows.Forms.PictureBox();
            this.Atualizar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PessoadataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PessoadataGridView1
            // 
            this.PessoadataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PessoadataGridView1.Location = new System.Drawing.Point(24, 87);
            this.PessoadataGridView1.Name = "PessoadataGridView1";
            this.PessoadataGridView1.Size = new System.Drawing.Size(983, 451);
            this.PessoadataGridView1.TabIndex = 0;
            this.PessoadataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.PessoadataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaPessoas_doubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Novo";
            // 
            // PesquisaPessoaRightBox
            // 
            this.PesquisaPessoaRightBox.Location = new System.Drawing.Point(806, 41);
            this.PesquisaPessoaRightBox.Name = "PesquisaPessoaRightBox";
            this.PesquisaPessoaRightBox.Size = new System.Drawing.Size(201, 26);
            this.PesquisaPessoaRightBox.TabIndex = 3;
            this.PesquisaPessoaRightBox.Text = "";
            this.PesquisaPessoaRightBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Pesquisabutton
            // 
            this.Pesquisabutton.Location = new System.Drawing.Point(725, 41);
            this.Pesquisabutton.Name = "Pesquisabutton";
            this.Pesquisabutton.Size = new System.Drawing.Size(75, 26);
            this.Pesquisabutton.TabIndex = 4;
            this.Pesquisabutton.Text = "Pesquisar";
            this.Pesquisabutton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(107, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 66);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sair";
            // 
            // RefreshpictureBox
            // 
            this.RefreshpictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshpictureBox.BackgroundImage")));
            this.RefreshpictureBox.Location = new System.Drawing.Point(194, 15);
            this.RefreshpictureBox.Name = "RefreshpictureBox";
            this.RefreshpictureBox.Size = new System.Drawing.Size(63, 63);
            this.RefreshpictureBox.TabIndex = 8;
            this.RefreshpictureBox.TabStop = false;
            this.RefreshpictureBox.Click += new System.EventHandler(this.RefreshpictureBox_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.AutoSize = true;
            this.Atualizar.Location = new System.Drawing.Point(203, 7);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(47, 13);
            this.Atualizar.TabIndex = 9;
            this.Atualizar.Text = "Atualizar";
            // 
            // ListaPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 546);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.RefreshpictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Pesquisabutton);
            this.Controls.Add(this.PesquisaPessoaRightBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PessoadataGridView1);
            this.Name = "ListaPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListaPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PessoadataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PessoadataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox PesquisaPessoaRightBox;
        private System.Windows.Forms.Button Pesquisabutton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox RefreshpictureBox;
        private System.Windows.Forms.Label Atualizar;
    }
}