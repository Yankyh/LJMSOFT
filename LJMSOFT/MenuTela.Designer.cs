namespace LJMSOFT
{
    partial class MenuTela
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Pessoa");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Entrada");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Saída");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Caixa", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Agenda");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ERP", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Produto");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Serviço");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("ITEM", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.button1 = new System.Windows.Forms.Button();
            this.menuTreeView = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Provisoriobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(882, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Caixa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuTreeView
            // 
            this.menuTreeView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuTreeView.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTreeView.Location = new System.Drawing.Point(51, -1);
            this.menuTreeView.Name = "menuTreeView";
            treeNode1.Name = "Nó3";
            treeNode1.NodeFont = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "Pessoa";
            treeNode2.Name = "Nó0";
            treeNode2.NodeFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.Text = "Entrada";
            treeNode3.Name = "Nó1";
            treeNode3.NodeFont = new System.Drawing.Font("Arial", 15.75F);
            treeNode3.Text = "Saída";
            treeNode4.Name = "Nó4";
            treeNode4.NodeFont = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode4.Text = "Caixa";
            treeNode5.Name = "Nó2";
            treeNode5.NodeFont = new System.Drawing.Font("Arial", 20.25F);
            treeNode5.Text = "Agenda";
            treeNode6.Name = "Nó0";
            treeNode6.NodeFont = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode6.Text = "ERP";
            treeNode7.Name = "Nó4";
            treeNode7.NodeFont = new System.Drawing.Font("Arial", 15.75F);
            treeNode7.Text = "Produto";
            treeNode8.Name = "Nó6";
            treeNode8.NodeFont = new System.Drawing.Font("Arial", 15.75F);
            treeNode8.Text = "Serviço";
            treeNode9.Name = "Nó1";
            treeNode9.NodeFont = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode9.Text = "ITEM";
            this.menuTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9});
            this.menuTreeView.Size = new System.Drawing.Size(317, 733);
            this.menuTreeView.TabIndex = 3;
            this.menuTreeView.Visible = false;
            this.menuTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.menuTreeView_AfterSelect);
            this.menuTreeView.DoubleClick += new System.EventHandler(this.treeView1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-2, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 733);
            this.button2.TabIndex = 4;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::LJMSOFT.Properties.Resources.notepad_icon_29008;
            this.pictureBox1.Location = new System.Drawing.Point(864, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Provisoriobutton
            // 
            this.Provisoriobutton.Location = new System.Drawing.Point(687, 373);
            this.Provisoriobutton.Name = "Provisoriobutton";
            this.Provisoriobutton.Size = new System.Drawing.Size(77, 27);
            this.Provisoriobutton.TabIndex = 5;
            this.Provisoriobutton.Text = "Provisório apgar";
            this.Provisoriobutton.UseVisualStyleBackColor = true;
            this.Provisoriobutton.Click += new System.EventHandler(this.Provisoriobutton_Click);
            // 
            // MenuTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Provisoriobutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuTreeView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "MenuTela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuTela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView menuTreeView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Provisoriobutton;
    }
}

