namespace LJMSOFT.VIEW.PD_PRODUTO
{
    partial class ListaProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.pesquisaBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Silver;
            this.itemDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.itemDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.itemDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemDataGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.itemDataGridView.Location = new System.Drawing.Point(2, 2);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.ReadOnly = true;
            this.itemDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.itemDataGridView.RowHeadersVisible = false;
            this.itemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemDataGridView.Size = new System.Drawing.Size(1347, 664);
            this.itemDataGridView.TabIndex = 0;
            this.itemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataGridView_CellContentClick_1);
            this.itemDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellDoubleClick);
            this.itemDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.itemDataGridView_CellMouseClick);
            this.itemDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selecionaRow);
            // 
            // pesquisaBox
            // 
            this.pesquisaBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaBox.Location = new System.Drawing.Point(1066, 15);
            this.pesquisaBox.Name = "pesquisaBox";
            this.pesquisaBox.Size = new System.Drawing.Size(257, 32);
            this.pesquisaBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.itemDataGridView);
            this.panel1.Location = new System.Drawing.Point(7, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 643);
            this.panel1.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.BackgroundImage = global::LJMSOFT.Properties.Resources.cross;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.deleteButton.FlatAppearance.BorderSize = 3;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(174, 1);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 59);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.refreshButton.BackgroundImage = global::LJMSOFT.Properties.Resources.refresh_icon;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.refreshButton.FlatAppearance.BorderSize = 3;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(88, 1);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(80, 59);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.BackgroundImage = global::LJMSOFT.Properties.Resources.searchicon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1024, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adicionarButton
            // 
            this.adicionarButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adicionarButton.BackgroundImage = global::LJMSOFT.Properties.Resources.add;
            this.adicionarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adicionarButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.adicionarButton.FlatAppearance.BorderSize = 3;
            this.adicionarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarButton.Location = new System.Drawing.Point(3, 2);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(79, 59);
            this.adicionarButton.TabIndex = 1;
            this.adicionarButton.UseVisualStyleBackColor = false;
            this.adicionarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.refreshButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.adicionarButton);
            this.panel2.Controls.Add(this.pesquisaBox);
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 67);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ListaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LJMSOFT.Properties.Resources.backgroundn;
            this.ClientSize = new System.Drawing.Size(1346, 725);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "ListaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Activated += new System.EventHandler(this.ListaProduto_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.TextBox pesquisaBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel2;
    }
}