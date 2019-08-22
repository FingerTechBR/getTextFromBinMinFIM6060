namespace getTextFromBinMinFIM6060
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.bt_converter = new System.Windows.Forms.Button();
            this.pathfilename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bt_converter
            // 
            this.bt_converter.Location = new System.Drawing.Point(113, 98);
            this.bt_converter.Name = "bt_converter";
            this.bt_converter.Size = new System.Drawing.Size(201, 23);
            this.bt_converter.TabIndex = 1;
            this.bt_converter.Text = "Converter";
            this.bt_converter.UseVisualStyleBackColor = true;
            this.bt_converter.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pathfilename
            // 
            this.pathfilename.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.pathfilename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.pathfilename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.pathfilename.Enabled = false;
            this.pathfilename.HideSelection = false;
            this.pathfilename.Location = new System.Drawing.Point(13, 26);
            this.pathfilename.Name = "pathfilename";
            this.pathfilename.Size = new System.Drawing.Size(290, 20);
            this.pathfilename.TabIndex = 1;
            this.pathfilename.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 215);
            this.Controls.Add(this.pathfilename);
            this.Controls.Add(this.bt_converter);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_converter;
        private System.Windows.Forms.TextBox pathfilename;
    }
}

